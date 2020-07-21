using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    class Class1
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _text;

        public bool IsDone {
            get { return _isDone; }
            set {
                if (_isDone ==value)
                    return;

                _isDone = value;

                onPropertyChanged("IsDone");

            }
        }

        public string Text
        {
            get { return _text; }
            set {

                if (_text == value)
                    return;
                
                _text = value;
                onPropertyChanged("Text");
            
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void onPropertyChanged(string propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
