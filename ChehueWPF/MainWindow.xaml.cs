using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChehueWPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }

    //public class LockableToggleButton : ListBoxItem
    //{
    //    protected override void OnToggle()
    //    {
    //        if (!LockToggle)
    //        {
    //            base.OnToggle();
    //        }
    //    }

    //    public bool LockToggle
    //    {
    //        get { return (bool)GetValue(LockToggleProperty); }
    //        set { SetValue(LockToggleProperty, value); }
    //    }

    //    // Using a DependencyProperty as the backing store for LockToggle.  This enables animation, styling, binding, etc...
    //    public static readonly DependencyProperty LockToggleProperty =
    //        DependencyProperty.Register("LockToggle", typeof(bool), typeof(LockableToggleButton), new UIPropertyMetadata(false));
    //}
}
