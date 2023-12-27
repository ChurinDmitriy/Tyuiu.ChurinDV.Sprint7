using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint7.Project.V6;
using System.IO;


namespace Tyuiu.ChurinDV.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint7\Tyuiu.ChurinDV.Sprint7.Project.V6\bin\Debug\doctorsbase.csv"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileTwo()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint7\Tyuiu.ChurinDV.Sprint7.Project.V6\bin\Debug\patientsbase.csv"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
