using System;

namespace PersonDataManagementLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to person data Management!");
            //creating list of person 
            List<Person> Personlist=new List<Person>();
            AddPersonDetails(Personlist);
            

        }
        //Add Default values to list
        public static void AddPersonDetails(List<Person> Personlist)
            {
            Personlist.Add(new Person(){SSN = 1, Name = "Rohit", Address = "Delhi", Age = 25});
            Personlist.Add(new Person(){SSN = 2, Name = "vikash", Address = "Deheradun", Age = 65});
            Personlist.Add(new Person(){SSN = 3, Name = "john", Address = "Dispur", Age = 23});
            Personlist.Add(new Person(){SSN = 4, Name = "Mark", Address = "Mumbai", Age = 18});
            Personlist.Add(new Person(){SSN = 5, Name = "rashi", Address = "Kolkta", Age = 16});
            Personlist.Add(new Person(){SSN = 6, Name = "Sumit", Address = "chennai", Age = 68});
        }
        //display Person details in  List
        public static void IteratePersoninList(List<Person> Personlist)
            {
            foreach(Person person in Personlist)
                {
                Console.WriteLine("SSN={0}\tName={1}\tAddress={2}\tAge={3})",person.SSN,person.Name,person.Address,person.Age);
            }
        }

           
    }
}
