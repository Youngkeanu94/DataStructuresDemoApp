using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Peck_Unit4
{
    internal class Program
    {
        struct structCar
        {
            public string make;
            public string model;
            public int modelYear;
        }
        static void Main(string[] args)
        {
            structCar[] cars = new structCar[3];
            cars[0] = new structCar();
            cars[0].make = "Ford";
            cars[0].model = "Mustang";
            cars[0].modelYear = 2010;

            cars[1] = new structCar();
            cars[1].make = "Chevrolet";
            cars[1].model = "Silverado";
            cars[1].modelYear = 2008;

            cars[2] = new structCar();
            cars[2].make = "Dodge";
            cars[2].model = "Charger";
            cars[2].modelYear = 2012;

            Console.WriteLine("Section 1: Array of Structures");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].make + " " + cars[i].model +" " + cars[i].modelYear);
            }
            Dictionary<string, int> inventoryCount = new Dictionary<string, int>();

            inventoryCount.Add("Mustang", 9);
            inventoryCount.Add("Silverado", 13);
            inventoryCount.Add("Charger", 4);

            Console.WriteLine();
            Console.WriteLine("Section 2: Inventory Count");

            Console.WriteLine("There are " + inventoryCount["Mustang"] + " Mustangs.");
            Console.WriteLine("There are " + inventoryCount["Silverado"] + " Silverados.");
            Console.WriteLine("There are " + inventoryCount["Charger"] + " Chargers.");



            ArrayList daysOfWeek = new ArrayList();
            daysOfWeek.Add("Sunday");
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");

            Console.WriteLine();
            Console.WriteLine("Section 3: Days of the Week");

            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Days of the week in reverse:");

            for (int i = daysOfWeek.Count - 1; i >=0; i--)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            ArrayList workDays = new ArrayList();
            workDays.AddRange(daysOfWeek);
            workDays.Remove("Saturday");
            workDays.Remove("Sunday");

            Console.WriteLine();
            Console.WriteLine("Work days:");

            for (int i = 0; i < workDays.Count; i++)
            {
                Console.WriteLine(workDays[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Section 4: Stack");


            Stack<int> myStack = new Stack<int>();

            myStack.Push(10);
            myStack.Push(24);
            myStack.Push(31);
            myStack.Push(45);
            myStack.Push(19);
            myStack.Push(76);

            Console.WriteLine("There are " + myStack.Count + " items on the stack.");

            Console.WriteLine("The next item to be popped from the stack is " + myStack.Peek() + ".");

            Console.WriteLine();
            Console.WriteLine("Section 5: Queue");

            Queue<int> q = new Queue<int>();

            q.Enqueue(10);
            q.Enqueue(24);
            q.Enqueue(31);
            q.Enqueue(45);
            q.Enqueue(19);
            q.Enqueue(76);

            Console.WriteLine("There are " + q.Count + " items in the queue.");

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("There are " + q.Count + " items in the queue.");

            Console.WriteLine("The next item to be dequeded from the queue is " + q.Peek() + ".");

            Console.ReadLine();

        }
    }
}
