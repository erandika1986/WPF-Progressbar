using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarSample.ViewModels
{
    public class ProgressBarViewModel:BaseViewModel
    {
        public ProgressBarViewModel()
        {
            progress = 0.0f;
            RaisedPropertyChanged("Progress");
        }

        public void UpdatePrecentage(float precentage)
        {
            progress = precentage;
            RaisedPropertyChanged("Progress");
        }

        private float progress;
        public float Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                RaisedPropertyChanged("Progress");
            }
        }

    }
}
