using ClockDegreeCalculator;
using ClockDegreeCalculator.Exceptions;
using FluentAssertions;

namespace ClockDegreeCalculatorTest
{
    [TestClass]
    public class ClockDegreeCalculatorTest
    {
        private IAngleCalculator _angleCalculator;
        private double angle;

        [TestInitialize]
        public void SetUp()
        {
            _angleCalculator = new AngleCalculator();
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours3AndMinutes15_ShouldReturn7Point5()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(3, 15);

            //Assert
            angle.Should().Be(7.5);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours9AndMinutes20_ShouldReturn160()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(9, 20);

            //Assert
            angle.Should().Be(160);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours10AndMinutes60_ShouldReturn60()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(10, 60);

            //Assert
            angle.Should().Be(60);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours10AndMinutes0_ShouldReturn60()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(10, 0);

            //Assert
            angle.Should().Be(60);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours12AndMinutes15_ShouldReturn82Point5()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(12, 15);

            //Assert
            angle.Should().Be(82.5);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_Hours0AndMinutes15_ShouldReturn82Point5()
        {
            //Act
            angle = _angleCalculator.GetAngleCalculator(0, 15);

            //Assert
            angle.Should().Be(82.5);
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_IvalidMinutes_ThrowInvalidMinutesException()
        {
            //Act
            Action act = () => _angleCalculator.GetAngleCalculator(12, 61);
            act.Should().Throw<InvalidMinutesException>().WithMessage("The specified value 61 in minutes does not match for the clock dial");
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_InvalidHours_ThrowInvalidHoursException()
        {
            //Act
            Action act = () => _angleCalculator.GetAngleCalculator(13, 15);
            act.Should().Throw<InvalidHoursException>().WithMessage("The specified value 13 in hours does not match for the clock dial");
        }

        [TestMethod]
        public void ClockDegreeCalculatorTest_IvalidNegativeMinutes_ThrowInvalidMinutesException()
        {
            //Act
            Action act = () => _angleCalculator.GetAngleCalculator(12, -15);
            act.Should().Throw<InvalidMinutesException>().WithMessage("The specified value -15 in minutes does not match for the clock dial");
        }
    }
}