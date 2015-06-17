﻿using System;
using System.Globalization;

namespace SiliconStudio.Presentation.ValueConverters
{
    public class MatchType : OneWayValueConverter<MatchType>
    {
        /// <inheritdoc/>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
                return false;

            return ((Type)parameter).IsInstanceOfType(value);
        }
    }
}