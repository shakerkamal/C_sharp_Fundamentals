using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;


namespace SymmetricEncryption;

public class EncryptionService
{
    private readonly byte[] _encryptionKey;
    //Store in the cache to avoid fetching the key in every call
    private static byte[] _cachedKey;
    private static DateTime _keyLastUpdated;

    public EncryptionService(string keyVaultUrl)
    {
        if (_cachedKey is null || (DateTime.UtcNow - _keyLastUpdated).TotalMinutes > 10)
        {
            var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
            var keyVaultSecret = client.GetSecret("EncryptionKey"); // Replace with your secret name in Key Vault
            _cachedKey = Convert.FromBase64String(keyVaultSecret.Value.Value);

            // Ensure the key is 256 bits (32 bytes)
            if (_cachedKey.Length != 32)
            {
                throw new InvalidOperationException("The encryption key must be 256 bits (32 bytes) long.");
            }

            _keyLastUpdated = DateTime.UtcNow; // Update key retrieval time
        }

        _encryptionKey = _cachedKey;
    }

    public async Task<string> EncryptAsync(string plainText)
    {
        using (AesGcm aesGcm = new AesGcm(_encryptionKey))
        {
            byte[] nonce = new byte[AesGcm.NonceByteSizes.MaxSize];
            byte[] ciphertext = new byte[plainText.Length];
            byte[] tag = new byte[AesGcm.TagByteSizes.MaxSize];

            // Generate a secure random nonce
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(nonce);
            }

            // Encrypt asynchronously (this operation is CPU-bound but wrapping in Task.Run)
            await Task.Run(() =>
            {
                aesGcm.Encrypt(nonce, Encoding.UTF8.GetBytes(plainText), ciphertext, tag);
            });

            byte[] result = new byte[nonce.Length + ciphertext.Length + tag.Length];
            Buffer.BlockCopy(nonce, 0, result, 0, nonce.Length);
            Buffer.BlockCopy(ciphertext, 0, result, nonce.Length, ciphertext.Length);
            Buffer.BlockCopy(tag, 0, result, nonce.Length + ciphertext.Length, tag.Length);

            return Convert.ToBase64String(result);
        }
    }

    public string Encrypt(string plainText)
    {
        using (AesGcm aesGcm = new AesGcm(_encryptionKey))
        {
            byte[] nonce = new byte[AesGcm.NonceByteSizes.MaxSize];  // 96 bits (12 bytes) is recommended
            byte[] ciphertext = new byte[plainText.Length];
            byte[] tag = new byte[AesGcm.TagByteSizes.MaxSize];  // 128 bits (16 bytes) tag for integrity

            // Generate a secure random nonce (IV)
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(nonce);
            }

            // Encrypt the plaintext with AES-GCM
            aesGcm.Encrypt(nonce, Encoding.UTF8.GetBytes(plainText), ciphertext, tag);

            // Combine the nonce, tag, and ciphertext into a single byte array for storage
            byte[] result = new byte[nonce.Length + ciphertext.Length + tag.Length];
            Buffer.BlockCopy(nonce, 0, result, 0, nonce.Length);
            Buffer.BlockCopy(ciphertext, 0, result, nonce.Length, ciphertext.Length);
            Buffer.BlockCopy(tag, 0, result, nonce.Length + ciphertext.Length, tag.Length);

            // Return the final encrypted result as a Base64 string
            return Convert.ToBase64String(result);
        }
    }

    public string Decrypt(string encryptedText)
    {
        byte[] fullCipher = Convert.FromBase64String(encryptedText);

        // Extract the nonce, ciphertext, and tag
        byte[] nonce = new byte[AesGcm.NonceByteSizes.MaxSize];  // 12-byte nonce
        byte[] tag = new byte[AesGcm.TagByteSizes.MaxSize];  // 16-byte tag
        byte[] ciphertext = new byte[fullCipher.Length - nonce.Length - tag.Length];

        Buffer.BlockCopy(fullCipher, 0, nonce, 0, nonce.Length);
        Buffer.BlockCopy(fullCipher, nonce.Length, ciphertext, 0, ciphertext.Length);
        Buffer.BlockCopy(fullCipher, nonce.Length + ciphertext.Length, tag, 0, tag.Length);

        using (AesGcm aesGcm = new AesGcm(_encryptionKey))
        {
            byte[] decryptedData = new byte[ciphertext.Length];

            // Decrypt the ciphertext
            aesGcm.Decrypt(nonce, ciphertext, tag, decryptedData);

            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Replace this with your actual Key Vault URL
        string keyVaultUrl = "https://<YourKeyVaultName>.vault.azure.net/";

        // Initialize Encryption Service
        var encryptionService = new EncryptionService(keyVaultUrl);

        // Example plaintext to encrypt
        string plaintext = "This is a secret message.";

        // Encrypt the plaintext
        string cipherText = encryptionService.Encrypt(plaintext);
        Console.WriteLine($"Encrypted: {cipherText}");

        // Decrypt the ciphertext
        string decryptedText = encryptionService.Decrypt(cipherText);
        Console.WriteLine($"Decrypted: {decryptedText}");
    }
}