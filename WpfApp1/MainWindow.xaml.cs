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
            myTextBlock.Text = "Hello from the CS side";
            myTextBlock.Foreground = Brushes.Blue;
            /*
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
            */
            calenderText.Text = myCalender.SelectedDate.ToString();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"http://www.github.com/kttra", UseShellExecute = true });
            //System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            testLabel.Foreground = Brushes.Gold;
            testLabel.FontSize += 1;
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Need this check so that slider can be initialized into the UI
            if(sliderTextblock != null)
            {
                sliderTextblock.Text = "Slider value: " + mySlider.Value.ToString();
            }
        }

        private void myCalender_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if(calenderText != null)
                calenderText.Text = myCalender.SelectedDate.ToString();
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedDate = ((DatePicker)sender).SelectedDate.ToString();
            //Do something with selectedDate
        }
        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            myExpander.Header = "";
        }
        private void myExpander_Collapsed(object sender, RoutedEventArgs e)
        {
            myExpander.Header = "Click me to expand";
        }
    }
}
