using System.Windows.Media;
using System.Windows.Media.Animation;
using LiveCharts;
using LiveCharts.Wpf;
using Color = System.Drawing.Color;

namespace Collatz_Conjecture
{
    public partial class Main : Form
    {
        private long n;
        private long[] errorInts = new long[] { 0, 1, 2, 4 };
        private int steps;
        private Axis axisX;
        private Axis axisY;
        private List<long> numbers = new List<long>();

        public Main()
        {
            InitializeComponent();
            CCChart.Zoom = ZoomingOptions.Y;
            CCChart.Series = new SeriesCollection();

            axisX = new Axis()
            {
                Title = "Steps",
                Labels = new List<string>(),
            };

            CCChart.AxisX.Add(axisX);

            lblLimit.Text += long.MaxValue;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Resetting the values
            n = long.Parse(txtN.Text);
            long nCopy = n;
            steps = 0;

            if (numbers.Contains(n))
            {
                MessageBox.Show("Can't repeat numbers", "Repeated number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numbers.Add(n);

            CCChart.Series.Add(new LineSeries()
            {
                Title = $"#{n}",
                Values = new ChartValues<long>(),
                PointGeometrySize = 15,
                LineSmoothness = 0
            });

            int series = CCChart.Series.Count - 1;

            CCChart.Series[series].Values.Clear();
            CCChart.AxisX[0].Labels.Clear();
            CCChart.Series[series].Values.Add(n);
            CCChart.AxisX[0].Labels.Add($"Step: {steps}");

            // Doing the Collatz Conjecture
            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = n * 3 + 1;

                steps++;

                CCChart.Series[series].Values.Add(n);
                CCChart.AxisX[0].Labels.Add($"Step: {steps}");
            }

            string max = $"Max: {CCChart.Series[series].Values.Cast<long>().Max()}";
            string stepsMsg = $"Steps: {steps}";
            cmboxNumbers.Items.Add($"#{nCopy} | {max} {stepsMsg}");
            cmboxNumbers.SelectedIndex = series;
            txtN.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var chart in CCChart.Series)
            {
                chart.Values.Clear();
            }
            cmboxNumbers.Items.Clear();
            cmboxNumbers.Text = "";
            numbers.Clear();
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            CCChart.BackColor = Color.Black;
            CCChart.ForeColor = Color.White;
            ActiveForm.BackColor = Color.Black;
            ActiveForm.ForeColor = Color.White;
            btnLight.Show();
            btnDark.Hide();
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            CCChart.BackColor = Color.White;
            CCChart.ForeColor = Color.Black;
            ActiveForm.BackColor = Color.White;
            ActiveForm.ForeColor = Color.Black;
            btnLight.Hide();
            btnDark.Show();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int n2 = int.Parse(txtN.Text);
            for (int i = n2; i > 0; i--)
            {
                long n = long.Parse(i.ToString());
                long nCopy = n;
                steps = 0;

                if (numbers.Contains(n))
                {
                    MessageBox.Show("Can't repeat numbers", "Repeated number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                numbers.Add(n);

                CCChart.Series.Add(new LineSeries()
                {
                    Title = $"#{n}",
                    Values = new ChartValues<long>(),
                    PointGeometrySize = 15,
                    LineSmoothness = 0
                });

                int series = CCChart.Series.Count - 1;

                CCChart.Series[series].Values.Clear();
                CCChart.AxisX[0].Labels.Clear();
                CCChart.Series[series].Values.Add(n);
                CCChart.AxisX[0].Labels.Add($"Step: {steps}");

                // Doing the Collatz Conjecture
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = n * 3 + 1;

                    steps++;

                    CCChart.Series[series].Values.Add(n);
                    CCChart.AxisX[0].Labels.Add($"Step: {steps}");
                }

                string max = $"Max: {CCChart.Series[series].Values.Cast<long>().Max()}";
                string stepsMsg = $"Steps: {steps}";
                cmboxNumbers.Items.Add($"#{nCopy} | {max} {stepsMsg}");
                cmboxNumbers.SelectedIndex = series;
            }
            txtN.Text = "";
        }
    }
}