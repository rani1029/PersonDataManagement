using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagementLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to person data Management!");
            //creating list of person 
            List<Person> Personlist = new List<Person>();
            AddPersonDetails(Personlist);
            IteratePersoninList(Personlist);
            //RetrieveTopTwoRecords(Personlist);
            //uc3
            RetrieveAgeRange(Personlist);


        }
        //Add Default values to list
        public static void AddPersonDetails(List<Person> Personlist)
        {
            Personlist.Add(new Person() { SSN = 1, Name = "Rohit", Address = "Delhi", Age = 25 });
            Personlist.Add(new Person() { SSN = 2, Name = "vikash", Address = "Deheradun", Age = 65 });
            Personlist.Add(new Person() { SSN = 3, Name = "john", Address = "Dispur", Age = 23 });
            Personlist.Add(new Person() { SSN = 4, Name = "Mark", Address = "Mumbai", Age = 18 });
            Personlist.Add(new Person() { SSN = 5, Name = "rashi", Address = "Kolkta", Age = 16 });
            Personlist.Add(new Person() { SSN = 6, Name = "Sumit", Address = "chennai", Age = 68 });
        }
        //display Person details in the List
        public static void IteratePersoninList(List<Person> Personlist)
        {
            foreach (Person person in Personlist)
            {
                Console.WriteLine("SSN={0}\tName={1}\tAddress={2}\tAge={3})", person.SSN, person.Name, person.Address, person.Age);
            }
        }
        //UC-2 to get Top 2 records age less than 60
        public static void RetrieveTopTwoRecords(List<Person> Personlist)
        {
            //Age less than 60 using Lambda Expresion 

            //List<Person> AgeLessThanSixty = Personlist.FindAll(person => person.Age < 60);
            //Console.WriteLine("Displaying person details if age is less than 60");
            //IteratePersoninList(AgeLessThanSixty);

            //sorted list

            //List<Person> AsecendingList = AgeLessThanSixty.OrderBy(age => age.Age).ToList();
            //Console.WriteLine(" person details after sorting by Age");
            //IteratePersoninList(AsecendingList);

            //sorted top two records

            //List<Person> TopTwo = AsecendingList.Take(2).ToList();
            //Console.WriteLine("Top Two records of Age less than sixty");
            //IteratePersoninList(TopTwo);

            //All 3 can steps in one Line 

            List<Person> SortedResult = Personlist.FindAll(person => person.Age < 60).OrderBy(age => age.Age).Take(2).ToList();
            Console.WriteLine("Top Two records of Age less than sixty");
            IteratePersoninList(SortedResult);

        }
        //UC-3 Retrieve Reccords between age 13 to 18
        public static void RetrieveAgeRange(List<Person> Personlist)
        {
            List<Person> Resultlist = Personlist.FindAll(person => person.Age > 13 && person.Age < 18);
            Console.WriteLine("Records having Age between 13 to 18");
            IteratePersoninList(Resultlist);
        }



    }
}
