using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 3;
            //nums[2] = 17;
            //Array.Resize(ref nums, 20);

            //int[] arr1 = {12, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Reverse(arr1);

            //Array.Sort(arr1);

            //int[,] arr2 = { {1,2,3 },{ 4, 5, 6 },{ 8, 1, 3 } };
            //Console.WriteLine(arr2.Rank);

            //Console.WriteLine(arr2.Length);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Object
            //var stu1 = new
            //{
            //    name = "Babek",
            //    surname = "Qasimov",
            //    age = 18,
            //    isMarried = false
            //};

            //var stu2 = new
            //{
            //    name = "Resul",
            //    surname = "Hesenli",
            //    age = 34,
            //    isMarried = true
            //};

            //var stu3 = new
            //{
            //    name = "Samir",
            //    surname = "Teymurov",
            //    age = 65,
            //    isMarried = true
            //};

            //var stu4 = new
            //{
            //    name = "Farid",
            //    surname = "Mahmudov",
            //    age = 13,
            //    isMarried = false
            //};

            //Console.WriteLine($"{stu4.name}");

            //object[] students = { stu1, stu2, stu3, stu4 };
            //foreach(var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Class
            //Car car1 = new Car
            //{
            //    name = "Bugatti",
            //    color = "Black",
            //    speed = 500
            //};

            //Car car2 = new Car();
            //car2.name = "Audi";
            //car2.color = "white";
            //car2.speed = 300;

            //Console.WriteLine(car1.name);
            //Console.WriteLine(car2.speed + " " + car1.color );

            //Worker w1 = new Worker();
            //Console.WriteLine(w1.GetFullName());
            //Console.WriteLine(w1.GetFullData());

            //Animal dog1 = new Animal("Pitbull");
            //Console.WriteLine(dog1.name);

            //Employee emp1 = new Employee(true);
            
            //Console.WriteLine(emp1.GetFullData());
        }
    }

    

    class Employee
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public bool IsMarried;


        public Employee():this(33)
        {
            Console.WriteLine("Hello P414");
        }
        public Employee(int number)
        {
            Console.WriteLine(number);
        }
        public Employee(string empName, string empSurname, int empAge)
        {
            Console.WriteLine(empName + " " + empSurname + " - " + empAge);
            age = empAge;
        }
        public Employee(string empAdress)
        {
            address = empAdress;
            Console.WriteLine(address);
        }
        public Employee(bool maried):this()
        {
            IsMarried = maried;
            Console.WriteLine(IsMarried);
        }

        public string GetFullName()
        {
            return "Letif Vekilov";
        }

        public string GetFullData()
        {
            return GetFullName() + "-" + "29";
        }
         
    }

    class Worker
    {
        public string name = "Letif";
        public string surname = "Vekilov";
        public int age = 43;

        public string GetFullName()
        {
            return "Letif Vekilov";
        }

        public string GetFullData()
        {
            return GetFullName() + "-" + "29";
        }
    }

    class Animal
    {
        public string name;
        public Animal()
        {

        }
        public Animal(string dogName)
        {
            name = dogName;
        }

    }

    class Car
    {
        public string name;
        public string color;
        public double speed;
    }

}
#endregion