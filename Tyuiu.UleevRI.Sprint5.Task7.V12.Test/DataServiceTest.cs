using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.UleevRI.Sprint5.Task7.V12.Lib;

namespace Tyuiu.UleevRI.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\roman\source\repos\Tyuiu.UleevRI.Sprint5\Tyuiu.UleevRI.Sprint5.Task7.V12\bin\Debug\OutPutDataFileTask7V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
