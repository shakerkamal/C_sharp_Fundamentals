namespace Enums;

internal class Program
{
    static void Main(string[] args)
    {
        var currentState = ChestState.Open;
        string input;
        for(; ; )
        {
            Console.WriteLine($"The chest is {currentState}. What do you want to do?");
            input = Console.ReadLine().ToLower();

            if ( input == "close" && currentState == ChestState.Open)
            {
                currentState = ChestState.Closed;
            }
            else if ( input == "open" && currentState == ChestState.Open)
            {
                Console.WriteLine($"The chest is already {currentState}. What do you want to do?o?");
            }
            else if (input == "lock" && currentState == ChestState.Open)
            {
                Console.WriteLine($"The chest is {currentState}. You need to close the state first. What do you want to do?");
            }
            else if (input == "unlock" && currentState == ChestState.Open)
            {
                Console.WriteLine($"The chest is already {currentState}. What do you want to do?");
            }
            else if (input == "open" && currentState == ChestState.Closed)
            {
                currentState = ChestState.Open;
            }
            else if (input == "close" && currentState == ChestState.Closed)
            {
                Console.WriteLine($"The chest is already {currentState}. What do you want to do?");
            }
            else if (input == "lock" && currentState == ChestState.Closed)
            {
                currentState = ChestState.Locked;
            }
            else if (input == "unlock" && currentState == ChestState.Closed)
            {
                Console.WriteLine($"The chest is {currentState}. You need to lock first to unlock it. What do you want to do?");
            }
            else if (input == "open" && currentState == ChestState.Locked)
            {
                Console.WriteLine($"The chest is {currentState}. Unlock it first. What do you want to do?");
            }
            else if (input == "close" && currentState == ChestState.Locked)
            {
                Console.WriteLine($"The chest is {currentState}. Unlock it first. What do you want to do?");
            }
            else if (input == "lock" && currentState == ChestState.Locked)
            {
                Console.WriteLine($"The chest is already  {currentState} . What do you want to do?");
            }
            else if (input == "unlock" && currentState == ChestState.Locked)
            {
                currentState = ChestState.Closed;
            }
        }
    }
}

enum ChestState : byte
{
    Open,
    Closed,
    Locked
}