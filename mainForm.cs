using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingPongPower
{
    public partial class MainForm : Form
    {
        // Prepare the settings window
        private settingsForm settings = new settingsForm();

        public MainForm()
        {
            this.InitializeComponent();
        }
        
        private void NewTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            targetControl target = new targetControl();
            target.Dock = DockStyle.Bottom;
            target.targetResponseEvent += new targetControl.targetResponseHandler(this.TargetResponseRoutine);
            this.Controls.Add(target);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0} for simple ping-monitoring\r\nCopyright: Johan Åhman\r\nVersion: {1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version), System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.settings.ShowDialog();
        }
        
        private void TargetResponseRoutine(object sender, targetArgs ta)
        {
            string seriesLabel = ta.label.ToString();
            int roundtripTime = (int)ta.response.RoundtripTime;
            if (this.chart1.Series.IndexOf(seriesLabel) == -1)
            {
                   this.chart1.Series.Add(seriesLabel);
                   
                // this.chart1.Series[seriesLabel].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            
            this.chart1.Series[seriesLabel].Points.Add(roundtripTime);
            this.chart1.Series[seriesLabel].Points[this.chart1.Series[seriesLabel].Points.Count - 1].Label = roundtripTime.ToString();
            
            this.chart1.ChartAreas["area"].AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.Last);
        }
                
        private void Chart1Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["area"].AxisX.ScaleView.Size = 20;
            chart1.ChartAreas["area"].AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.Last);
        }
        
        private void MainFormLoad(object sender, EventArgs e)
        {
            //Setting up default graph area
            chart1.ChartAreas.Add("area");
            chart1.ChartAreas["area"].AxisX.Minimum = 0;
            chart1.ChartAreas["area"].AxisX.ScaleView.Size = 20;
            chart1.ChartAreas["area"].AxisX.Interval = 1;
            
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            //chart1.ChartAreas["area"].AxisY.ScaleView.Size = 200;
            //chart1.ChartAreas["area"].AxisY.Interval = 25;            
        }
    }
}
