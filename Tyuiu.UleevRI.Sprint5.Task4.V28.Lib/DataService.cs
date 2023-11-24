using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.UleevRI.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            x = x.Replace(".", ",");
            double res = Math.Round((3 * Math.Pow(Convert.ToDouble(x), 3)) / Math.Sin(Convert.ToDouble(x)), 3);
            return res;
        }
    }
}
