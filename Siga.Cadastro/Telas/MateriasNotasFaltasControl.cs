using Bot.App.DataTables;
using Bot.Core.Model;
using Bot.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot.App.Controls
{
    public partial class MateriasNotasFaltasControl : UserControl
    {
        private Estudante? _estudante;
        private List<Materia>? _materias;
        private List<Materia> _materiasCompletaAux;

        private DataTableMateriasNotasFaltas _dataTable;
        private MateriaService _materiaService;
        private EstudanteService _estudanteService;
     
        public MateriasNotasFaltasControl(int estudanteId)
        {
            InitializeComponent();

            this._materiaService = new MateriaService();
            this._estudanteService = new EstudanteService();

            this._estudante = this._estudanteService.GetById(estudanteId);

            this.UpdateLblCiclo();

            this._materiasCompletaAux = this._materiaService.GetByEstudanteId(estudanteId)!;
            if (_materiasCompletaAux != null)
            {
                this._materias = new List<Materia>(this._materiasCompletaAux); ;
            }
            else
            {
                this._materias = new List<Materia>();
                this._materiasCompletaAux = new List<Materia>();
            }
            this._dataTable = new DataTableMateriasNotasFaltas();

            this.UpdateDados();
        }

        private void UpdateLblCiclo()
        {
            if (this._estudante != null)
            {
                this.lblCiclo.Text = $"Ciclo {this._estudante.Ciclo}";
            }
            else
            {
                this.lblCiclo.Text = $"Ciclo ??";
            }
        }

        private void UpdateDados()
        {
            this.AtualizarUltimaAtualizacao();
            if (this._materias != null && this._materias.Count > 0)
            {
                this.lblNenhumResultado.Visible = false;
                this.dgvMateriasNotasFaltas.DataSource = _dataTable;
                this._dataTable.SetItens(this._materias);
                this.updateTable();
                this.dgvMateriasNotasFaltas.Visible = true;
            }
            else
            {
                this.dgvMateriasNotasFaltas.Visible = false;
                this.lblNenhumResultado.Visible = true;
            }
        }

        private void AtualizarUltimaAtualizacao()
        {
            if (this._materias != null && this._materias.Any())
            {
                DateTime? ultimaAtualizacao = null;

                foreach (Materia materia in this._materias)
                {
                    if (materia.UpdatedAt.HasValue && (ultimaAtualizacao == null || materia.UpdatedAt > ultimaAtualizacao))
                    {
                        ultimaAtualizacao = materia.UpdatedAt;
                    }
                }

                if (ultimaAtualizacao.HasValue)
                {
                    this.lblUltimaAtualizacao.Text = $"Última Atualização - {ultimaAtualizacao.Value:dd/MM/yyyy} - {ultimaAtualizacao.Value:HH:mm}";
                }
                else
                {
                    this.lblUltimaAtualizacao.Text = "Última Atualização - ??/??/???? - ??:??";
                }
            }
            else
            {
                this.lblUltimaAtualizacao.Text = "Última Atualização - ??/??/???? - ??:??";
            }
        }


        private void updateTable()
        {

            dgvMateriasNotasFaltas.RowHeadersVisible = false;
            dgvMateriasNotasFaltas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriasNotasFaltas.MultiSelect = false;
            dgvMateriasNotasFaltas.AllowUserToAddRows = false;

            dgvMateriasNotasFaltas.Columns[0].Visible = false; 

            dgvMateriasNotasFaltas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMateriasNotasFaltas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMateriasNotasFaltas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvMateriasNotasFaltas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMateriasNotasFaltas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMateriasNotasFaltas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvMateriasNotasFaltas.Refresh();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._materias = new List<Materia>(this._materiasCompletaAux
                .Where(m => m.Nome != null && m.Nome.ToUpper().Contains(this.txtMateria.Texts.ToUpper()))
                .ToList());
            this.UpdateDados();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this._materias = new List<Materia>(this._materiasCompletaAux);
            this.UpdateDados();
        }

        private void btnEncerrarCiclo_Click(object sender, EventArgs e)
        {
            if (this._materias != null)
            {
                DialogResult resultado = CustomMessageBox.CustomMessageBox.Show("Tem certeza que deseja limpar todas as matérias?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    foreach (Materia materia in this._materias)
                    {
                        try
                        {
                            this._materiaService.Remove(materia);
                        }
                        catch (Exception ex)
                        {
                            CustomMessageBox.CustomMessageBox.Show($"Não foi possível deletar a matéria '{materia.Codigo}': {ex.Message}", "Erro ao Deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    CustomMessageBox.CustomMessageBox.Show("Processo de encerramento do ciclo concluído.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._materias = null;
                    this.UpdateDados();
                }
            }
            else{
                CustomMessageBox.CustomMessageBox.Show($"Você ainda não possui nenhuma matéri cadastrada.\nExperimente buscar por novas matérias na tela principal.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
