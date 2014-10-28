using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace PrimeFactor.UT
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class PrimeFactorTester
    {
        public PrimeFactorTester()
        {
        }

        [TestMethod]
        public void _1_has_empty()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            Program pro = new Program();
            int composite = 1;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _2_has_2()
        {
            Program pro = new Program();
            int composite = 2;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 2 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }

        [TestMethod]
        public void _3_has_3()
        {
            Program pro = new Program();
            int composite = 3;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 3 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _4_has_2()
        {
            Program pro = new Program();
            int composite = 4;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 2 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _6_has_2_and_3()
        {
            Program pro = new Program();
            int composite = 6;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 2, 3 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _8_has_2()
        {
            Program pro = new Program();
            int composite = 8;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 2 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _9_has_3()
        {
            Program pro = new Program();
            int composite = 9;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 3 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }
        [TestMethod]
        public void _10_has_2_and_5()
        {
            Program pro = new Program();
            int composite = 10;
            int[] factors = pro.GetPrimeFactor(composite);
            int[] expected = new int[] { 2, 5 };
            Assert.AreEqual(true, ArrayEquals<int>(factors, expected));
        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public static bool ArrayEquals<T>(T[] a, T[] b)
        {
            if (a.Length != b.Length)
                return false;
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a.Length; i++)
            {
                if (!comparer.Equals(a[i], b[i]))
                    return false;
            }
            return true;
        }
    }
}
