using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Media;

class Program
{
    static void Main(string[] args)
    {


        System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        System.IO.Stream resourceStream =
        assembly.GetManifestResourceStream(@"ConsoleApplication2.music.wav");
        SoundPlayer player = new SoundPlayer(resourceStream);
        player.Play();
        //player.PlaySync();

        //1 zadanie
        //Переменные надписи tasks
        string task1 = "            ";
        string task2 = "████████╗░█████╗░░██████╗██╗░░██╗░██████╗";
        string task3 = "╚══██╔══╝██╔══██╗██╔════╝██║░██╔╝██╔════╝";
        string task4 = "░░░██║░░░███████║╚█████╗░█████═╝░╚█████╗░";
        string task5 = "░░░██║░░░██╔══██║░╚═══██╗██╔═██╗░░╚═══██╗";
        string task6 = "░░░██║░░░██║░░██║██████╔╝██║░╚██╗██████╔╝";
        string task7 = "░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░";


        //Переменные надписи end

        string end1 = "███████╗███╗░░██╗██████╗░";
        string end2 = "██╔════╝████╗░██║██╔══██╗";
        string end3 = "█████╗░░██╔██╗██║██║░░██║";
        string end4 = "██╔══╝░░██║╚████║██║░░██║";
        string end5 = "███████╗██║░╚███║██████╔╝";
        string end6 = "╚══════╝╚═╝░░╚══╝╚═════╝░";

        //Переменные надписи разделения

        string r1 = "            ";
        string r2 = "░░░██╗░██╗░░░░██╗░██╗░░░░██╗░██╗░░░░██╗░██╗░░░░██╗░██╗░░░░██╗░██╗░░░░██╗░██╗░";
        string r3 = "██████████╗██████████╗██████████╗██████████╗██████████╗██████████╗██████████╗";
        string r4 = "╚═██╔═██╔═╝╚═██╔═██╔═╝╚═██╔═██╔═╝╚═██╔═██╔═╝╚═██╔═██╔═╝╚═██╔═██╔═╝╚═██╔═██╔═╝";
        string r5 = "██████████╗██████████╗██████████╗██████████╗██████████╗██████████╗██████████╗";
        string r6 = "╚██╔═██╔══╝╚██╔═██╔══╝╚██╔═██╔══╝╚██╔═██╔══╝╚██╔═██╔══╝╚██╔═██╔══╝╚██╔═██╔══╝";
        string r7 = "░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░░╚═╝░╚═╝░░░";

        //Нумерация заданий 6 из 6 - обозначение ex1-ex6
        string ex1 = "Task 1";
        string ex2 = "Task 2";
        string ex3 = "Task 3";
        string ex4 = "Task 4";
        string ex5 = "Task 5";
        string ex6 = "Task 6";



        //Ввод переменных tasks1 - tasks7
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(task1);
        Console.WriteLine(task2);
        Console.WriteLine(task3);
        Console.WriteLine(task4);
        Console.WriteLine(task5);
        Console.WriteLine(task6);
        Console.WriteLine(task7);
        Console.ResetColor();



        string cat1 = " ";
        string cat2 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ";
        string cat3 = "░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░ ";
        string cat4 = "░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░ ";
        string cat5 = "░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░ ";
        string cat6 = "░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░ ";
        string cat7 = "░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░ ";
        string cat8 = "░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░ ";
        string cat9 = "░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░ ";
        string cat10 = "░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░ ";
        string cat11 = "░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░ ";
        string cat12 = "░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░ ";
        string cat13 = "░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░ ";
        string cat14 = "░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░ ";
        string cat15 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ";
        string cat16 = "                                        ";
        string ms_cat = "MISTER CAT!";



        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Loading");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Thread.Sleep(1000);



        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ms_cat);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat3);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat4);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat5);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat6);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat7);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat8);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat9);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat10);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat11);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat12);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat13);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat14);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat15);
       



        Console.WriteLine(cat16);
        string pos = ":";
        string pos1 = "█";
        string complete = " Complete Download";
        Thread.Sleep(250);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Download HomeWork:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("<:");
        for (int i = 0; i < 30; i++)
        {
            Thread.Sleep(50);

            Console.Write(pos1);



        }

        Thread.Sleep(1000);
        Console.Write(":>");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(complete);
        Thread.Sleep(1000);




        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ex1);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;



        Console.WriteLine("Введите число: ");
        double one_number = float.Parse(Console.ReadLine());
        double itog_number = Cube(one_number).Result;

        Console.WriteLine(itog_number);

        Console.ReadKey();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ex2);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;


        Console.WriteLine("Введите число 1:");
        string s = Console.ReadLine();
        int v = Convert.ToInt32(s);
        Console.WriteLine("Введите число 2:");
        string r = Console.ReadLine();
        int c = Convert.ToInt32(r);
        int частное = v / c;
        double d = Math.Pow(частное, 2);
        Console.WriteLine("Возведение в куб частного чиел 1 и 2 ={0}", d);



        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ex3);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;



        double aaa = 20, b = 40, ccc = 60;

        if (aaa > b && aaa > ccc)
            Console.WriteLine("Nubmer Max = " + aaa);
        else if (b > ccc)
            Console.WriteLine("Number Max = " + b);
        else
            Console.WriteLine("Number Max = " + ccc);

        Console.ReadLine();


        string sc1 = "П";
        string sc2 = "р";
        string sc3 = "о";
        string sc4 = "й";
        string sc5 = "д";
        string sc6 = "е";
        string sc7 = "н";
        string sc8 = "о";


        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write(sc1);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write(sc2);
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.Write(sc3);
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write(sc4);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write(sc5);
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.Write(sc6);
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write(sc7);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write(sc8);
        //Console.Write(cat16);
        //Console.ForegroundColor = ConsoleColor.Green;

        Console.ForegroundColor = ConsoleColor.Green; Thread.Sleep(50); Console.Write(sc1); Thread.Sleep(50); Console.ForegroundColor = ConsoleColor.Red; Thread.Sleep(50); Console.Write(sc2); Thread.Sleep(50); Console.ForegroundColor = ConsoleColor.Yellow; Thread.Sleep(50); Console.Write(sc3); Thread.Sleep(50); Console.ForegroundColor = ConsoleColor.Green; Thread.Sleep(50); Console.Write(sc4); Console.ForegroundColor = ConsoleColor.Red; Thread.Sleep(50); Console.Write(sc5); Console.ForegroundColor = ConsoleColor.Yellow; Thread.Sleep(50); Console.Write(sc6); Thread.Sleep(50); Console.ForegroundColor = ConsoleColor.Green; Thread.Sleep(50); Console.Write(sc7); Thread.Sleep(50); Console.ForegroundColor = ConsoleColor.Red; Thread.Sleep(50); Console.Write(sc8); Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Thread.Sleep(1000);
        Console.Write(" ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(DateTime.Now);

        Console.ReadKey();

    }

    public static async Task<double> Cube(double a)
        => await Task.Run(() =>
        {
            return Enumerable.Range(0, 1).AsParallel()
            .Select(_ => a * a * a).First();
        });









}