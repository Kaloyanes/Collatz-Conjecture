using System.Windows.Media;
using System.Windows.Media.Animation;
using LiveCharts;
using LiveCharts.Wpf;

namespace Collatz_Conjecture
{
    public partial class Main : Form
    {
        private Int64 n;
        private Int64[] errorInts = new Int64[] { 0, 1, 2, 4 };
        private int steps;
        private Axis axisX;
        private Axis axisY;

        public Main()
        {
            InitializeComponent();
            CCChart.Series = new SeriesCollection();
            CCChart.Series.Add(new LineSeries()
            {
                Values = new ChartValues<Int64>(),
                PointGeometrySize = 15,
                LineSmoothness = 0.5,
                DataLabels = false
            });

            axisX = new Axis()
            {
                Title = "Steps",
                Labels = new List<string>(),
            };

            CCChart.AxisX.Add(axisX);

            lblLimit.Text += Int64.MaxValue;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Resetting the values
            n = Int64.Parse(txtN.Text);
            steps = 0;

            if (errorInts.Contains(n))
            {
                MessageBox.Show($"It can't be {n}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCChart.Series[0].Values.Clear();
            CCChart.AxisX[0].Labels.Clear();
            CCChart.Series[0].Values.Add(n);
            CCChart.AxisX[0].Labels.Add($"Step: {steps}");

            // Doing the Collatz Conjecture
            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = n * 3 + 1;

                steps++;

                CCChart.Series[0].Values.Add(n);
                CCChart.AxisX[0].Labels.Add($"Step: {steps}");
            }
        }
    }
}