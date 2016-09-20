using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cosmetics.Common;
using Ploeh.AutoFixture;

namespace Cosmetics.Tests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void CheckIfNull_PassNullAsObjParameter_ShouldThrowNullReferenceExcepetion()
        {
            Assert.ThrowsException<NullReferenceException>(() => Validator.CheckIfNull(null));
        }

        [TestMethod]
        public void CkeckIfNull_PassNotNullAsObjParameter_ShouldNotThrowException()
        {
            var fixture = new Fixture();
            var obj = fixture.Create<Object>();

            Validator.CheckIfNull(obj);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void CheckIfStringIsNullOrEmpty_PassNullOrEmptyStringAsTextParameter_ShouldThrowNullReferenceExcepetion(string str)
        {
            Assert.ThrowsException<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(null));
        }

        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_PassNotNullOrEmptyStringAsTextParameter_ShouldNotThrowException()
        {
            var fixture = new Fixture();
            var str = fixture.Create<string>();

            Validator.CheckIfNull(str);
        }

        [TestMethod]
        [DataRow(0,10,0)]
        [DataRow(0,10,10)]
        [DataRow(0,10,5)]
        public void CheckIfStringLengthIsValid_PassStringWithAllowedLengthAsTextParameter_ShouldNotThrowException(int min, int max,int stringLength)
        {
            var str = new string('a', stringLength);

            Validator.CheckIfStringLengthIsValid(str, max, min);
        }
    }
}
