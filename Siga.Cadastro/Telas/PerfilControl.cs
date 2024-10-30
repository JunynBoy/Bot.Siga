using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot.Core.Model;

namespace Bot.App.Controls
{
    public partial class PerfilControl : UserControl
    {

        Estudante estudante;

        public PerfilControl(Estudante estudante)
        {
            this.estudante = estudante;

            InitializeComponent();
            InitChart();
            
        }

        public void InitChart()
        {
            var myModel = new PlotModel();

            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,  
                StartAngle = 0,   

                InsideLabelColor = OxyColors.White,  
                OutsideLabelFormat = "{1}: {0:0}", 
            };
            
            pieSeries.Slices.Add(new PieSlice("Cursado", 6) { IsExploded = true, Fill = OxyColors.Red });
            pieSeries.Slices.Add(new PieSlice("Faltam", 4) { Fill = OxyColors.Gold });

            myModel.Series.Add(pieSeries);

            this.pvPieChart.Model = myModel;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
