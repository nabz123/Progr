using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Assignment
{
    public struct names
    {
        public string fname;
        public string lname;
        public string inter;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            names[] Lastname = new names[30];
            welcome();
            read(Lastname);
            sort(Lastname);
            Greeting();
            options();
            witch(Lastname);
            
            
            
            
            Lotto();
            Console.ReadLine();
        }
        public static void welcome()
        {
            Console.WriteLine("                            ___  _                       _____      _       _            _           _      ");
            Console.WriteLine("                           / __\\ | |                    |  __ \\    | |     | |          | |         (_)     ");
            Console.WriteLine("                          | |  | | |_ __ _  __ _  ___   | |__) |__ | |_   _| |_ ___  ___| |__  _ __  _  ___ ");
            Console.WriteLine("                          | |  | | __/ _` |/ _` |/ _ \\  |  ___/ _ \\| | | | | __/ _ \\/ __| '_ \\| '_ \\| |/ __|");
            Console.WriteLine("                          | |__| | || (_| | (_| | (_) | | |  | (_) | | |_| | ||  __/ (__| | | | | | | | (__ ");
            Console.WriteLine("                           \\____/ \\__\\__,_|\\__, |\\___/  |_|   \\___/|_|\\__, |\\__\\___|\\___|_| |_|_| |_|_|\\___|");
            Console.WriteLine("                                            __/ |                      __/ |                                ");
            Console.WriteLine("                                           |___/                      |___/                                 ");
            Console.WriteLine("");
            Console.WriteLine("                   _____ _   _ _____ __  ___                                     _                                  _   ");
            Console.WriteLine("                  |_   _| \\ | | ____/_ |/ _ \\                      /\\           (_)                                | |  ");
            Console.WriteLine("                    | | |  \\| | |__  | | | | |                    /  \\   ___ ___ _  __ _ _ __  _ __ ___   ___ _ __ | |_ ");
            Console.WriteLine("                    | | | . ` |___ \\ | | | | |                   / /\\ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __|");
            Console.WriteLine("                   _| |_| |\\  |___) || | |_| |                  / ____ \\__ \\__ \\ | (_| | | | | | | | | |  __/| | | |_ ");
            Console.WriteLine("                  |_____|_| \\_|____/ |_|\\___/                  /_/    \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|");
            Console.WriteLine("                                                                                      __/ |                               ");
            Console.WriteLine("                                                                                     |___/                                ");
            Console.WriteLine("");
            Console.WriteLine(" __          ___                                 _         _          _                    __  __ _ _ _ _                   _            ___  ");
            Console.WriteLine(" \\ \\        / / |                               | |       | |        | |                  |  \\/  (_) | (_)                 (_)          |__ \\ ");
            Console.WriteLine("  \\ \\  /\\  / /| |__   ___   __      ____ _ _ __ | |_ ___  | |_ ___   | |__   ___    __ _  | \\  / |_| | |_  ___  _ __   __ _ _ _ __ ___     ) |");
            Console.WriteLine("   \\ \\/  \\/ / | '_ \\ / _ \\  \\ \\ /\\ / / _` | '_ \\| __/ __| | __/ _ \\  | '_ \\ / _ \\  / _` | | |\\/| | | | | |/ _ \\| '_ \\ / _` | | '__/ _ \\   / / ");
            Console.WriteLine("    \\  /\\  /  | | | | (_) |  \\ V  V / (_| | | | | |_\\__ \\ | || (_) | | |_) |  __/ | (_| | | |  | | | | | | (_) | | | | (_| | | | |  __/  |_|  ");
            Console.WriteLine("     \\/  \\/   |_| |_|\\___/    \\_/\\_/ \\__,_|_| |_|\\__|___/  \\__\\___/  |_.__/ \\___|  \\__,_| |_|  |_|_|_|_|_|\\___/|_| |_|\\__,_|_|_|  \\___|  (_)  ");
            Thread.Sleep(5000);
            Console.Clear();
        }
        public static void read(names[] Lastname)
        {
            StreamReader sr = new StreamReader(@"millionaire.txt");
            int count = 0;
            while (!sr.EndOfStream)
            {
                Lastname[count].fname = sr.ReadLine();
                Lastname[count].lname = sr.ReadLine();
                Lastname[count].inter = sr.ReadLine();
                count++;
            }
            sr.Close();
        }
        public static void sort(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length - 1; i++)
            {
                for (int pos = 0; pos < Lastname.Length - 1; pos++)
                {
                    if (Lastname[pos + 1].lname.CompareTo(Lastname[pos].lname) < 0)
                    {
                        names temp = Lastname[pos + 1];

                        Lastname[pos + 1] = Lastname[pos];
                        Lastname[pos] = temp;
                    }
                }
            }
        }
        public static void display(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length; i++)
            {
                Console.Write($" {Lastname[i].lname.PadRight(30)}");
                Console.Write($"{Lastname[i].fname.PadRight(20)}");
                Console.WriteLine($"{Lastname[i].inter}");
            }
        }
        public static void edit(names[] Lastname)
        {
            bool found = false;
            Console.WriteLine("Who's interests would you like to change?");
            string edit = Console.ReadLine();
            for (int i = 0; i < Lastname.Length; i++)
            {
                if (Lastname[i].lname == edit)
                {
                    Console.WriteLine("What would you like to change it to?:");
                    Lastname[i].inter = Console.ReadLine();
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Person not found");
            }
        }
        public static void display2(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length; i++)
            {
                Console.Write($" {Lastname[i].lname.PadRight(30)}");
                Console.Write($"{Lastname[i].fname.PadRight(20)}");
                Console.WriteLine($"{Lastname[i].inter}");
            }
        }
        public static void Lotto()
        {
            Random Rand = new Random();
            int[] Lottoo = new int[10];

            for (int i = 0; i < Lottoo.Length; i++)
            {
                Lottoo[i] = -1;
            }
            int lot = Rand.Next(0, 30);
            for (int i = 0; i < Lottoo.Length; i++)
            {
                while (Lottoo.Contains(lot))
                {
                    lot = Rand.Next(0, 30);
                }
                Lottoo[i] = lot;
                Console.WriteLine(Lottoo[i]);
            }
        }
        public static void Greeting()
        {
            Console.WriteLine("Welcome to the menu");

        }
        public static void Contestants(names[] Lastname)
        {
            Console.WriteLine("Contestants Names");
            display(Lastname);
            Console.ReadLine();
            
        }
        public static void Edit(names[] Lastname)
        {
            Console.WriteLine("Edit Contestants");
            display(Lastname);
            
            edit(Lastname);
            display2(Lastname);
            Console.ReadLine();
        }
        public static void task3()
        {
            Console.WriteLine("This is task 3");
            Console.ReadLine();
        }
        public static void task4()
        {
            Console.WriteLine("This is task 4");
            Console.ReadLine();
        }
        public static void exit()
        {
            Console.WriteLine("Exit menu");
            Console.ReadLine();
        }
        public static void options()
        {
            Console.WriteLine("1 Contestants Names");
            Console.WriteLine("2 Edit Contestants");
            Console.WriteLine("3 Task 3");
            Console.WriteLine("4 Task 4");
            Console.WriteLine("0 Exit Menu");
        }
        public static void witch(names[] Lastname)
        {
            int intt;
            string tmep;
            do
            {
                Console.Clear();
                options();
                Console.WriteLine("Please choose a menu: ");
                tmep = Console.ReadLine();
                intt = Convert.ToInt32(tmep);
                Console.Clear();

                switch (intt)
                {
                    case 1:
                        Contestants(Lastname);
                        break;
                    case 2:
                        Edit(Lastname);
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 0:
                        exit();
                        break;

                }
            } while (intt < 10);
            Console.ReadLine();

        }
    }
     
}
