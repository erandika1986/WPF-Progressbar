namespace ProgressBarSample.ViewModels
{
    public class ContentViewModel:BaseViewModel
    {
        public ContentViewModel(string header)
        {
            Header = header;
        }

        public string Header { get; set; }
    }
}
