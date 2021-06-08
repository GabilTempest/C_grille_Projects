using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{

    class Program
    {
        //public List<string> cars;
        // private static int id;
        // public static string path;


        static void Main(string[] args)
        {



            Cars cars = new Cars();


            string menu;

            //do
            //{
            //   // Console.WriteLine("");
            //    menu = Console.ReadLine();
            //    switch (menu)
            //    {
            //        case "add":
            //            cars.AddCar();
            //            break;

            //        case "remove":
            //            cars.RemoveCar();
            //            break;

            //        case "all":
            //            cars.GetAll();
            //            break;
            //        default:
            //            menu = "default";
            //            Console.WriteLine("default");
            //            break;
            //    }

            //}  

            while (true)
            {
                // Console.WriteLine("");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "add":
                        cars.AddCar();
                        break;

                    case "remove":
                        cars.RemoveCar();
                        break;

                    case "clear":
                        cars.ClearAll();
                        break;

                    case "all":
                        cars.GetAll();
                        break;
                    case "exit":
                        Console.WriteLine("end");
                        return;

                    default:
                        Console.WriteLine("default");
                        break;

                }

            }






        }



    }


    class Cars
    {


        public int id;
        public string name;
        public string wheels;
        public string color;
        public string speed;


        public Cars()
        {

        }

        public Cars(int id, string name, string wheels, string color, string speed)
        {
            this.id = id;
            this.name = name;
            this.wheels = wheels;
            this.color = color;
            this.speed = speed;
        }

        public void AddCar()
        {
            // public List<string> cars;
            var cars = new List<Cars>();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Wheels:");
            string wheels = Console.ReadLine();
            try
            {
                int b = Convert.ToInt32(wheels);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Не число");
                Console.WriteLine("Wheels:");
                wheels = Console.ReadLine();


            }

            Console.WriteLine("Color:");
            string color = Console.ReadLine();
            try
            {
                int a = Convert.ToInt32(color);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Не число");
                Console.WriteLine("Wheels:");
                color = Console.ReadLine();


            }
            Console.WriteLine("Speed:");
            string speed = Console.ReadLine();
            try
            {
                int c = Convert.ToInt32(speed);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Не число");
                Console.WriteLine("Speed:");
                speed = Console.ReadLine();


            }



            




            cars.Add(new Cars() { name = name, wheels = wheels, color = color, speed = speed });
            //for (id = 0; id < cars.Count; id++) { }


            foreach (var p in cars)
            {
                Console.WriteLine("Car :" + " " + " " + "Name:" + " " + p.name + ", " + "wheels:" + ", "
                + p.wheels + ", " + "color:" + p.color + ", " + "speed:" + " " + p.speed);

                p.MemList();
            }


        }
        public void RemoveCar()
        {
            Console.WriteLine("id:");
            int id = Convert.ToInt32(Console.ReadLine());
            string filePath = (@"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt");
            int numberOfLineToDelete = id;
            string[] fileLines = File.ReadAllLines(filePath);
            fileLines[numberOfLineToDelete] = "";
            File.WriteAllLines(filePath, fileLines);
            string[] readText = File.ReadAllLines(filePath, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }


            int i;
            string[] mass = File.ReadAllLines(@"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt");
            StreamWriter NewFile = File.CreateText(@"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt");
            for (i = 0; i < mass.Length; i++)
            {
                if (mass[i] != "")
                {
                    NewFile.WriteLine(mass[i]);
                }
            }
            NewFile.Close();
        }



        public void MemList()
        {
            string path = @"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt";

            if (!File.Exists(path))
            {
                string[] createText = { };
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }
            string appendText = "Car :" + " " + " " + "Name:" + " " + name + ", " + "wheels:" + ", "
                    + wheels + ", " + "color:" + color + ", " + "speed:" + " " + speed + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string s in readText)
            {
                // Console.WriteLine(s);
            }


        }
        public void GetAll()
        {
            string path = @"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt";

            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
            

        }
        
        public void ClearAll()
        {
            

            StreamWriter strm = File.CreateText(@"D:\А_ПОЛіТЕХ\Програмування\С#\Практичні\ZAVDANYA\Car3\MyTest.txt");
            strm.Flush();
            Console.WriteLine("Очищено");

           strm.Close();




        }
    }

}









