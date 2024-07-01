using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _21._102_Zotochkina_01;

 namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestNMin()
        {
            // Arrange
            double[] array = { 3.14, 2.71, 1.618, 0.0, 42.0 };

            // Act
            int minIndex = Program.NMin(array, array.Length);

            // Assert
            Assert.AreEqual(3, minIndex); // Предполагаем, что минимальный элемент массива находится по индексу 3
        }

        [TestMethod]
        public void TestNMax()
        {
            // Arrange
            double[] array = { 3.14, 2.71, 1.618, 0.0, 42.0 };

            // Act
            int maxIndex = Program.NMax(array, array.Length);

            // Assert
            Assert.AreEqual(4, maxIndex); // Предполагаем, что максимальный элемент массива находится по индексу 4
        }

        [TestMethod]
        public void TestNMinAndMaxSameElement()
        {
            // Arrange
            double[] array = { 3.14, 2.71, 1.618, 42.0, 42.0 };

            // Act
            int minIndex = Program.NMin(array, array.Length);
            int maxIndex = Program.NMax(array, array.Length);

            // Assert
            Assert.AreEqual(2, minIndex); // Предполагаем, что минимальный элемент массива находится по индексу 2
            Assert.AreEqual(3, maxIndex); // Предполагаем, что максимальный элемент массива находится по индексу 3
        }
    }
}

