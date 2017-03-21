using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSM;

namespace LSMTests
{
    [TestClass]
    public class LSMLengthTest
    {
        [TestMethod]
        public void LSM_LengthValid()
        {
            double[] X = new double[] { 1, 3, 5 },
                Y = new double[] { 3, 7, 11 };

            double[] expected = { 1, 2 };
            double[] actual = LSMeans.Calc(X, Y);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(VectorsLengthException))]
        public void LSM_LengthInvalid()
        {
            double[] X = new double[] { 1, 3, 5, 7 },
                Y = new double[] { 3, 7, 11 };
            double[] result = LSMeans.Calc(X, Y);
        }
    }
}
