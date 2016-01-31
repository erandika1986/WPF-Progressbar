using System.Collections.ObjectModel;

namespace ProgressBarSample.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public MainViewModel()
        {
            Contents = new ObservableCollection<ContentViewModel>();
            var formOne = new FormOneViewModel();
            Contents.Add(formOne);
            formOne.TotalPercentageChanged += TotalPercentageChanged;

            progressBarViewModel = new ProgressBarViewModel();
        }

        private void TotalPercentageChanged(float value)
        {
            progressBarViewModel.UpdatePrecentage(value);
        }

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

        private ProgressBarViewModel progressBarViewModel;
        public ProgressBarViewModel ProgressBarViewModel
        {
            get { return progressBarViewModel; }
            set
            {
                progressBarViewModel = value;
                RaisedPropertyChanged("ProgressBarViewModel");
            }
        }


    }
}
