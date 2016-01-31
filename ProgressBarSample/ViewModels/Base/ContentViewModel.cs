using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
