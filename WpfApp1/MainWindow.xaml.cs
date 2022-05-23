using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myButton.FontSize = 15;
            myButton.Content = "Hi there";
            myTextBox.Text = "Hello from the CS side";
            myTextBox.Foreground = Brushes.Blue;

            TextBlock myTb = new TextBlock();
            myTb.Text = "Text Created in CS file";
            myTb.Inlines.Add("\nAdded using inlines method ");
            myTb.Inlines.Add(new Run("Text added in the code.")
            {
                Foreground = Brushes.Blue,
                TextDecorations = TextDecorations.Underline,
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BlueViolet;
            this.Content = myTb; //Make this the content of the current window
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"http://www.github.com/kttra", UseShellExecute = true });
            //System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
