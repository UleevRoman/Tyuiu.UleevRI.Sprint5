using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint5.Task0.V2.Lib;


namespace Tyuiu.UleevRI.Sprint5.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 2                                                               *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y = (e^x)/x вычислить его значение при x = 3, результат  *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.    *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
