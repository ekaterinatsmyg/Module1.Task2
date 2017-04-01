using System;
using MentoringD1D2.Module1.Task2.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MentoringD1D2.Module1.Task2.Tests
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void NegativeIntToBoolTest()
        {
            IntToNullableBool dFrom = ConvertHelper.ToNullableBool;
            Assert.AreEqual(false, dFrom.ToBool()(-1));
        }

        [TestMethod]
        public void NegativeIntToNullableBool()
        {
            IntToBool dFrom = ConvertHelper.ToBool;
            Assert.AreEqual(null, dFrom.ToNullableBool()(-1));
        }

        [TestMethod]
        public void PositiveIntToBoolTest()
        {
            IntToNullableBool dFrom = ConvertHelper.ToNullableBool;
            Assert.AreEqual(true, dFrom.ToBool()(1));
        }

        [TestMethod]
        public void PositiveIntToNullableBool()
        {
            IntToBool dFrom = ConvertHelper.ToBool;
            Assert.AreEqual(true, dFrom.ToNullableBool()(1));
        }

        [TestMethod]
        public void ZeroIntToBoolTest()
        {
            IntToNullableBool dFrom = ConvertHelper.ToNullableBool;
            Assert.AreEqual(false, dFrom.ToBool()(0));
        }

        [TestMethod]
        public void ZeroIntToNullableBool()
        {
            IntToBool dFrom = ConvertHelper.ToBool;
            Assert.AreEqual(false, dFrom.ToNullableBool()(0));
        }
    }
}
