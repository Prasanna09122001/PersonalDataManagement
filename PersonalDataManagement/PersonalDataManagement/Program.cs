using System;
using System.Net.Sockets;

namespace PersonalDataManagement
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Personal Data Management");
            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                SSN = 1,
                Name = "a",
                Address = "a",
                Age = 15
            });
            persons.Add(new Person()
            {
                SSN = 2,
                Name = "b",
                Address = "b",
                Age = 32
            });
            persons.Add(new Person()
            {
                SSN = 3,
                Name = "c",
                Address = "c",
                Age = 29
            });
            persons.Add(new Person()
            {
                SSN = 4,
                Name = "d",
                Address = "d",
                Age = 26
            });
            persons.Add(new Person()
            {
                SSN = 5,
                Name = "e",
                Address = "e",
                Age = 12
            });
            persons.Add(new Person()
            {
                SSN = 6,
                Name = "f",
                Address = "f",
                Age = 43
            });
            persons.Add(new Person()
            {
                SSN = 7,
                Name = "g",
                Address = "g",
                Age = 63
            });
            persons.Add(new Person()
            {
                SSN = 8,
                Name = "h",
                Address = "h",
                Age = 49
            });
            persons.Add(new Person()
            {
                SSN = 9,
                Name = "i",
                Address = "i",
                Age = 76
            });
            persons.Add(new Person()
            {
                SSN = 10,
                Name = "j",
                Address = "j",
                Age = 56
            });
            Operation operation = new Operation();
         /*   Console.WriteLine("Retreie the Top Two Records");
            operation.RetreiveTopTwoRecors(persons);
            Console.WriteLine("Retreive the Records Between Two Ages");
            operation.RetreiveRecordsInBetweenAge(persons);
            Console.WriteLine("Find the Average Age Of the List");
            operation.AverageList(persons);
            Console.WriteLine("Retreive the Person Details By Using The Name");
            operation.RetreivePersonDetailsByName(persons);
            Console.WriteLine("Skip the Data Upto Age of 60");
            operation.RecordsOfAge(persons);*/
            Console.WriteLine("Removing Of Data");
            operation.DeleeteDataFromList(persons);

        }
    }
}