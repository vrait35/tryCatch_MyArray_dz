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
           double divinded=0;
           double divider=0;
           bool isTrue = false;           
           double result;
          
           while (isTrue == false)
           {
               Console.Write("Здраствуйте, введите делимое число: ");
               isTrue = true;
               try
               {
                   MathOperations.IsNumber(Console.ReadLine(), out divinded);
               }
               catch (ArgumentNullException ae)
               {
                   Console.WriteLine("сообщение об ошибке: " + ae.Message);
                   isTrue = false;
               }
           }
          
           isTrue = false;
          
           while (isTrue == false)
           {
               isTrue = true;
               Console.Write("Здраствуйте, введите делитель : ");
               try
               {
                   MathOperations.IsNumber(Console.ReadLine(), out divider);
               }
               catch (ArgumentNullException ae)
               {
                   Console.WriteLine("сообщение об ошибке: " + ae.Message);
                   isTrue = false;
               }
           }     
           
           if (isTrue)
           {
               try
               {
                   result = MathOperations.DivisionOfNumbersTwo(divinded, divider);                    
                       Console.WriteLine("Результат: " + result);
               }
               catch (ArgumentException ae)
               {                   
                   Console.WriteLine("сообщение об исключения: " + ae.Message);
                   Console.WriteLine("Источник: " + ae.Source);
                   Environment.Exit(0);
               }                
           }
            //2 -задание
            Console.WriteLine("\nСделать исключения  если выйдет за пределы массива!");
            MyArray<int> array = new MyArray<int>(9);
            try
            {
                array[0] = 10;
                array[1] = 11;
                array[2] = 12;
            }
            catch (ArgumentException ae) {
                Console.WriteLine("Исключения: "+ae.Message);
            }            
            Show(array);
            array.Resize(5);            
            Show(array);
            Console.WriteLine("----------");
            MyArray<string> array1 = new MyArray<string>(5);
            try
            {
                array1[4] = "asd";
                array1[8] = "bnm";               
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Исключения: "+ae.Message);
                Environment.Exit(0);
            }          
            Show(array1);
            array1.Resize(8);
            Show(array1);
        }
        static void Show<T>(MyArray<T> array)
        {
            for(int i=0;i<array.Capacity;i++)
                Console.Write(array[i]+"+");
            Console.WriteLine();
        }
    }
   
}
