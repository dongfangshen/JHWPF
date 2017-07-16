using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using WpfApp2.ViewModels;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        [DllImport(@"TestDll.dll", EntryPoint = "fnTestDll")]
        extern static int fnTestDll(int a, int b);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int c = fnTestDll(1, 2);
            MessageBox.Show(string.Format("{0}", c));
        }

        [DllImport(@"TestDll.dll", EntryPoint = "pTest")]
        extern static IntPtr pTest();

        [DllImport(@"TestDll.dll", EntryPoint="AddNew")]
        extern static int AddNew(IntPtr pTest, int a, int b);
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           IntPtr pPtr =  pTest();
            int c = AddNew(pPtr, 1, 2);
            MessageBox.Show(string.Format("{0}", c));
        }
    }
}
