using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Neha_Vishwakarma_8772541_Assignment2;

namespace Rectangle_Test
{
    public class Reactangle_Test
    {
        [TestFixture]

        public class RectangleTest1
        {
            // test cases for GetLength method
            [Test]

            public void GetLength_Value2()
            {
                // Arrange
                Rectangle rect = new Rectangle(2, 3);
                int expected = 2;

                // Act
                int actual = rect.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            [Test]

            public void GetLength_Value3()
            {
                // Arrange
                Rectangle rect = new Rectangle(3, 3);
                int expected = 3;

                // Act
                int actual = rect.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]

            public void GetLength_Value4()
            {
                // Arrange
                Rectangle rect = new Rectangle(3, 3);
                int expected = 3;

                // Act
                int actual = rect.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // test cases for SetLength method

            [Test]

            public void SetLength_Value2()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 3;

                // Act
                int actual = rect.SetLength(3);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]

            public void SetLength_Value5()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 5;

                // Act
                int actual = rect.SetLength(5);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]

            public void SetLength_Value6()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 6;

                // Act
                int actual = rect.SetLength(6);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // test cases for GetWidth()

            [Test]
            public void GetWidth_Value2()
            {
                // Arrange
                Rectangle rect = new Rectangle(4, 3);
                int expected = 3;

                // Act
                int actual = rect.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void GetWidth_Value7()
            {
                // Arrange
                Rectangle rect = new Rectangle(4, 7);
                int expected = 7;

                // Act
                int actual = rect.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void GetWidth_Value5()
            {
                // Arrange
                Rectangle rect = new Rectangle(4, 5);
                int expected = 5;

                // Act
                int actual = rect.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // test cases for SetLength

            [Test]

            public void SetWidth_Value1()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 1;

                // Act
                int actual = rect.SetWidth(1);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]

            public void SetWidth_Value5()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 5;

                // Act
                int actual = rect.SetWidth(5);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]

            public void SetWidth_Value9()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 9;

                // Act
                int actual = rect.SetWidth(9);

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // test cases for GetPerimeter method

            [Test]

            public void GetPerimeter_Values4and10()
            {
                // Arrange
                Rectangle rect = new Rectangle(4, 10);
                int expected = 28;

                // Act
                int actual = rect.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            [Test]

            public void GetPerimeter_Values2and8()
            {
                // Arrange
                Rectangle rect = new Rectangle(2, 8);
                int expected = 20;

                // Act
                int actual = rect.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            [Test]

            public void GetPerimeter_Values6and5()
            {
                // Arrange
                Rectangle rect = new Rectangle(6, 5);
                int expected = 22;

                // Act
                int actual = rect.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            // test cases for GetPerimeter method

            [Test]

            public void GetArea_Values4and10()
            {
                // Arrange
                Rectangle rect = new Rectangle(4, 10);
                int expected = 40;

                // Act
                int actual = rect.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            [Test]

            public void GetArea_Values2and8()
            {
                // Arrange
                Rectangle rect = new Rectangle(2, 8);
                int expected = 16;

                // Act
                int actual = rect.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);

            }
            [Test]

            public void GetArea_Values6and5()
            {
                // Arrange
                Rectangle rect = new Rectangle(6, 5);
                int expected = 30;

                // Act
                int actual = rect.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);

            }


        }

    }
}

