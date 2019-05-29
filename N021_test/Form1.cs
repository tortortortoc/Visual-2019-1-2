using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace N021_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "알고리즘의 시간 복잡도 그래프by이수현";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ChartSetting();

        }

        private void ChartSetting()
        {
            // chart1 컨트롤에 Collection에 있었던 내용을 삭제
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // ChartArea 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;

            // ChartArea X축과 Y축을 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = 100;
            chart1.ChartAreas["Draw"].AxisX.Interval = 5;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["Draw"].AxisY.Minimum = -10;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 100;
            chart1.ChartAreas["Draw"].AxisY.Interval = 5;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 추가(lnN)      
            chart1.Series.Add("lnN");
            chart1.Series["lnN"].ChartType = SeriesChartType.Line;
            chart1.Series["lnN"].Color = Color.LightGreen;
            chart1.Series["lnN"].BorderWidth = 1;
            chart1.Series["lnN"].LegendText = "ln(x)";

            
            // Series 추가(N)   
            chart1.Series.Add("N");
            chart1.Series["N"].ChartType = SeriesChartType.Line;
            chart1.Series["N"].Color = Color.Orange;
            chart1.Series["N"].BorderWidth = 1;
            chart1.Series["N"].LegendText = "x";
            
            // Series 추가(N2)      
            chart1.Series.Add("N^2");
            chart1.Series["N^2"].ChartType = SeriesChartType.Line;
            chart1.Series["N^2"].Color = Color.LightBlue;
            chart1.Series["N^2"].BorderWidth = 1;
            chart1.Series["N^2"].LegendText = "x^2";

            // Series 추가(NlnN)   
            chart1.Series.Add("NlnN");
            chart1.Series["NlnN"].ChartType = SeriesChartType.Line;
            chart1.Series["NlnN"].Color = Color.Pink;
            chart1.Series["NlnN"].BorderWidth = 1;
            chart1.Series["NlnN"].LegendText = "xlnx";

            for (double x = 0.001; x < 100; x += 0.1)
            {
                double y = Math.Log(x,2) ;
                chart1.Series["lnN"].Points.AddXY(x, y);

                y = Math.Pow(x,1);
                chart1.Series["N"].Points.AddXY(x, y);

                y = Math.Pow(x,2);
                chart1.Series["N^2"].Points.AddXY(x, y);

                y = Math.Pow(x,1)*Math.Log(x,2);
                chart1.Series["NlnN"].Points.AddXY(x, y);
            }
        }
    }
}
