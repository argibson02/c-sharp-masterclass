using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryPractice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>
            //    List<int>

            Dictionary<int, string> myDic = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" } };

            Employee[] employees = {
                new Employee("CEO", "GWyn", 54, 95.234f),
                new Employee("Mananger", "joe", 44, 66.234f),
                new Employee("HR", "lora", 35, 35.234f),
                new Employee("Secetary", "petra", 28, 75.234f),
                new Employee("SDE", "Antony", 24, 65.234f),
                new Employee("Intern", "Antony", 18, 20.234f)
            };


            Dictionary<string, Employee> employeeDic = new Dictionary<string, Employee>();

            // add data to dic
            foreach (Employee person in employees)
            {
                employeeDic.Add(person.Role, person);
            }

            // retireve

            Employee readEmp = employeeDic["CEO"];
            Console.WriteLine($"role: {readEmp.Role}, name: {readEmp.Name}, Age: {readEmp.Age}, rate: {readEmp.Rate}, salary: {readEmp.Salary}.");


            // retreive with error check
            string key = "CEO";
            if (employeeDic.ContainsKey(key))
            {
                Employee readEmp1 = employeeDic[key];
                Console.WriteLine($"role: {readEmp1.Role}, name: {readEmp1.Name}, Age: {readEmp1.Age}, rate: {readEmp1.Rate}, salary: {readEmp1.Salary}.");

            }

            // anoter way to error check
            if (employeeDic.TryGetValue("Intern", out Employee result))
            {
                Console.WriteLine($"role: {result.Role}, name: {result.Name}, Age: {result.Age}, rate: {result.Rate}, salary: {result.Salary}.");
            }

            // updating key
            string keyToUpdate = "HR";
            if (employeeDic.ContainsKey(keyToUpdate))
            {
                employeeDic[keyToUpdate] = new Employee("HR", "Eleka", 23, 22.35f);
            }
            else
            {
                Console.WriteLine("No employee with that id found");
            }

            // removing a key
            string keyToRemove = "Intern";
            if (employeeDic.Remove(keyToRemove))
            {
                Console.WriteLine("employee removed");
            }
            else
            {
                Console.WriteLine("No employee with that id found");
            }



            // get element at
            for (int i = 0; i < employeeDic.Count; i++)
            {
                // using ElementsAt(i) to return a key-value pair stored at index i
                KeyValuePair<string, Employee> keyValueP = employeeDic.ElementAt(i);

                // write the key 
                Console.WriteLine("key " + keyValueP.Key);

                // storing the vlaue in an employee object
                Employee employee = keyValueP.Value;

                Console.WriteLine($"role: {employee.Role}, name: {employee.Name}, Age: {employee.Age}, rate: {employee.Rate}, salary: {employee.Salary}.");
            }

            Console.WriteLine("===========================================");

            Console.WriteLine("Hello World!");
        }
    }
}
