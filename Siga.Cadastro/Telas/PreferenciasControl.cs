using Bot.App.DataTables;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bot.App.Controls
{
    public partial class PreferenciasControl : UserControl
    {
        private EstudanteService _estudanteService;
        private PreferenciaService _preferenciaService;
        private MensagemService _mensagemService;
        private List<Mensagem>? _mensagens;
        private Estudante? _estudante;
        private Preferencia _preferencia;
        private DataTableMensagens? _dataTable;
        private Mensagem? _mensagemSelecionada;
        private bool isPreferenciaCRUD;

        public PreferenciasControl(int estudanteId)
        {
            InitializeComponent();

            this._estudanteService = new EstudanteService();
            this._preferenciaService = new PreferenciaService();
            this._mensagemService = new MensagemService();
            this._dataTable = new DataTableMensagens();

            this._estudante = this._estudanteService.GetById(estudanteId);
            if (this._estudante != null)
            {
                if (this._estudante.Preferencia != null)
                {
                    this._preferencia = this._estudante.Preferencia;
                    this._mensagens = this._mensagemService.GetByPreferenciaId(this._estudante.Preferencia.Id);
                }
                else
                {
                    var result = CustomMessageBox.CustomMessageBox.Show("Nenhum resultado foi encontrado para preferencias!\n Cadastre a sua preferencia de mensagem.",
                    "Atenção, nenhum preferência configurada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

            this.ConfigurarCrud(true);
            this.UpdateDGVValues();
            this.UpdateUserLabels();
        }

        public void UpdateUserLabels()
        {
            this.lblEstudanteEmail.Text = this._estudante?.Preferencia?.Email ?? "Não definido";
            this.lblEstudanteWhatsapp.Text = this._estudante?.Preferencia?.Whatsapp ?? "Não definido";
        }

        public void UpdateDGVValues()
        {
            if (this._mensagens != null && this._mensagens.Count > 0)
            {
                this._dataTable!.SetItens(this._mensagens);
                this.dgvMensagens.DataSource = this._dataTable;
                this.dgvMensagens.Visible = true;
                this.lblNenhumResultado.Visible = false;
                UpdateTable();
            }
            else
            {
                this.dgvMensagens.Visible = false;
                this.lblNenhumResultado.Visible = true;
            }
        }

        public void ConfigurarCrud(bool isPreferenciaCRUD)
        {

            this.isPreferenciaCRUD = isPreferenciaCRUD;
            if (this.isPreferenciaCRUD)
            {
                this.pcbNome.Visible = false;
                this.txtNome.Visible = false;
                this.lblNome.Visible = false;
                this.lblCRUDTitle.Text = "Sua Preferência";
                this.rtxtMensagemCustomizada.Visible = false;
                this.lblMensagemTitle.Visible = false;

                this.txtmWhatsapp.Texts = this._preferencia?.Whatsapp ?? "";
                this.txtEmail.Texts = this._preferencia?.Email ?? "";
                this.tbAtualizarPorEmail.Checked = this._preferencia?.IsAtualizarPorEmail ?? false;
                this.tbAtualizarPorWhatsapp.Checked = this._preferencia?.IsAtualizarPorWhatsapp ?? false;
                this.btnSalvarAtualizar.Text = "Salvar Preferência";
            }
            else
            {
                this.pcbNome.Visible = true;
                this.txtNome.Visible = true;
                this.lblNome.Visible = true;
                this.lblCRUDTitle.Text = this._mensagemSelecionada != null ? "Editar Mensagem" : "Nova Mensagem";
                this.rtxtMensagemCustomizada.Visible = true;
                this.lblMensagemTitle.Visible = true;

                this.txtmWhatsapp.Texts = this._mensagemSelecionada?.Whatsapp ?? "";
                this.txtEmail.Texts = this._mensagemSelecionada?.Email ?? "";
                this.txtNome.Texts = this._mensagemSelecionada?.Nome ?? "";
                this.tbAtualizarPorEmail.Checked = this._mensagemSelecionada?.IsAtualizarPorEmail ?? false;
                this.tbAtualizarPorWhatsapp.Checked = this._mensagemSelecionada?.IsAtualizarPorWhatsapp ?? false;
                this.rtxtMensagemCustomizada.Text = this._mensagemSelecionada?.Texto ?? "Olá tudo bem? minhas notas no siga foram atualizadas, dê uma conferida se foi atualizada para você também!";
                this.btnSalvarAtualizar.Text = "Salvar Mensagem";
            }
        }

        private void UpdateTable()
        {

            dgvMensagens.RowHeadersVisible = false;
            dgvMensagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvMensagens.MultiSelect = false;

            dgvMensagens.Columns[0].Visible = false;
            dgvMensagens.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensagens.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensagens.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensagens.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvMensagens.Refresh();
        }

        public void SalvarPreferencia()
        {
            List<string> erros = IsPreferenciaValid();
            if (erros.Count > 0)
            {
                CustomMessageBox.CustomMessageBox.Show(string.Join("\n", erros), "Atenção, Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    Preferencia? preferencia = null;

                    if (this._preferencia != null)
                        preferencia = this._preferencia;

                    if (preferencia == null)
                        preferencia = new Preferencia();

                    preferencia.Email = this.txtEmail.Texts;
                    preferencia.Whatsapp = this.txtmWhatsapp.Texts;
                    preferencia.IsAtualizarPorEmail = this.tbAtualizarPorEmail.Checked;
                    preferencia.IsAtualizarPorWhatsapp = this.tbAtualizarPorWhatsapp.Checked;

                    if (_estudante != null)
                    {
                        this._estudante.Preferencia = preferencia;
                        this._estudanteService.Save(this._estudante);
                        CustomMessageBox.CustomMessageBox.Show("Preferência  com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.UpdateUserLabels();
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.CustomMessageBox.Show($"Um erro inesperado aconteceu e não foi possível salvar a preferência\n Mensagem:{ex.Message}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        public void SalvarMensagem()
        {
            var erros = IsMensagemValid();
            if (erros.Count > 0)
            {
                CustomMessageBox.CustomMessageBox.Show(string.Join("\n", erros), "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_preferencia != null)
                    {
                        Mensagem mensagem = new Mensagem();
                        if (this._mensagemSelecionada != null)
                            mensagem = this._mensagemSelecionada;

                        mensagem.Nome = this.txtNome.Texts;
                        mensagem.Email = this.txtEmail.Texts;
                        mensagem.Whatsapp = this.txtmWhatsapp.Texts;
                        mensagem.IsAtualizarPorEmail = this.tbAtualizarPorEmail.Checked;
                        mensagem.IsAtualizarPorWhatsapp = this.tbAtualizarPorWhatsapp.Checked;
                        mensagem.Texto = this.rtxtMensagemCustomizada.Text;
                        mensagem.PreferenciaId = this._preferencia.Id;

                        this._mensagemService.Save(mensagem);
                        CustomMessageBox.CustomMessageBox.Show("Mensagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateScreenAfterSaveMensagem(mensagem);
                    }
                    else
                    {
                        CustomMessageBox.CustomMessageBox.Show("É necessário configurar a sua preferencia antes de salvar uma mensagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.CustomMessageBox.Show($"Um erro inesperado aconteceu e não foi possível salvar a mensagem\n Mensagem:{ex.Message}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateScreenAfterSaveMensagem(Mensagem mensagem)
        {
            this._mensagemSelecionada = null;

            var mensagemExistente = this._mensagens?.FirstOrDefault(m => m.Id == mensagem.Id);
            if (mensagemExistente != null && this._mensagens != null)
            {
                int index = this._mensagens.IndexOf(mensagemExistente);
                this._mensagens[index] = mensagem;
            }
            else
            {
                this._mensagens?.Add(mensagem);
            }
            UpdateDGVValues();
            ConfigurarCrud(true);
        }

        public List<string> IsPreferenciaValid()
        {
            List<string> erros = new List<string>();

            if (this.panelCRUD.Visible)
            {
                if (string.IsNullOrEmpty(txtEmail.Texts))
                {
                    erros.Add("Preencha o campo e-mail.");
                }

                if (!string.IsNullOrEmpty(txtEmail.Texts) && !StringHelper.IsValidEmail(txtEmail.Texts))
                {
                    erros.Add("O Formato do E-mail que você digitou é inválido.");
                }

                if (string.IsNullOrEmpty(txtmWhatsapp.Texts) || txtmWhatsapp.Texts.Length != 13)
                {
                    erros.Add("Preencha o número do WhatsApp corretamente para receber atualizações.");
                }
            }

            return erros;
        }

        public List<string> IsMensagemValid()
        {
            List<string> erros = new List<string>();

            if (this.panelCRUD.Visible)
            {
                if (String.IsNullOrEmpty(txtNome.Texts))
                {
                    erros.Add("Preencha o nome da pessoa que você quer avisar");
                }

                bool emailPreenchidoCorreto = !string.IsNullOrEmpty(txtEmail.Texts) && StringHelper.IsValidEmail(txtEmail.Texts);
                bool whatsappPreenchidoCorreto = !string.IsNullOrEmpty(txtmWhatsapp.Texts) && txtmWhatsapp.Texts.Length == 13;

                if (!emailPreenchidoCorreto && !whatsappPreenchidoCorreto)
                {
                    erros.Add("Por favor, preencha pelo menos o campo de e-mail ou de WhatsApp corretamente.");
                }
            }

            return erros;
        }

        private void btnSalvarAtualizar_Click(object sender, EventArgs e)
        {
            if (this.isPreferenciaCRUD)
            {
                this.SalvarPreferencia();
            }
            else
            {
                this.SalvarMensagem();
            }
        }


        private void btnAdicionarMensagem_Click_1(object sender, EventArgs e)
        {
            this._mensagemSelecionada = null;
            this.ConfigurarCrud(false);
        }

        private void btnEditarMensagem_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMensagens != null && this.dgvMensagens.SelectedRows.Count > 0)
            {
                var linhaSelecionada = this.dgvMensagens.SelectedRows[0];
                int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
                Mensagem? mensagemSelecionada = this._mensagens!.FirstOrDefault(mm => mm.Id == idSelecionado);

                if (mensagemSelecionada != null)
                {
                    this._mensagemSelecionada = mensagemSelecionada;
                    ConfigurarCrud(false);
                }
                else
                {
                    CustomMessageBox.CustomMessageBox.Show("Selecione uma mensagem válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                CustomMessageBox.CustomMessageBox.Show("Nenhuma mensagem selecionada. Selecione uma mensagem para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirMensagem_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMensagens != null && this.dgvMensagens.SelectedRows.Count > 0)
            {
                var linhaSelecionada = this.dgvMensagens.SelectedRows[0];
                int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
                Mensagem? mensagemSelecionada = this._mensagens!.FirstOrDefault(mm => mm.Id == idSelecionado);
                if (mensagemSelecionada != null && this._mensagens != null)
                {
                    DialogResult resultado = CustomMessageBox.CustomMessageBox.Show("Tem certeza que deseja excluir esta mensagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this._mensagemService.Remove(mensagemSelecionada);

                        var mensagemParaRemover = this._mensagens!.FirstOrDefault(m => m.Id == mensagemSelecionada.Id);
                        if (mensagemParaRemover != null)
                        {
                            this._mensagens.Remove(mensagemParaRemover);
                        }
                        this.UpdateDGVValues();
                        this.UpdateTable();
                        this._mensagemSelecionada = null;
                        this.ConfigurarCrud(true);
                        CustomMessageBox.CustomMessageBox.Show("Mensagem excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    CustomMessageBox.CustomMessageBox.Show("Nenhuma mensagem selecionada. Selecione uma mensagem para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                CustomMessageBox.CustomMessageBox.Show("Nenhuma mensagem selecionada. Selecione uma mensagem para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            this._mensagemSelecionada = null;
            this.ConfigurarCrud(true);
        }

        private void dgvMensagens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvMensagens != null && this.dgvMensagens.SelectedRows.Count > 0)
            {
                var linhaSelecionada = this.dgvMensagens.SelectedRows[0]; 
                int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
                Mensagem? mensagemSelecionada = this._mensagens!.FirstOrDefault(mm => mm.Id == idSelecionado);

                if (mensagemSelecionada != null)
                {
                    this._mensagemSelecionada = mensagemSelecionada;
                    ConfigurarCrud(false);
                }
            }
        }
    }
}
