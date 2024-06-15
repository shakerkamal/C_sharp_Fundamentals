public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age{ get; set; }
    public string FullName{ 
        get{
            return FirstName +' '+ LastName;
        } 
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public static void Greet()
    {
        System.Console.WriteLine("Hello, Everyone!");
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {FullName}!");
    }

    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine($"Happy birthday! I am now {Age} years old.");
    }

    public bool AnAdult()
    {
        return Age >= 18;
    }

    public static void CelebrateBirthdayForAll(Person[] people)
    {
        foreach (var person in people)
        {
            person.Age++;
            Console.WriteLine($"{person.FullName} celebrated a birthday and is now {person.Age} years old.");
        }
    }
}