using ProgressBarSample.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarSample.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public ObservableCollection<ContentViewModel> Contents { get; set; }

        private ContentViewModel selectedContent;

        public ContentViewModel SelectedContent
        {
            get { return selectedContent; }
            set
            {
                selectedContent = value;
                RaisedPropertyChanged("SelectedContent");
            }
        }

    }
}
