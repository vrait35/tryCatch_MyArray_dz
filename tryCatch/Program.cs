using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DivisionOfNumbers;
using MyArray;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
           // double divinded=0;
           // double divider=0;
           // bool isTrue = false;           
           // double result;
           //
           // while (isTrue == false)
           // {
           //     Console.Write("Здраствуйте, введите делимое число: ");
           //     isTrue = true;
           //     try
           //     {
           //         MathOperations.IsNumber(Console.ReadLine(), out divinded);
           //     }
           //     catch (ArgumentNullException ae)
           //     {
           //         Console.WriteLine("сообщение об ошибке: " + ae.Message);
           //         isTrue = false;
           //     }
           // }
           //
           // isTrue = false;
           //
           // while (isTrue == false)
           // {
           //     isTrue = true;
           //     Console.Write("Здраствуйте, введите делитель : ");
           //     try
           //     {
           //         MathOperations.IsNumber(Console.ReadLine(), out divider);
           //     }
           //     catch (ArgumentNullException ae)
           //     {
           //         Console.WriteLine("сообщение об ошибке: " + ae.Message);
           //         isTrue = false;
           //     }
           // }     
           // 
           // if (isTrue)
           // {
           //     try
           //     {
           //         result = MathOperations.DivisionOfNumbersTwo(divinded, divider);                    
           //             Console.WriteLine("Результат: " + result);
           //     }
           //     catch (ArgumentException ae)
           //     {
           //         Console.WriteLine("asd");
           //         Console.WriteLine("сообщение об исключения: " + ae.Message);
           //         Console.WriteLine("Источник: " + ae.Source);
           //         Environment.Exit(0);
           //     }                
           // }

            MyArray<string> array = new MyArray<string>(9);
            Console.WriteLine("capacity: " + array.Capacity);
            array[0] = "0";
            array[1] = "1";
            array[2] = "2";
            Console.Write("show(): ");
            array.Show();
            Console.WriteLine("-----------");
            array.Resize(5);
            Console.Write("show(): ");
            array.Show();
            Console.WriteLine("capacity: "+array.Capacity);
            Console.WriteLine("count: "+array.Count);
            Console.WriteLine("-----------");

            array.Resize(17);
            Console.Write("show(): ");
            array.Show();
            Console.WriteLine("capacity: " + array.Capacity);
            Console.WriteLine("count: " + array.Count);
            Console.WriteLine("-----------");

            array.Resize(30);
            Console.Write("show(): ");
            array.Show();
            Console.WriteLine("capacity: " + array.Capacity);
            Console.WriteLine("count: " + array.Count);
            if (array[20] == "") Console.WriteLine("array[20] ПУСТОЙ!");
            Console.WriteLine("+++++++++++++++");

            MyArray<double> array1 = new MyArray<double>();

            array1.Resize(10);

           // array1[5] = 5.5;
           // array1[3] = 3.5;
            Console.Write("array1.Show(): ");
            array1.Show();
            Console.WriteLine("capacity: " + array1.Capacity);
            Console.WriteLine("count: " + array1.Count);

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            int[] mas1 = new int[5];
            foreach(int a in mas1)
                Console.Write(a+"  ");
            Console.WriteLine("\n");

            string[] mas2 = new string[5];
            foreach(string a in mas2)
                Console.Write(a);
            Console.WriteLine("\n");

            Console.WriteLine("mas2.Length="+ mas2.Length);
            //Console.WriteLine("mas2[4].length= "+mas2[4].Length);

            string s = "Anuar";
            f(s);
            Console.WriteLine(s);
        }
        static void f(string str)
        {
            str = "asdr";
        }
    }
   
}
