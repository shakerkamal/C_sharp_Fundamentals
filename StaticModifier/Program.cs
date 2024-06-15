//calling static method
Person.Greet();

//instantiating an object of the class
//here the object is Mehedi
Person Mehedi = new Person(firstName:"Mehedi", lastName: "Hasan", age: 17);
Person Hasib = new Person(firstName:"Hasib", lastName: "Bashar", age: 26);

Person[] people = {Mehedi, Hasib};
Mehedi.SayHello();

if(Mehedi.AnAdult()){
    System.Console.WriteLine("I am an adult");
}else{
    System.Console.WriteLine("I am still young");
}

Mehedi.CelebrateBirthday();

if(Mehedi.AnAdult()){
    System.Console.WriteLine("I am an adult");
}else{
    System.Console.WriteLine("I am still young");
}

Person.CelebrateBirthdayForAll(people);

System.Console.WriteLine(LocalDate.GetLocalDate().ToLongDateString());

TimeZoneInfo timeZone = TimeZoneInfo.Local;
System.Console.WriteLine(timeZone.StandardName);

System.Console.ReadLine();