using LABA9MAIN;
namespace TestDC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int expected = 0;
            //Act
            int actual = DialClock.GetCount;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            DialClock expected = new DialClock(0, 0);
            //Act
            DialClock actual = new DialClock();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            DialClock expected = new DialClock(23, 59);
            //Act
            DialClock actual = new DialClock(22, 119);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            DialClock expected = new DialClock(23, 59);
            //Act
            DialClock actual = new DialClock(expected);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            DialClock expected = new DialClock(0, 0);
            //Act
            DialClock actual = new DialClock(-1,-1);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            double expected = 82.5;
            //Act
            DialClock dc6 = new DialClock(12, 15);
            double actual = dc6.AngleBetweenHnM();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            double expected = 82.5;
            //Act
            DialClock dc7 = new DialClock(12, 15);
            double actual = DialClock.AngleBetweenHnMStat(dc7);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            double expected = 0;
            //Act
            DialClock dc8 = new DialClock(0, 0);
            double actual = dc8.AngleBetweenHnM();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            double expected = 0;
            //Act
            DialClock dc9 = new DialClock(0, 0);
            double actual = DialClock.AngleBetweenHnMStat(dc9);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            DialClock expected = new DialClock(0, 1);
            //Act
            DialClock actual = new DialClock(0, 0);
            actual++;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            DialClock expected = new DialClock(23, 58);
            //Act
            DialClock actual = new DialClock(23, 59);
            actual--;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            DialClock expected = new DialClock(22, 59);
            //Act
            DialClock actual = new DialClock(23, 0);
            actual--;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            DialClock expected = new DialClock(23, 59);
            //Act
            DialClock actual = new DialClock(0, 0);
            actual--;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            DialClock expected = new DialClock(0, 1);
            //Act
            DialClock actual = new DialClock(0, 0);
            actual = actual + 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            DialClock expected = new DialClock(0, 1);
            //Act
            DialClock actual = new DialClock(0, 0);
            actual = 1 + actual;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            DialClock expected = new DialClock(0, 0);
            //Act
            DialClock actual = new DialClock(0, 0);
            actual = actual - 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod17()
        {
            //Arrange
            DialClock expected = new DialClock(0, 0);
            //Act
            DialClock actual = new DialClock(0, 1);
            actual = actual - 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod18()
        {
            //Arrange
            DialClock expected = new DialClock(3, 0);
            //Act
            DialClock actual = new DialClock(1, 30);
            actual = 270 - actual;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod19()
        {
            //Arrange
            DialClock expected = new DialClock(0, 0);
            //Act
            DialClock actual = new DialClock(1, 30);
            actual = -270 - actual;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod20()
        {
            //Arrange
            DialClock expected = new DialClock(4, 30);
            //Act
            DialClock actual = new DialClock(5, 30);
            actual = 270 - actual;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod21()
        {
            //Arrange
            bool expected = true;
            //Act
            DialClock dc21 = new DialClock(4, 25);
            bool actual = (bool)dc21;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod22()
        {
            //Arrange
            int expected = 330;
            //Act
            DialClock dc22 = new DialClock(5, 30);
            int actual = dc22;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod23()
        {
            //Arrange
            int expected = 0;
            //Act
            int actual = DialClockArray.GetCount;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod24()
        {
            //Arrange
            int expected = 4;
            //Act
            DialClockArray dca24 = new DialClockArray(4, 23, 59);
            int actual = dca24.Length;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod25()
        {
            //Arrange
            DialClockArray expected = new DialClockArray();
            //Act
            DialClockArray actual = new DialClockArray(expected);
            //Assert
            Assert.IsTrue(expected.IsEqual(actual));
        }
        [TestMethod]
        public void TestMethod26()
        {
            //Arrange
            DialClockArray dca26 = new DialClockArray();
            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => new DialClock(dca26[100]));
        }
        [TestMethod]
        public void TestMethod27()
        {
            //Arrange
            DialClockArray dca27 = new DialClockArray();
            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => dca27[100] = new DialClock());
        }
    }
}