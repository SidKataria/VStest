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

namespace realestatefinder
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static readonly DependencyProperty MinProperty = DependencyProperty.Register("Min", typeof(double), typeof(MainPage), new PropertyMetadata(0d));
        public static readonly DependencyProperty MaxProperty = DependencyProperty.Register("Max", typeof(double), typeof(MainPage), new PropertyMetadata(100d));
        public static readonly DependencyProperty StartProperty = DependencyProperty.Register("Start", typeof(double), typeof(MainPage), new PropertyMetadata(20d));
        public static readonly DependencyProperty EndProperty = DependencyProperty.Register("End", typeof(double), typeof(MainPage), new PropertyMetadata(85d));
        public MainPage()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            FilterButton btn = sender as FilterButton;
            btn.Handle_FilterButton_Click();
        }

        public double Max
        {
            get => (double)GetValue(MaxProperty);
            set => SetValue(MaxProperty, value);
        }

        public double Min
        {
            get => (double)GetValue(MinProperty);
            set => SetValue(MinProperty, value);
        }

        public double Start
        {
            get => (double)GetValue(StartProperty);
            set => SetValue(StartProperty, value);
        }

        public double End
        {
            get => (double)GetValue(EndProperty);
            set => SetValue(EndProperty, value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
