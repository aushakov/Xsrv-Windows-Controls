using System.Windows;
using System.Windows.Data;

namespace Xsrv.Windows.Controls.Converters
{
    /// <summary>
    /// Converts a <see cref="bool" /> to <see cref="System.Windows.Visibility"/> type. 
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityConverter : BooleanConverter<Visibility>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanToVisibilityConverter" /> class.
        /// </summary>
        public BooleanToVisibilityConverter()
            : base(Visibility.Visible, Visibility.Collapsed, Visibility.Hidden)
        {
        }
    }
}