using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfStyles
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            //1.得到Button对象
            Button btn =(Button) e.OriginalSource;
            //2.得到窗口类型
            Type type = this.GetType();
            //3.得到窗口程序集
            Assembly assembly = type.Assembly;
            //4.得用反射创建窗口对象
            Window win = (Window)assembly.CreateInstance(type.Namespace + "." + btn.Content);
            win.ShowDialog();

        }
    }
}
