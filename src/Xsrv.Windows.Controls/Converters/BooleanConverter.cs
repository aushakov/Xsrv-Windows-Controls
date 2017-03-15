using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace Xsrv.Windows.Controls.Converters
{
    /// <summary>
    /// Base class for boolean converters.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    public abstract class BooleanConverter<T> : IValueConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanConverter{T}"/> class.
        /// </summary>
        /// <param name="true">A value that is associated with <c>true</c>.</param>
        /// <param name="false">A value that is associated with <c>false</c>.</param>
        /// <param name="null">A value that is associated with <c>null</c>.</param>
        protected BooleanConverter(T @true, T @false, T @null)
        {
            True = @true;
            False = @false;
            Null = @null;
        }

        /// <summary>
        /// Gets or sets a value that is associated with <c>true</c>.
        /// </summary>
        public T True { get; set; }

        /// <summary>
        /// Gets or sets a value that is associated with <c>false</c>.
        /// </summary>
        public T False { get; set; }

        /// <summary>
        /// Gets or sets a value that is associated with <c>null</c>.
        /// </summary>
        public T Null { get; set; }

        /// <summary>
        /// Converts a <see cref="Boolean"/> value to <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A converted value.</returns>
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Null;

            return value is bool && (bool)value ? True : False;
        }

        /// <summary>
        /// Converts a <see cref="T"/> value to <see cref="Boolean"/>.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A converted value.</returns>
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T && EqualityComparer<T>.Default.Equals((T)value, True);
        }
    }
}