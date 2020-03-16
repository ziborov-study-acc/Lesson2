using Lesson2.Controllers;
using Lesson2.Helpers;
using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2 {
    class Program {
        static void Main(string[] args) {

            Tasks tasks = new Tasks();
            Random random = new Random();

            int factorialNumber = random.Next(1, 25);
            Console.WriteLine($"Факториал для {factorialNumber} : {tasks.FactorialTask(factorialNumber)}");

            int fibonacciNumber = random.Next(1, 25);
            Console.WriteLine($"Фибоначчи для {fibonacciNumber} : {tasks.FibonacciTask(fibonacciNumber)}");


            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Исходный массив");
            foreach (var item in array)
                Console.Write($"{item}\t");
            Console.WriteLine();
            Console.WriteLine($"Группировка чётных и нечетных\n{tasks.SortTask(array)}");



            PersonManager personManager = new PersonManager(new List<Person> { 
                new Person("John","Dou",45),
                new Person("Johhny","Smith",25),
                new Person("Wayne","Dou",56),
                new Person("Marry","Lake",20),
                new Person("Frank","Smith",89),
                new Person("Adam","Douglas",13),
                new Person("Jake","Douglas",45),
                new Person("Bill","Jackson",48),
                new Person("Ann","Smith",23),
                new Person("Kate","Ho",13),
                new Person("Stephen","Fry",62),
                new Person("Bill","Lake",56),
            });

            PesonMethods methods = new PesonMethods();

            personManager.DisplayCollection(personManager.OrderByAscending(methods.OrderByAge), "Отсортированы по возрасту (ASC)");
            personManager.DisplayCollection(personManager.OrderByDescending(methods.OrderByAge), "Отсортированы по возрасту (DESC)");

            personManager.DisplayCollection(personManager.OrderByAscending(methods.OrderByName), "Отсортированы по имени (ASC)");
            personManager.DisplayCollection(personManager.OrderByDescending(methods.OrderByName), "Отсортированы по имени (DESC)");

            personManager.DisplayCollection(personManager.OrderByAscending(methods.OrderBySurname), "Отсортированы по фамилии (ASC)");
            personManager.DisplayCollection(personManager.OrderByDescending(methods.OrderBySurname), "Отсортированы по фамилии (DESC)");



            personManager.DisplayGroups(personManager.GroupBy(methods.OrderByAge), "Сгруппировано по возрасту");
            personManager.DisplayGroups(personManager.GroupBy(methods.OrderByName), "Сгруппировано по имени");
            personManager.DisplayGroups(personManager.GroupBy(methods.OrderBySurname), "Сгруппировано по фамилии");




            Console.ReadKey();
        }

        public static void Output(IEnumerable<Person> people,string message) {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

    }

    
}
