﻿using System;

namespace ExercisesTests
{
    [TestFixture]
    public class GeneratingNewCollection_Exercise2_Tests
    {
        [Test]
        public void FiveLevels()
        {
            var result = GeneratingNewCollection.BuildTree(5);
            var expectedResult = "*\n**\n***\n****\n*****\n";

            Assert.AreEqual(expectedResult, result, "Invalid tree for levels count 5");
        }

        [Test]
        public void ZeroLevels()
        {
            var result = GeneratingNewCollection.BuildTree(0);
            var expectedResult = @"";

            Assert.AreEqual(expectedResult, result, "For levels count 0 the result shall be an empty string");
        }
    }
}
