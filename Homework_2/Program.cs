using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main()
        {
            /*
            Task 2.9
            Для задачи 2.4 вычислить возраст человека.
            Какой тип данных выберете для хранения возраста?                   
            */

            string name = "Ivan";
            string surname = "Ivanov";
            ushort yearOfBirth = 1989;
            string sex = "male";
            int idNumber = 123456789;

            byte age = (byte)(DateTime.Now.Year - yearOfBirth);
            Console.WriteLine("Task 2.9 solution");
            Console.WriteLine($"Username age is: {age}\n");

            /*
            Task 2.10
            Для задачи 2.4 добавить возможность хранения
            номера банковской карточки. Вывести номер
            банковкой карточки в формате
            1111 2222 3333 4444                 
            */

            long bankCardNumber = 1234567812345678;
            Console.WriteLine("Task 2.10 solution");
            Console.WriteLine($"Username bank card is: {string.Format("{0:#### #### #### ####}", bankCardNumber)}\n");

            /*
            Task 2.13
            Объявить две переменные a=4, b=5;
            Необходимо сделать так, чтобы без объявления других
            переменных в результате работы алгоритма значения
            переменных поменялись местами. Например,
            если изначально a = 4, b = 5, то в результате алгоритма
            стало a = 5, b = 4. Применять можно только операции присваивания
            и арифметические операции с числами и значениями переменных.               
            */

            int a = 4;
            int b = 5;

            a = ++a;
            b = --b;

            Console.WriteLine("Task 2.13 solution");
            Console.WriteLine($"new value of a = {a}");
            Console.WriteLine($"new value of b = {b}");

        }
    }
}
