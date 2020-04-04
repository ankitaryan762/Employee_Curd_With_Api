using NUnit.Framework;
using QualityMeasurement;

namespace NUnit_QualityMeasurement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_0_Feet_WhenAnalyze_Should_Return_Equal()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 10);
            Feet feet = new Feet(10);
            double expected = feet.CheckForEqualValue();
            double actual = lengthConversion.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerForm_TestCase_Null_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Ref_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(lengthConversion);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Type_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(new LengthConversion());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Value_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 10);
            Feet feet = new Feet(10);
            double actual = lengthConversion.CheckForEqualValue();
            double expected = feet.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Give_0_Inch_Return_Equal()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch", 55);
            Inch inch = new Inch(55);
            double expected = inch.CheckForEqualValue();
            double actual = lengthConversion.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerForm_Test_For_Inch_Null_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch", 0);
            bool result = lengthConversion.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Ref_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch");
            bool result = lengthConversion.Equals(lengthConversion);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_10_For_Equality_Type_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch");
            bool result = lengthConversion.Equals(new LengthConversion());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_11_For_Equality_Ref_Check()
        {
            Inch inch = new Inch(15);
            double expected = inch.CheckForEqualValue();
            LengthConversion lengthConversion = new LengthConversion("Inch", 15);
            double result = lengthConversion.CheckForEqualValue();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Give_0_Feet_and_0_Inch_Should_Return_Equal()
        {
            Feet feet = new Feet(0);
            double expected = feet.CheckForEqualValue();
            Inch inch = new Inch(0);
            double actual = inch.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1ft_Not_Equal_to_1inch_return_False()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 1);
            Feet feet = new Feet(1);
            double expected = feet.CheckForEqualValue();
            double actual = lengthConversion.ConvertFeetToInch();
            Assert.AreNotEqual(expected, actual);
        }

    }
}