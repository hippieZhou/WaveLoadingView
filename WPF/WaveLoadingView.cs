using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WaveLoadingViewDemo
{
    [Flags]
    public enum Shape
    {
        Cirlce = 0x01,
        Square = 0x02
    };

    #region Converters

    public class ShapeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var shape = (Shape)value;
            return shape == Shape.Cirlce ? 50 : 90;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var num = int.Parse(value.ToString());
            return num == 50 ? Shape.Cirlce : Shape.Square;
        }
    }
    public class BorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var shape = (Shape)value;
            return shape == Shape.Cirlce ? 50 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var num = int.Parse(value.ToString());
            return num == 50 ? Shape.Cirlce : Shape.Square;
        }
    }

    #endregion



    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:WaveLoadingViewDemo"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:WaveLoadingViewDemo;assembly=WaveLoadingViewDemo"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:WaveLoadingView/>
    ///
    /// </summary>
    public class WaveLoadingView : Control
    {
        static WaveLoadingView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WaveLoadingView), new FrameworkPropertyMetadata(typeof(WaveLoadingView)));
        }

        public Shape ShapeType
        {
            get { return (Shape)GetValue(ShapeTypeProperty); }
            set { SetValue(ShapeTypeProperty, value); }
        }


        // Using a DependencyProperty as the backing store for ShapeType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShapeTypeProperty =
            DependencyProperty.Register("ShapeType", typeof(Shape), typeof(WaveLoadingView), new PropertyMetadata(Shape.Cirlce, (d, e) =>
             {
                 var handler = d as WaveLoadingView;
                 if (handler != null)
                 {
                 }
             }));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(WaveLoadingView), new PropertyMetadata(string.Empty, (d, e) => 
            {
                var handler = d as WaveLoadingView;
                handler?.SetValue(TitleProperty, e.NewValue.ToString());
            }));


        public VerticalAlignment TitleAlignment
        {
            get { return (VerticalAlignment)GetValue(TitleAlignmentProperty); }
            set { SetValue(TitleAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleAlignment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleAlignmentProperty =
            DependencyProperty.Register("TitleAlignment", typeof(VerticalAlignment), typeof(WaveLoadingView), new PropertyMetadata(VerticalAlignment.Center,(d,e)=> 
            {
                var handler = d as WaveLoadingView;
                handler?.SetValue(TitleAlignmentProperty, (VerticalAlignment)e.NewValue);
            }));


        public Brush TitleForeground
        {
            get { return (Brush)GetValue(TitleForegroundProperty); }
            set { SetValue(TitleForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleForegroundProperty =
            DependencyProperty.Register("TitleForeground", typeof(Brush), typeof(WaveLoadingView), new PropertyMetadata(new SolidColorBrush(Colors.White), (d, e) =>
             {
                 var handler = d as WaveLoadingView;
                 handler?.SetValue(TitleForegroundProperty, (Brush)e.NewValue);
             }));
    }
}
