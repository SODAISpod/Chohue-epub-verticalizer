using ChoHoeBV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
        Book theBook = new Book();
        List<Book> books = new List<Book>();
        List<test> tests= new List<test>();

        public MainWindow()
        {
            InitializeComponent();
            test fd= new test();
            tests.Add(fd);
            test qw2= new test();
            tests.Add(qw2);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        class test
        {
            string ff = "11";
            string ff2 = "22";
        }
    }
}
