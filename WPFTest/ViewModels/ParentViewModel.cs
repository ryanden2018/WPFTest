using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFTest.ViewModels
{
    public class ParentViewModel : INotifyPropertyChanged
    {
        private string _text = "None";
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                NotifyPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ParentViewModel() { }

        public void DoTheStuff()
        {
            Text = "This is the parent text.";
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
