﻿using System;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class MathTests
    {
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        public double FindNthRootTest(double num, int pow, double accuracy)
        {
            return Math.FindNthRoot(num, pow, accuracy);
        }

        [TestCase]
        public void FindNthRoot_ThrowArgumentException_WrongPow()
        {
            var result = Assert.Throws<ArgumentException>(() => Math.FindNthRoot(8, -1, 0.0001));
        }
    }
}