using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarSample.Common
{
    public class InputChangedEventArgs
    {
        public int Id { get; set; }
        public InputType InputType { get; set; }
        public string Value { get; set; }
        public float Weightage { get; set; }
    }
}
