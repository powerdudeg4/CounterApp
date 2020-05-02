using System.Windows;

namespace CounterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        [System.Windows.Localizability(System.Windows.LocalizationCategory.Text)]
        public string Text { get; set; }
    
        /// <summary>
        /// This is a part that does the actual hard dwork
        /// </summary>
        public int num = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            num++;
            Number.Text = num.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            num--;
            Number.Text = num.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }
    }

}
