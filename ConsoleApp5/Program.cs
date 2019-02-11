using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 20;
            while (num > 2)
            {

                Console.Write(num + " ");
                num--;
            }

            int number = 2;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number < 15);


            int counter = 0;

            do
            {

                Console.WriteLine(counter);


                counter++;
            }
            while (counter < 4);

            string name = "Isaac";
            string password = "Isaac2729";
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter your Name");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter Your password");
                string password1 = Console.ReadLine();
                if ((name1 == name) && (password1 == password))
                {
                    Console.WriteLine("Welcome");
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong password,try again");
                }
            }

            Console.WriteLine();
            Console.WriteLine("loop 2");
            int counter1 = 0;
            do
            {
                Console.WriteLine("Enter your name");
                string name2 = Console.ReadLine();
                Console.WriteLine("Enter your password ");
                string password2 = Console.ReadLine();
                if ((name2 == name) && (password2 == password))
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password,try again");
                }
                counter1++;
            }
           
            while (counter1 < 3);

            Console.WriteLine();
            Console.WriteLine("loop 3");

                int count = 0;
                while (count < 3)
                {
                    Console.WriteLine("Enter your name");
                    string name3 = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    string password3 = Console.ReadLine();
                    if ((name3 == name) && (password3 == password))
                    {
                        Console.WriteLine("welcome");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password,retry");
                    }

                    count++;
                }
                
                Console.ReadKey();


         }
     }
}
   

