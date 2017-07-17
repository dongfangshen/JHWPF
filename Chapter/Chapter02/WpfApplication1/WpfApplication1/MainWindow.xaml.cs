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

namespace WpfApplication1
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

        StringBuilder sb = new StringBuilder();
        private async void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            TuLinHelper helper = new TuLinHelper();
            var result = await helper.GetText(txtQuestion.Text.ToString());
            if (!string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                sb.AppendLine();
            }
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append(result);
            txtAnswer.Text = sb.ToString();
        }
    }

}
