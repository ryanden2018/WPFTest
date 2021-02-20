using System.Windows;

namespace WPFTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parent.ParentView.ParentViewModel.DoTheStuff();
            Parent.ParentView.Child.ChildView.ChildViewModel.DoTheStuff();
        }
    }
}
