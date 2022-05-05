using System;
using System.Collections;

namespace collectionsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYLIST!");
            Console.WriteLine("===========");
            //declare arrayList
            ArrayList myArrayList = new ArrayList(); // indef amount
            ArrayList myArrayList2 = new ArrayList(100); // def amount of 100


            myArrayList.Add(25);
            myArrayList.Add("string");
            myArrayList.Add(25.23);
            myArrayList.Add(59.7777f);
            myArrayList.Add(87);

            // deletes specific entry from array
            myArrayList.Remove("string");

            // delete element at index #
            myArrayList.RemoveAt(1);

            // # of obj in arrayList
            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object item in myArrayList) //obj is highest level, most generic class
            {
                if (item is int || item is float)
                {
                    sum += Convert.ToDouble(item);
                } else if (item is double) // need to cast to double because item is of type object in the foreach loop.
                {
                    sum += (double)item;
                } else if (item is string){
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine(sum);


            Console.Read();
        }
    }
}
/*
 - Collections are classes that are used to store acolelciton of objects
 - not limited to one type of obj
- no size constraint. can grow as needed (called count, not length)

 Non-Generic Collection:
- can store any type of obj
- located in System.Collections namespace
ArrayList
 
  Generic Collection:
- stores only one type of obj
- located in System.Collections.Generic namespace
 List
List<string> myList = new List<string>();
 
 
 */