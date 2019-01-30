using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hand_testing_Calculator;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private Program.Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Program.Calculator();
        }

        [Test]
        public void Calc_2_minus_2()
        {
            Assert.That(_calc.Subtract(2,2), Is.EqualTo(0));
        }

        [Test]
        public void Calc_minus2_minus_6()
        {
            Assert.That(_calc.Subtract(-2,6),Is.EqualTo(-8));
        }

        [Test]
        public void Calc_minus2_plus_6()
        {
            Assert.That(_calc.Add(-2,6), Is.EqualTo(4));
        }
        [Test]
        public void Calc_4_times_5()
        {
            Assert.That(_calc.Multiply(4,5),Is.EqualTo(20));
        }
        [Test]
        public void Calc_pow_2()
        {
            Assert.That(_calc.Power(2,2),Is.EqualTo(4));
        }

    }
}
