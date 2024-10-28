using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу (39-44):");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 39:
                    Task39();
                    break;

                case 40:
                    Task40();
                    break;

                case 41:
                    Task41();
                    break;

                case 42:
                    Task42();
                    break;

                case 43:
                    Task43();
                    break;

                case 44:
                    Task44();
                    break;

                default:
                    Console.WriteLine("Некорректный номер задачи.");
                    break;
            }
        }

        static void Task39()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} - четное");
                }
                else
                {
                    Console.WriteLine($"{number} - нечетное");
                }
            }
        }

        static void Task40()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[,] multiArray = CreateMultiArray(array);
            Console.WriteLine($"{multiArray[0, 0]}, {multiArray[0, 1]}");
        }

        static int[,] CreateMultiArray(int[] array)
        {
            int[,] result = new int[2, 3];
            for (int i = 0; i < array.Length; i++)
            {
                result[i / 3, i % 3] = array[i];
            }
            return result;
        }

        static void Task41()
        {
            List<object> items = new List<object> { 1, "test", 3.14 };
            var processedItems = ProcessItems(items);
            foreach (var item in processedItems)
            {
                Console.WriteLine(item);
            }
        }

        static List<object> ProcessItems(List<object> items)
        {
            List<object> results = new List<object>();
            foreach (var item in items)
            {
                results.Add(item);
            }
            return results;
        }

        static void Task42()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] newArray = FilterArray(array, x => x > 2);
            Console.WriteLine(string.Join(", ", newArray));
        }

        static int[] FilterArray(int[] array, Func<int, bool> predicate)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (predicate(item)) count++;
            }

            int[] result = new int[count];
            int index = 0;
            foreach (var item in array)
            {
                if (predicate(item)) result[index++] = item;
            }
            return result;
        }

        static void Task43()
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Alice", 30);
            Console.WriteLine(person1.Equals(person2));
        }

        class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override bool Equals(object obj)
            {
                if (obj is Person other)
                {
                    return Name == other.Name && Age == other.Age;
                }
                return false;
            }
        }

        static void Task44()
        {
            int N = 5;
            int[] result = GenerateArray(N);
            Console.WriteLine(string.Join(", ", result));
        }

        static int[] GenerateArray(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
    }
        
}
