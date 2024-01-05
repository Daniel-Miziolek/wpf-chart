using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GrapeCity.DataVisualization.Chart;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;

namespace WPF_Charts
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

        private void gotfocus2(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "";
            
        }

        private void lostfocus2(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Value 2>>";
            }
            else
            {

            }
        }

        

        private void lostfocus1(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Value 1>>";
            }
            else
            {

            }
        }

        private void gotfocu1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                int value = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                var plotModel = new PlotModel { Title = "chart:" };

                var series = new PieSeries();
                series.Slices.Add(new PieSlice("Wartość 1", value) { IsExploded = true });
                series.Slices.Add(new PieSlice("Wartość 2", value2));
                

                plotModel.Series.Add(series);

                plot.Model = plotModel;
            }
            else if (radioButton2.IsChecked == true)
            {
                int value = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                var plotModel = new PlotModel { Title = "chart:" };

                var series = new LineSeries();
                series.Points.Add(new DataPoint(0, value));
                series.Points.Add(new DataPoint(1, value2));
                

                plotModel.Series.Add(series);

                plot.Model = plotModel;
            }
            else if (radioButton3.IsChecked == true)
            {
                int value = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                var plotModel = new PlotModel { Title = "chart:" };

                var series = new BarSeries();
                series.Items.Add(new BarItem { Value = value });
                series.Items.Add(new BarItem { Value = value2 });
                

                plotModel.Series.Add(series);

                plot.Model = plotModel;
            }
            else
            {
                MessageBox.Show("Błąd spróbuj jeszcze raz");
            }
        }
    }
}