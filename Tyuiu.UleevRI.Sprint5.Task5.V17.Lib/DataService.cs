using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.UleevRI.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    double x = Convert.ToDouble(line);
                    double l = Math.Round(x, 0);
                    if (x == l)
                    {
                        int m = 0;
                        for (int i = 1; i <= Math.Abs(x); i++)
                        {
                            if (x % i == 0) m += 1;
                        }
                        if (m == 2) res += x;
                        else res += 0;
                    }
                }
            }
            return res;
        }
    }
}
