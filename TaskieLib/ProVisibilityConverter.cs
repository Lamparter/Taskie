using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace TaskieLib {
    public class ProVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            Debug.WriteLine("ProVisibilityConverter: " + ((bool)value).ToString());
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return null;
        }
    }
}