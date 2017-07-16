using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Commands;

namespace WpfApp2.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private double input1;

        public double Input1
        {
            get { return input1; }
            set
            {
                input1 = value;
                this.RaisePropertyChanged("Input1");
            }
        }

        private double input2;

        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        private double result;

        public double Reuslt
        {
            get { return result; }
            set
            {
                result = value;
                this.RaisePropertyChanged("Reuslt");
            }
        }

        public DelegateCommand AddCommand { get; set; }

        private void Add(object parameter)
        {
            this.Reuslt = this.Input1 + this.Input2;
        }

        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(this.Add);
        }
    }
}
