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
            var plotModel = new PlotModel { Title = "Char - Daniel Miziołek" };

            var series = new PieSeries();
            series.Slices.Add(new PieSlice("Wartość 1", 30) { IsExploded = true });
            series.Slices.Add(new PieSlice("Wartość 2", 20));
            series.Slices.Add(new PieSlice("Wartość 3", 50));

            plotModel.Series.Add(series);

            plot.Model = plotModel;
        }
    }
}