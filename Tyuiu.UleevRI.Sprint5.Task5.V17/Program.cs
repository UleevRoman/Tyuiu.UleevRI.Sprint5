using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.UleevRI.Sprint5.Task5.V17.Lib;

namespace Tyuiu.UleevRI.Sprint5.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 17                                                              *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask5V17.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5 и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти сумму всех *");
            Console.WriteLine("* простых целых чисел в файле. Полученный результат вывести на консоль. У *");
            Console.WriteLine("* вещественных значений округлить до трёх знаков после запятой.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма всех простых целых чисел равна = " + res);
            Console.ReadKey();
        }
    }
}
