using ProgressBarSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarSample
{
    public class MainWindowViewModel:BaseViewModel
    {
        public MainWindowViewModel()
        {
            contentViewModel = new MainViewModel();
        }

        private BaseViewModel contentViewModel;
        public BaseViewModel ContentViewModel
        {
            get { return contentViewModel; }
            set
            {
                contentViewModel = value;
                RaisedPropertyChanged("ContentViewModel");
            }
        }

    }
}
