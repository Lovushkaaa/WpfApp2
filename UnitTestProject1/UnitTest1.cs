using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //summ1
        [TestMethod]
        public void TestMethodSumma14and14res28()
        {

            //arrange
            double num1 = 14;
            double num2 = 14;
            double ex = 28;

            //act
            double res = num1 + num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //summ2
        [TestMethod]
        public void TestMethodSumma35and38res73()
        {

            //arrange
            double num1 = 35;
            double num2 = 38;
            double ex = 73;

            //act
            double res = num1 + num2;
            //assert
            Assert.AreEqual(ex, res);
        }
        //summ3
        [TestMethod]
        public void TestMethodSumma56and68res124()
        {

            //arrange
            double num1 = 56;
            double num2 = 68;
            double ex = 124;

            //act
            double res = num1 + num2;
            //assert
            Assert.AreEqual(ex, res);
        }
        //sub1
        [TestMethod]
        public void TestMethodSubtraction45and14res31()
        {

            //arrange
            double num1 = 45;
            double num2 = 14;
            double ex = 31;

            //act
            double res = num1 - num2;
            //assert
            Assert.AreEqual(ex, res);
        }
        //sub2
        [TestMethod]
        public void TestMethodSubtraction83and46res37()
        {

            //arrange
            double num1 = 83;
            double num2 = 46;
            double ex = 37;

            //act
            double res = num1 - num2;
            //assert
            Assert.AreEqual(ex, res);
        }
        //sub3
        [TestMethod]
        public void TestMethodSubtraction94and94res0()
        {

            //arrange
            double num1 = 94;
            double num2 = 94;
            double ex = 0;

            //act
            double res = num1 - num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //mult1
        [TestMethod]
        public void TestMethodMultiplication15and3res45()
        {

            //arrange
            double num1 = 15;
            double num2 = 3;
            double ex = 45;

            //act
            double res = num1 * num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //mult2
        [TestMethod]
        public void TestMethodMultiplication44and20res880()
        {

            //arrange
            double num1 = 44;
            double num2 = 20;
            double ex = 880;

            //act
            double res = num1 * num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //mult3
        [TestMethod]
        public void TestMethodMultiplication33and3res99()
        {

            //arrange
            double num1 = 33;
            double num2 = 3;
            double ex = 99;

            //act
            double res = num1 * num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //div1
        [TestMethod]
        public void TestMethodDivision30and3res10()
        {

            //arrange
            double num1 = 30;
            double num2 = 3;
            double ex = 10;

            //act
            double res = num1 / num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //div2
        [TestMethod]
        public void TestMethodDivision369and3res123()
        {

            //arrange
            double num1 = 369;
            double num2 = 3;
            double ex = 123;

            //act
            double res = num1 / num2;
            //assert
            Assert.AreEqual(ex, res);
        }
        //div3
        [TestMethod]
        public void TestMethodDivision10and2res5()
        {

            //arrange
            double num1 = 10;
            double num2 = 2;
            double ex = 5;

            //act
            double res = num1 / num2;
            //assert
            Assert.AreEqual(ex, res);
        }

        //per1
        [TestMethod]
        public void TestMethodPercent163res1б3()
        {

            //arrange
            double num1 = 163;
            double ex = 1.63;

            //act
            double res = num1 / 100;
            //assert
            Assert.AreEqual(ex, res);
        }

        //per2
        [TestMethod]
        public void TestMethodPercent94res94()
        {

            //arrange
            double num1 = 94;
            double ex = 0.94;

            //act
            double res = num1 / 100;
            //assert
            Assert.AreEqual(ex, res);
        }

        //per3
        [TestMethod]
        public void TestMethodPercent47res47()
        {

            //arrange
            double num1 = 47;
            double ex = 0.47;

            //act
            double res = num1 / 100;
            //assert
            Assert.AreEqual(ex, res);
        }

        //denial1
        [TestMethod]
        public void TestMethodDenial34res34()
        {

            //arrange
            double num1 = 34;
            double ex = -34;

            //act
            double res = num1 * -1;
            //assert
            Assert.AreEqual(ex, res);
        }


        //denial2
        [TestMethod]
        public void TestMethodDenial47res47()
        {

            //arrange
            double num1 = 47;
            double ex = -47;

            //act
            double res = num1 * -1;
            //assert
            Assert.AreEqual(ex, res);
        }

        //denial3
        [TestMethod]
        public void TestMethodDenial100res100()
        {

            //arrange
            double num1 = 100;
            double ex = -100;

            //act
            double res = num1 * -1;
            //assert
            Assert.AreEqual(ex, res);
        }
    }
}
