using ProgressBarSample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarSample.ViewModels
{
    public class TextBoxViewModel:BaseViewModel
    {
        public event Action<System.EventArgs> ValueChanged;

        public TextBoxViewModel(int textBoxId,float weightage)
        {
            this.weightage = weightage;
            this.textBoxId = textBoxId;
            this.inputType = InputType.TextBox;
        }

        private int textBoxId;
        public int TextBoxId
        {
            get { return textBoxId; }
            set
            {
                textBoxId = value;
                RaisedPropertyChanged("TextBoxId");
            }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                RaisedPropertyChanged("Text");
                Update();
            }
        }

        private float weightage;
        public float Weightage
        {
            get { return weightage; }
            set
            {
                weightage = value;
                RaisedPropertyChanged("Weightage");
            }
        }

        private InputType inputType;
        public InputType InputType
        {
            get { return inputType; }
            set { inputType = value; }
        }


        private void Update()
        {
            if (ValueChanged != null)
            {
                var eventArgs = new InputChangedEventArgs()
                {
                    Id = textBoxId,
                    InputType = inputType,
                    Value = text,
                    Weightage = weightage
                };

                ValueChanged(eventArgs);
            }
        }
    }
}
