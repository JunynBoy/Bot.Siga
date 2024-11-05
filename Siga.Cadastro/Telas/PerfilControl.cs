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
using Bot.Core.Service;

namespace Bot.App.Controls
{
    public partial class PerfilControl : UserControl
    {

        Estudante? estudante;
        EstudanteService _estudanteService;

        public PerfilControl(int idEstudante)
        {
            InitializeComponent();
            this._estudanteService = new EstudanteService();
            Init(idEstudante);
        }

        private void Init(int idEstudante)
        {
            try
            {
                this.estudante = this._estudanteService!.GetById(idEstudante);
                if (estudante != null)
                {
                    ConfigurarParametros();
                    ConfigurarBarraPorcentagem();
                    InitChart();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.CustomMessageBox.Show(this, $"Não foi possível concluir a execução do aplicativo devido a um erro não esperado: \n\nMensagem:{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                InsideLabelFormat = "{1}: {0:0}", 
                OutsideLabelFormat = null,
            };

            Double valueCursado = 0D;
            Double valueFaltam = 0D;
            if (estudante!.Cursado != null && estudante.Faltam != null)
            {
                valueCursado = Double.Parse(estudante.Cursado);
                valueFaltam = Double.Parse(estudante.Faltam);
            }

            pieSeries.Slices.Add(new PieSlice("Cursado", valueCursado)
            {
                IsExploded = true,
                Fill = OxyColors.Red
            });
            pieSeries.Slices.Add(new PieSlice("Faltam", valueFaltam)
            {
                Fill = OxyColors.Gold
            });

            myModel.Series.Add(pieSeries);

            this.pvPieChart.Model = myModel;
        }

        private void ConfigurarParametros()
        {
            this.lblNome.Text = this.GetLabelValue(estudante.Nome);
            this.lblEmailInstitucional.Text = this.GetLabelValue(estudante.EmailInstitucional);
            this.lblMaximo.Text = this.GetLabelValue(estudante.Maximo);
            this.lblRA.Text = this.GetLabelValue(estudante.Ra);
            this.lblCiclo.Text = this.GetLabelValue(estudante.Ciclo);
            this.lblPercentualProgressao.Text = this.GetLabelValue(estudante.PP?.Replace("%"," %").Trim() ?? "0 %");
            this.lblPercentualRendimento.Text = $"{this.GetLabelValue(estudante.PR?.Replace("%", " %").Trim() ?? "?")}/10";
        }

        private void ConfigurarBarraPorcentagem()
        {
            if (estudante!.PP != null && estudante!.PR != null)
            {
                this.pbPercentualProgressao.Maximum = 100;
                this.pbPercentualRendimento.Maximum = 10;

                int LimitarValor(double valor)
                {
                    if (valor < 0) return 0;
                    if (valor > 100) return 100;
                    return (int)Math.Round(valor);
                }

                this.pbPercentualProgressao.Value = LimitarValor(Double.Parse(estudante.PP.Replace("%", "").Trim()!));
                this.pbPercentualRendimento.Value = LimitarValor(Double.Parse(estudante.PR.Replace("%", "").Trim()!));
            }
        }
            

        private string GetLabelValue(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return "???";
            }
            else
            {
                return value;
            }
        }

        private string GetLabelValue(Double? value)
        {
            if (value == null || value == 0)
            {
                return "???";
            }
            else
            {
                return value.ToString()!;
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
