using System;
using System.Collections;

namespace hashtables
{
    internal class Program
    {
        // key - value
        // in hashtable, key and value can be be of different types. In dictionarires, they must be of the same type.
        // auto - car
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hashtable StudentTable = new Hashtable();

            Student student1 = new Student(1, "Albert", 99);
            Student student2 = new Student(2, "Beau", 07);
            Student student3 = new Student(3, "Coleen", 56);
            Student student4 = new Student(4, "Dereck", 87);
            Student student4B = new Student(4, "Eric", 57);
            Student student5 = new Student(5, "Fiona", 97);


            StudentTable.Add(student1.Id, student1);
            StudentTable.Add(student2.Id, student2);
            StudentTable.Add(student3.Id, student3);
            StudentTable.Add(student4.Id, student4);

            // retrieve indiviual item with know id
            Student storedStudent = (Student)StudentTable[1];
            Student storedStudent2 = (Student)StudentTable[student1.Id];

            Console.WriteLine($"Student Id: {student1.Id}, Name: {storedStudent.Name}, GPA: {storedStudent.GPA}");

            // retrieve all items in table
            foreach (DictionaryEntry item in StudentTable)
            {
                Student temp = (Student)item.Value;
                Console.WriteLine($"Student Id: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
            }

            // alt
            foreach (Student item in StudentTable.Values)
            {
                Console.WriteLine($"Student Id: {item.Id}, Name: {item.Name}, GPA: {item.GPA}");

            }



            // CHALLENGE
            Student[] studentsChal = new Student[6];
            studentsChal[0]= new Student(13, "CHALLENGE Albert", 99);
            studentsChal[1]= new Student(23, "CHALLENGE Beau", 07);
            studentsChal[2]= new Student(33, "CHALLENGE Coleen", 56);
            studentsChal[3]= new Student(43, "CHALLENGE Dereck", 87);
            studentsChal[4]= new Student(43, "CHALLENGE Eric", 57);
            studentsChal[5]= new Student(53, "CHALLENGE Fiona", 97);

            Hashtable StudentChalTable = new Hashtable();

            //for (int i = 0; i < studentsChal.Length; i++)
            foreach (Student item in studentsChal)
            {
                Student temp = item;

                if (StudentChalTable.ContainsKey(temp.Id)){
                    Console.WriteLine("A student with id already exists.");

                }
                else {
                    StudentChalTable.Add(temp.Id, temp);
                    Console.WriteLine($"Added: Student Id: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
                }
            }

            StudentChalTable.Clear();
            Console.WriteLine("alt===");

            for (int i = 0; i < studentsChal.Length; i++)
            {
                Student temp = studentsChal[i];

                if (StudentChalTable.ContainsKey(temp.Id))
                {
                    Console.WriteLine("A student with id already exists.");

                }
                else
                {
                    StudentChalTable.Add(temp.Id, temp);
                    Console.WriteLine($"Added: Student Id: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
                }
            }


            Console.Read();
        }

    }
}
