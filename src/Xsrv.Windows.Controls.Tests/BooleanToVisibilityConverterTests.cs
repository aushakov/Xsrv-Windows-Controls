using System.Globalization;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xsrv.Windows.Controls.Converters;

namespace Xsrv.Windows.Controls.Tests
{
    [TestClass]
    public class BooleanToVisibilityConverterTests
    {
        private BooleanToVisibilityConverter _converter;

        [TestInitialize]
        public void TestInitialized()
        {
            _converter = new BooleanToVisibilityConverter
            {
                True = Visibility.Visible,
                False = Visibility.Collapsed,
                Null = Visibility.Hidden
            };
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_Convert_Get_Visible_If_Value_True()
        {
            // Arrange

            // Act

            var result = (Visibility)_converter.Convert(true, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, Visibility.Visible);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_Convert_Get_Collapsed_If_Value_False()
        {
            // Arrange

            // Act

            var result = (Visibility)_converter.Convert(false, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, Visibility.Collapsed);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_Convert_Get_Hidden_If_Value_Null()
        {
            // Arrange

            // Act

            var result = (Visibility)_converter.Convert(null, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, Visibility.Hidden);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_ConvertBack_Get_True_If_Value_Visible()
        {
            // Arrange

            // Act

            var result = (bool)_converter.ConvertBack(Visibility.Visible, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_ConvertBack_Get_False_If_Value_Collapsed()
        {
            // Arrange

            // Act

            var result = (bool)_converter.ConvertBack(Visibility.Collapsed, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_ConvertBack_Get_False_If_Value_Hidden()
        {
            // Arrange

            // Act

            var result = (bool)_converter.ConvertBack(Visibility.Hidden, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void BooleanToVisibilityConverter_ConvertBack_Get_False_If_Value_Null()
        {
            // Arrange

            // Act

            var result = (bool)_converter.ConvertBack(null, typeof(Visibility), null, CultureInfo.CurrentCulture);

            // Assert

            Assert.AreEqual(result, false);
        }
    }
}