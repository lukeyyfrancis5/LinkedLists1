using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #1
            Node.MyList list = new Node.MyList();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);
            list.AddToEnd(4);
            list.Print();
            */


            /*#2
            Console.WriteLine("Please add first node value: ");

            LinkedList myList1 = new LinkedList();
            myList1.Addfirst("I");
            myList1.Addfirst("Love");
            myList1.Addfirst("Computer Science");
            myList1.Print();
            Console.WriteLine();

            Console.WriteLine("Please add last node value ");
            LinkedList myList2 = new LinkedList();
            myList2.AddLast("I");
            myList2.AddLast("Love");
            myList2.AddLast("Computer");
            myList2.Print();
            Console.WriteLine();
            */

            /*#3
            //Console.WriteLine("Here are the cars in stock !");

            StockList carInventory = new StockList();

            CarType car = new CarType();
            car.Name = "BMW";
            car.Price = 81750;
            car.Color = "White";
            car.Year = 2018;
            car.ID = 2355;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Audi";
            car.Price = 75250;
            car.Color = "Red";
            car.Year = 2019;
            car.ID = 5193;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Volvo";
            car.Price = 35500;
            car.Color = "Blue";
            car.Year = 2015;
            car.ID = 1830;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Lincoln";
            car.Price = 55000;
            car.Color = "White";
            car.Year = 2017;
            car.ID = 3243;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Infiniti";
            car.Price = 43700;
            car.Color = "Grey";
            car.Year = 2018;
            car.ID = 7290;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Porsche";
            car.Price = 95600;
            car.Color = "Light Grey";
            car.Year = 2015;
            car.ID = 4510;
            carInventory.Add(car);

            car = new CarType();
            car.Name = "Jaguar";
            car.Price = 86600;
            car.Color = "Black";
            car.Year = 2016;
            car.ID = 9837;
            carInventory.Add(car);


            Console.WriteLine("---> Store Inventory <---");
            Console.WriteLine("Number of cars in stock: {0} ", carInventory.Count);


            for (int i = 0; i < carInventory.Count; i++)
            {
                CarType info = carInventory.Retrieve(i);
                Console.WriteLine("\nCar info ");
                Console.WriteLine("ID: {0}", info.ID);
                Console.WriteLine("Name: {0}", info.Name);
            } */

            PersonList personInventory = new PersonList();

            Person person = new Person();

            person.Name = "Jamie";
            person.Age = 25;
            person.Sex = "Male";
            person.Height = 74;
            person.Weight = 210;
            person.HairColor = "Black";
            person.EyeColor = "Brown";
            person.SkinColor = "Tan";
            personInventory.Add(person);

            person = new Person();
            person.Name = "Jill";
            person.Age = 30;
            person.Sex = "Female";
            person.Height = 66;
            person.Weight = 135;
            person.HairColor = "Blonde";
            person.EyeColor = "Green";
            person.SkinColor = "White";
            personInventory.Add(person);

            person = new Person();
            person.Name = "Josh";
            person.Age = 31;
            person.Sex = "Male";
            person.Height = 69;
            person.Weight = 185;
            person.HairColor = "Brown";
            person.EyeColor = "Blue";
            person.SkinColor = "White";
            personInventory.Add(person);


            Console.WriteLine("---> Person Inventory <---\n\n");
            Console.WriteLine("Number of people in Database: {0}", personInventory.Count);

            for (int i = 0; i < personInventory.Count; i++)
            {
                Person info = personInventory.Get(i);
                Console.WriteLine("\nPerson info ");
                Console.WriteLine("Name: {0}", info.Name);
                Console.WriteLine("Sex: {0}", info.Sex);
                Console.WriteLine("Age {0}", info.Age);
            }
            
        }

    }
}
