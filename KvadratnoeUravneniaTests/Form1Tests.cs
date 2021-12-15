using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratnoeUravnenia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KvadratnoeUravnenia.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void DoubleRoot()
        {
            double a = 2;
            double b = -5;
            double c = 2;
            List<double> expected = new List<double>() {9,0.5,2};
            List<double> actual = KvadratnoeUravnenia.Form1.KvadU(a,b,c);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZeroFirst()
        {
            double a = 0;
            double b = -5;
            double c = 2;
            string expected = "При нулевом значении первого коэффициента квадратного уравнения, оно становится линейным, измените значение первого коэффициента.";
            try
            {
                List<double> actual = KvadratnoeUravnenia.Form1.KvadU(a, b, c);
                
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }
        [TestMethod()]
        public void NoRoot()
        {
            double a = 3;
            double b = 2;
            double c = 5;
            List<double> expected = new List<double>() {-56};
            List<double> actual = KvadratnoeUravnenia.Form1.KvadU(a, b, c);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void OneRoot()
        {
            double a = 3;
            double b = 6;
            double c = 3;
            List<double> expected = new List<double>() { 0,-1 };
            List<double> actual = KvadratnoeUravnenia.Form1.KvadU(a, b, c);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BigValue()
        {
            double a = 1E+7;
            double b = 100000000;
            double c = 2;
            List<double> expected = new List<double>();
            expected.Add(double.NegativeInfinity);
            expected.Add(double.PositiveInfinity);
            try
            {
                List<double> actual = KvadratnoeUravnenia.Form1.KvadU(a, b, c);
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {

            }
        }
    }
}