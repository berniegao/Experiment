using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TogglingDoors_Kata;

namespace TogglingDoorsTest
{
    [TestClass]
    public class DoorTogglingUnitTester
    {
        [TestMethod]
        public void _1_door_1_pass()
        {
            Door d = new Door(1);
            int[] result = d.Pass(1);
            Assert.IsTrue(ArrayEquals(new int[] { Door.OPEN }, result));
        }

        [TestMethod]
        public void _2_door_1_pass()
        {
            Door d = new Door(2);
            int[] result = d.Pass(1);
            Assert.IsTrue(ArrayEquals(new int[] { Door.OPEN, Door.OPEN }, result));
        }

        [TestMethod]
        public void _2_door_2_pass()
        {
            Door d = new Door(2);
            int[] result = d.Pass(2);
            Assert.IsTrue(ArrayEquals(new int[] { Door.OPEN, Door.CLOSE }, result));
        }
        [TestMethod]
        public void _3_door_1_pass()
        {
            Door d = new Door(3);
            int[] result = d.Pass(1);
            Assert.IsTrue(ArrayEquals(new int[] { Door.OPEN, Door.OPEN, Door.OPEN }, result));
        }
        [TestMethod]
        public void _3_door_2_pass()
        {
            Door d = new Door(3);
            int[] result = d.Pass(2);
            Assert.IsTrue(ArrayEquals(new int[] { Door.OPEN, Door.CLOSE, Door.OPEN }, result));
        }


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
