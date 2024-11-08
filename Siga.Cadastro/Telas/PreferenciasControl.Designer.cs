namespace Bot.App.Controls
{
    partial class PreferenciasControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenciasControl));
            panel1 = new Panel();
            lblNenhumResultado = new Label();
            dgvMensagens = new DataGridView();
            panelHeaderMensagem = new Panel();
            lblEnviarMensagemAoAtualizarNotaTitle = new Label();
            btnAdicionarMensagem = new CustomButton();
            btnEditarMensagem = new CustomButton();
            btnExcluirMensagem = new CustomButton();
            panel3 = new Panel();
            panelPerfilConfigurado = new Panel();
            lblEstudanteEmail = new Label();
            pcbUser = new PictureBox();
            lblEstudanteWhatsapp = new Label();
            lblEstudanteWhatsappTitle = new Label();
            panelSubHeaderSuasPreferencias = new Panel();
            btnEditarUsuario = new CustomButton();
            lblSuasPreferenciasTitle = new Label();
            lblEstudanteEmailTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelCRUD = new Panel();
            txtNome = new CustomTextBox();
            pcbNome = new PictureBox();
            lblNome = new Label();
            btnSalvarAtualizar = new CustomButton();
            lblMensagemTitle = new Label();
            rtxtMensagemCustomizada = new RichTextBox();
            lblAtualizarPorEmail = new Label();
            tbAtualizarPorEmail = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            tbAtualizarPorWhatsapp = new CustomControls.CustomControls.CustomToggleButton();
            panelSubHeaderPreferencias = new Panel();
            lblCRUDTitle = new Label();
            txtmWhatsapp = new CustomMaskedTextBox();
            txtEmail = new CustomTextBox();
            pcbEmail = new PictureBox();
            pcbWhatsapp = new PictureBox();
            lblWhatsapp = new Label();
            lblEmail = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMensagens).BeginInit();
            panelHeaderMensagem.SuspendLayout();
            panel3.SuspendLayout();
            panelPerfilConfigurado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            panelSubHeaderSuasPreferencias.SuspendLayout();
            panelCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNome).BeginInit();
            panelSubHeaderPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNenhumResultado);
            panel1.Controls.Add(dgvMensagens);
            panel1.Controls.Add(panelHeaderMensagem);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 389);
            panel1.TabIndex = 0;
            // 
            // lblNenhumResultado
            // 
            lblNenhumResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNenhumResultado.AutoSize = true;
            lblNenhumResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNenhumResultado.ForeColor = Color.FromArgb(30, 39, 44);
            lblNenhumResultado.Location = new Point(34, 262);
            lblNenhumResultado.Name = "lblNenhumResultado";
            lblNenhumResultado.Size = new Size(292, 25);
            lblNenhumResultado.TabIndex = 51;
            lblNenhumResultado.Text = "Nenhum resultado encontrado.";
            lblNenhumResultado.Visible = false;
            // 
            // dgvMensagens
            // 
            dgvMensagens.AllowUserToAddRows = false;
            dgvMensagens.AllowUserToDeleteRows = false;
            dgvMensagens.AllowUserToResizeColumns = false;
            dgvMensagens.BorderStyle = BorderStyle.None;
            dgvMensagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMensagens.Dock = DockStyle.Fill;
            dgvMensagens.Location = new Point(0, 162);
            dgvMensagens.MultiSelect = false;
            dgvMensagens.Name = "dgvMensagens";
            dgvMensagens.RowTemplate.Height = 25;
            dgvMensagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMensagens.Size = new Size(368, 227);
            dgvMensagens.TabIndex = 5;
            dgvMensagens.MouseDoubleClick += dgvMensagens_MouseDoubleClick;
            // 
            // panelHeaderMensagem
            // 
            panelHeaderMensagem.BackColor = SystemColors.Control;
            panelHeaderMensagem.Controls.Add(lblEnviarMensagemAoAtualizarNotaTitle);
            panelHeaderMensagem.Controls.Add(btnAdicionarMensagem);
            panelHeaderMensagem.Controls.Add(btnEditarMensagem);
            panelHeaderMensagem.Controls.Add(btnExcluirMensagem);
            panelHeaderMensagem.Dock = DockStyle.Top;
            panelHeaderMensagem.Location = new Point(0, 121);
            panelHeaderMensagem.Name = "panelHeaderMensagem";
            panelHeaderMensagem.Size = new Size(368, 41);
            panelHeaderMensagem.TabIndex = 4;
            // 
            // lblEnviarMensagemAoAtualizarNotaTitle
            // 
            lblEnviarMensagemAoAtualizarNotaTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEnviarMensagemAoAtualizarNotaTitle.AutoSize = true;
            lblEnviarMensagemAoAtualizarNotaTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnviarMensagemAoAtualizarNotaTitle.Location = new Point(3, 12);
            lblEnviarMensagemAoAtualizarNotaTitle.Name = "lblEnviarMensagemAoAtualizarNotaTitle";
            lblEnviarMensagemAoAtualizarNotaTitle.Size = new Size(233, 19);
            lblEnviarMensagemAoAtualizarNotaTitle.TabIndex = 71;
            lblEnviarMensagemAoAtualizarNotaTitle.Text = "Enviar Mensagem ao Atualizar Nota";
            // 
            // btnAdicionarMensagem
            // 
            btnAdicionarMensagem.BackColor = Color.White;
            btnAdicionarMensagem.BackgroundColor = Color.White;
            btnAdicionarMensagem.BorderColor = Color.Black;
            btnAdicionarMensagem.BorderRadius = 15;
            btnAdicionarMensagem.BorderSize = 1;
            btnAdicionarMensagem.FlatAppearance.BorderSize = 0;
            btnAdicionarMensagem.FlatStyle = FlatStyle.Flat;
            btnAdicionarMensagem.ForeColor = Color.White;
            btnAdicionarMensagem.Image = (Image)resources.GetObject("btnAdicionarMensagem.Image");
            btnAdicionarMensagem.Location = new Point(260, 6);
            btnAdicionarMensagem.Name = "btnAdicionarMensagem";
            btnAdicionarMensagem.Size = new Size(30, 30);
            btnAdicionarMensagem.TabIndex = 70;
            btnAdicionarMensagem.TextColor = Color.White;
            btnAdicionarMensagem.UseVisualStyleBackColor = false;
            btnAdicionarMensagem.Click += btnAdicionarMensagem_Click_1;
            // 
            // btnEditarMensagem
            // 
            btnEditarMensagem.BackColor = Color.White;
            btnEditarMensagem.BackgroundColor = Color.White;
            btnEditarMensagem.BorderColor = Color.Black;
            btnEditarMensagem.BorderRadius = 15;
            btnEditarMensagem.BorderSize = 1;
            btnEditarMensagem.FlatAppearance.BorderSize = 0;
            btnEditarMensagem.FlatStyle = FlatStyle.Flat;
            btnEditarMensagem.ForeColor = Color.White;
            btnEditarMensagem.Image = (Image)resources.GetObject("btnEditarMensagem.Image");
            btnEditarMensagem.Location = new Point(296, 6);
            btnEditarMensagem.Name = "btnEditarMensagem";
            btnEditarMensagem.Size = new Size(30, 30);
            btnEditarMensagem.TabIndex = 69;
            btnEditarMensagem.TextColor = Color.White;
            btnEditarMensagem.UseVisualStyleBackColor = false;
            btnEditarMensagem.Click += btnEditarMensagem_Click_1;
            // 
            // btnExcluirMensagem
            // 
            btnExcluirMensagem.BackColor = Color.White;
            btnExcluirMensagem.BackgroundColor = Color.White;
            btnExcluirMensagem.BorderColor = Color.Black;
            btnExcluirMensagem.BorderRadius = 15;
            btnExcluirMensagem.BorderSize = 1;
            btnExcluirMensagem.FlatAppearance.BorderSize = 0;
            btnExcluirMensagem.FlatStyle = FlatStyle.Flat;
            btnExcluirMensagem.ForeColor = Color.White;
            btnExcluirMensagem.Image = (Image)resources.GetObject("btnExcluirMensagem.Image");
            btnExcluirMensagem.Location = new Point(332, 6);
            btnExcluirMensagem.Name = "btnExcluirMensagem";
            btnExcluirMensagem.Size = new Size(30, 30);
            btnExcluirMensagem.TabIndex = 68;
            btnExcluirMensagem.TextColor = Color.White;
            btnExcluirMensagem.UseVisualStyleBackColor = false;
            btnExcluirMensagem.Click += btnExcluirMensagem_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelPerfilConfigurado);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 121);
            panel3.TabIndex = 0;
            // 
            // panelPerfilConfigurado
            // 
            panelPerfilConfigurado.BackColor = Color.White;
            panelPerfilConfigurado.Controls.Add(lblEstudanteEmail);
            panelPerfilConfigurado.Controls.Add(pcbUser);
            panelPerfilConfigurado.Controls.Add(lblEstudanteWhatsapp);
            panelPerfilConfigurado.Controls.Add(lblEstudanteWhatsappTitle);
            panelPerfilConfigurado.Controls.Add(panelSubHeaderSuasPreferencias);
            panelPerfilConfigurado.Controls.Add(lblEstudanteEmailTitle);
            panelPerfilConfigurado.Dock = DockStyle.Top;
            panelPerfilConfigurado.Location = new Point(0, 0);
            panelPerfilConfigurado.Name = "panelPerfilConfigurado";
            panelPerfilConfigurado.Size = new Size(368, 121);
            panelPerfilConfigurado.TabIndex = 67;
            // 
            // lblEstudanteEmail
            // 
            lblEstudanteEmail.AutoSize = true;
            lblEstudanteEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstudanteEmail.ForeColor = Color.FromArgb(30, 39, 44);
            lblEstudanteEmail.Location = new Point(109, 61);
            lblEstudanteEmail.Name = "lblEstudanteEmail";
            lblEstudanteEmail.Size = new Size(187, 15);
            lblEstudanteEmail.TabIndex = 66;
            lblEstudanteEmail.Text = "marcos.gaparini@fatec.sp.gov.br";
            lblEstudanteEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // pcbUser
            // 
            pcbUser.BackColor = Color.FromArgb(224, 224, 224);
            pcbUser.Image = (Image)resources.GetObject("pcbUser.Image");
            pcbUser.Location = new Point(3, 47);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(100, 68);
            pcbUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbUser.TabIndex = 67;
            pcbUser.TabStop = false;
            // 
            // lblEstudanteWhatsapp
            // 
            lblEstudanteWhatsapp.AutoSize = true;
            lblEstudanteWhatsapp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstudanteWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblEstudanteWhatsapp.Location = new Point(109, 100);
            lblEstudanteWhatsapp.Name = "lblEstudanteWhatsapp";
            lblEstudanteWhatsapp.Size = new Size(93, 15);
            lblEstudanteWhatsapp.TabIndex = 66;
            lblEstudanteWhatsapp.Text = "(00) 0000-0000";
            lblEstudanteWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEstudanteWhatsappTitle
            // 
            lblEstudanteWhatsappTitle.AutoSize = true;
            lblEstudanteWhatsappTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstudanteWhatsappTitle.Location = new Point(109, 81);
            lblEstudanteWhatsappTitle.Name = "lblEstudanteWhatsappTitle";
            lblEstudanteWhatsappTitle.Size = new Size(72, 19);
            lblEstudanteWhatsappTitle.TabIndex = 65;
            lblEstudanteWhatsappTitle.Text = "Whatsapp";
            // 
            // panelSubHeaderSuasPreferencias
            // 
            panelSubHeaderSuasPreferencias.BackColor = SystemColors.Control;
            panelSubHeaderSuasPreferencias.Controls.Add(btnEditarUsuario);
            panelSubHeaderSuasPreferencias.Controls.Add(lblSuasPreferenciasTitle);
            panelSubHeaderSuasPreferencias.Dock = DockStyle.Top;
            panelSubHeaderSuasPreferencias.Location = new Point(0, 0);
            panelSubHeaderSuasPreferencias.Name = "panelSubHeaderSuasPreferencias";
            panelSubHeaderSuasPreferencias.Size = new Size(368, 41);
            panelSubHeaderSuasPreferencias.TabIndex = 0;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.White;
            btnEditarUsuario.BackgroundColor = Color.White;
            btnEditarUsuario.BorderColor = Color.Black;
            btnEditarUsuario.BorderRadius = 15;
            btnEditarUsuario.BorderSize = 1;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.Location = new Point(332, 7);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(30, 30);
            btnEditarUsuario.TabIndex = 68;
            btnEditarUsuario.TextColor = Color.White;
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // lblSuasPreferenciasTitle
            // 
            lblSuasPreferenciasTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSuasPreferenciasTitle.AutoSize = true;
            lblSuasPreferenciasTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuasPreferenciasTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblSuasPreferenciasTitle.Location = new Point(3, 7);
            lblSuasPreferenciasTitle.Name = "lblSuasPreferenciasTitle";
            lblSuasPreferenciasTitle.Size = new Size(167, 25);
            lblSuasPreferenciasTitle.TabIndex = 62;
            lblSuasPreferenciasTitle.Text = "Suas preferências";
            // 
            // lblEstudanteEmailTitle
            // 
            lblEstudanteEmailTitle.AutoSize = true;
            lblEstudanteEmailTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstudanteEmailTitle.Location = new Point(109, 42);
            lblEstudanteEmailTitle.Name = "lblEstudanteEmailTitle";
            lblEstudanteEmailTitle.Size = new Size(49, 19);
            lblEstudanteEmailTitle.TabIndex = 65;
            lblEstudanteEmailTitle.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 39, 44);
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 66;
            label2.Text = "marcos.gaparini@fatec.sp.gov.br";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(131, 19);
            label3.TabIndex = 65;
            label3.Text = "E-mail Institucional";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 39, 44);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 65;
            label1.Text = "Informações Essenciais";
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(txtNome);
            panelCRUD.Controls.Add(pcbNome);
            panelCRUD.Controls.Add(lblNome);
            panelCRUD.Controls.Add(btnSalvarAtualizar);
            panelCRUD.Controls.Add(lblMensagemTitle);
            panelCRUD.Controls.Add(rtxtMensagemCustomizada);
            panelCRUD.Controls.Add(lblAtualizarPorEmail);
            panelCRUD.Controls.Add(tbAtualizarPorEmail);
            panelCRUD.Controls.Add(lblAtualizarPorWhatsapp);
            panelCRUD.Controls.Add(tbAtualizarPorWhatsapp);
            panelCRUD.Controls.Add(panelSubHeaderPreferencias);
            panelCRUD.Controls.Add(txtmWhatsapp);
            panelCRUD.Controls.Add(txtEmail);
            panelCRUD.Controls.Add(pcbEmail);
            panelCRUD.Controls.Add(pcbWhatsapp);
            panelCRUD.Controls.Add(lblWhatsapp);
            panelCRUD.Controls.Add(lblEmail);
            panelCRUD.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelCRUD.Location = new Point(374, 0);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(426, 389);
            panelCRUD.TabIndex = 70;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.BorderColor = Color.FromArgb(66, 84, 96);
            txtNome.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtNome.BorderSize = 1;
            txtNome.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNome.ForeColor = Color.DimGray;
            txtNome.Location = new Point(77, 73);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(7);
            txtNome.PasswordChar = false;
            txtNome.Size = new Size(300, 29);
            txtNome.TabIndex = 74;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = true;
            // 
            // pcbNome
            // 
            pcbNome.Image = (Image)resources.GetObject("pcbNome.Image");
            pcbNome.Location = new Point(45, 77);
            pcbNome.Name = "pcbNome";
            pcbNome.Size = new Size(25, 25);
            pcbNome.TabIndex = 75;
            pcbNome.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(77, 50);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 19);
            lblNome.TabIndex = 73;
            lblNome.Text = "Nome";
            // 
            // btnSalvarAtualizar
            // 
            btnSalvarAtualizar.BackColor = Color.FromArgb(66, 84, 96);
            btnSalvarAtualizar.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnSalvarAtualizar.BorderColor = Color.FromArgb(64, 64, 64);
            btnSalvarAtualizar.BorderRadius = 3;
            btnSalvarAtualizar.BorderSize = 1;
            btnSalvarAtualizar.FlatAppearance.BorderSize = 0;
            btnSalvarAtualizar.FlatStyle = FlatStyle.Flat;
            btnSalvarAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarAtualizar.ForeColor = Color.White;
            btnSalvarAtualizar.Location = new Point(256, 361);
            btnSalvarAtualizar.Name = "btnSalvarAtualizar";
            btnSalvarAtualizar.Size = new Size(121, 23);
            btnSalvarAtualizar.TabIndex = 72;
            btnSalvarAtualizar.Text = "Salvar";
            btnSalvarAtualizar.TextColor = Color.White;
            btnSalvarAtualizar.UseVisualStyleBackColor = false;
            btnSalvarAtualizar.Click += btnSalvarAtualizar_Click;
            // 
            // lblMensagemTitle
            // 
            lblMensagemTitle.AutoSize = true;
            lblMensagemTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagemTitle.Location = new Point(44, 268);
            lblMensagemTitle.Name = "lblMensagemTitle";
            lblMensagemTitle.Size = new Size(162, 19);
            lblMensagemTitle.TabIndex = 70;
            lblMensagemTitle.Text = "Mensagem Customizada";
            // 
            // rtxtMensagemCustomizada
            // 
            rtxtMensagemCustomizada.BorderStyle = BorderStyle.FixedSingle;
            rtxtMensagemCustomizada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtMensagemCustomizada.Location = new Point(45, 290);
            rtxtMensagemCustomizada.Name = "rtxtMensagemCustomizada";
            rtxtMensagemCustomizada.Size = new Size(332, 65);
            rtxtMensagemCustomizada.TabIndex = 69;
            rtxtMensagemCustomizada.Text = "Olá! aqui é o robozinho do SIGA, estou te enviando essa mensagem por que houve atualizações de notas no siga... da uma conferida lá!";
            // 
            // lblAtualizarPorEmail
            // 
            lblAtualizarPorEmail.AutoSize = true;
            lblAtualizarPorEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorEmail.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorEmail.Location = new Point(95, 246);
            lblAtualizarPorEmail.Name = "lblAtualizarPorEmail";
            lblAtualizarPorEmail.Size = new Size(153, 17);
            lblAtualizarPorEmail.TabIndex = 0;
            lblAtualizarPorEmail.Text = "Atualizações por E-mail";
            // 
            // tbAtualizarPorEmail
            // 
            tbAtualizarPorEmail.Location = new Point(44, 246);
            tbAtualizarPorEmail.MinimumSize = new Size(45, 22);
            tbAtualizarPorEmail.Name = "tbAtualizarPorEmail";
            tbAtualizarPorEmail.OffBackColor = Color.Gray;
            tbAtualizarPorEmail.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorEmail.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorEmail.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorEmail.Size = new Size(45, 22);
            tbAtualizarPorEmail.TabIndex = 8;
            tbAtualizarPorEmail.UseVisualStyleBackColor = true;
            // 
            // lblAtualizarPorWhatsapp
            // 
            lblAtualizarPorWhatsapp.AutoSize = true;
            lblAtualizarPorWhatsapp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorWhatsapp.Location = new Point(95, 218);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(176, 17);
            lblAtualizarPorWhatsapp.TabIndex = 0;
            lblAtualizarPorWhatsapp.Text = "Atualizações por Whatsapp";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAtualizarPorWhatsapp
            // 
            tbAtualizarPorWhatsapp.Location = new Point(44, 218);
            tbAtualizarPorWhatsapp.MinimumSize = new Size(45, 22);
            tbAtualizarPorWhatsapp.Name = "tbAtualizarPorWhatsapp";
            tbAtualizarPorWhatsapp.OffBackColor = Color.Gray;
            tbAtualizarPorWhatsapp.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorWhatsapp.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorWhatsapp.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorWhatsapp.Size = new Size(45, 22);
            tbAtualizarPorWhatsapp.TabIndex = 7;
            tbAtualizarPorWhatsapp.UseVisualStyleBackColor = true;
            // 
            // panelSubHeaderPreferencias
            // 
            panelSubHeaderPreferencias.BackColor = SystemColors.Control;
            panelSubHeaderPreferencias.Controls.Add(lblCRUDTitle);
            panelSubHeaderPreferencias.Dock = DockStyle.Top;
            panelSubHeaderPreferencias.Location = new Point(0, 0);
            panelSubHeaderPreferencias.Name = "panelSubHeaderPreferencias";
            panelSubHeaderPreferencias.Size = new Size(426, 41);
            panelSubHeaderPreferencias.TabIndex = 42;
            // 
            // lblCRUDTitle
            // 
            lblCRUDTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCRUDTitle.AutoSize = true;
            lblCRUDTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCRUDTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblCRUDTitle.Location = new Point(137, 7);
            lblCRUDTitle.Name = "lblCRUDTitle";
            lblCRUDTitle.Size = new Size(167, 25);
            lblCRUDTitle.TabIndex = 40;
            lblCRUDTitle.Text = "Suas Preferências";
            // 
            // txtmWhatsapp
            // 
            txtmWhatsapp.BackColor = SystemColors.Window;
            txtmWhatsapp.BorderColor = Color.FromArgb(66, 84, 96);
            txtmWhatsapp.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtmWhatsapp.BorderSize = 1;
            txtmWhatsapp.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmWhatsapp.ForeColor = Color.DimGray;
            txtmWhatsapp.Location = new Point(77, 129);
            txtmWhatsapp.Margin = new Padding(4);
            txtmWhatsapp.Mask = "00 00000-0000";
            txtmWhatsapp.Multiline = false;
            txtmWhatsapp.Name = "txtmWhatsapp";
            txtmWhatsapp.Padding = new Padding(7);
            txtmWhatsapp.PasswordChar = false;
            txtmWhatsapp.Size = new Size(300, 29);
            txtmWhatsapp.TabIndex = 5;
            txtmWhatsapp.Texts = "        -";
            txtmWhatsapp.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.FromArgb(66, 84, 96);
            txtEmail.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtEmail.BorderSize = 1;
            txtEmail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(77, 185);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(300, 29);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(45, 189);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(25, 25);
            pcbEmail.TabIndex = 40;
            pcbEmail.TabStop = false;
            // 
            // pcbWhatsapp
            // 
            pcbWhatsapp.Image = (Image)resources.GetObject("pcbWhatsapp.Image");
            pcbWhatsapp.Location = new Point(45, 133);
            pcbWhatsapp.Name = "pcbWhatsapp";
            pcbWhatsapp.Size = new Size(25, 25);
            pcbWhatsapp.TabIndex = 40;
            pcbWhatsapp.TabStop = false;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblWhatsapp.Location = new Point(77, 105);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(72, 19);
            lblWhatsapp.TabIndex = 0;
            lblWhatsapp.Text = "Whatsapp";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(77, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            // 
            // PreferenciasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCRUD);
            Controls.Add(panel1);
            Name = "PreferenciasControl";
            Size = new Size(800, 389);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMensagens).EndInit();
            panelHeaderMensagem.ResumeLayout(false);
            panelHeaderMensagem.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelPerfilConfigurado.ResumeLayout(false);
            panelPerfilConfigurado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            panelSubHeaderSuasPreferencias.ResumeLayout(false);
            panelSubHeaderSuasPreferencias.PerformLayout();
            panelCRUD.ResumeLayout(false);
            panelCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNome).EndInit();
            panelSubHeaderPreferencias.ResumeLayout(false);
            panelSubHeaderPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lblSuasPreferenciasTitle;
        private Panel panelPerfilConfigurado;
        private Label lblEstudanteWhatsapp;
        private Label lblEstudanteEmail;
        private Label lblEstudanteWhatsappTitle;
        private Panel panelSubHeaderSuasPreferencias;
        private Label lblEstudanteEmailTitle;
        private Label label2;
        private Label label3;
        private Label label1;
        private PictureBox pcbUser;
        private CustomButton btnEditarUsuario;
        private DataGridView dgvMensagens;
        private Panel panelHeaderMensagem;
        private Label lblEnviarMensagemAoAtualizarNotaTitle;
        private CustomButton btnAdicionarMensagem;
        private CustomButton btnEditarMensagem;
        private CustomButton btnExcluirMensagem;
        private Panel panelCRUD;
        private CustomButton btnSalvarAtualizar;
        private Label lblMensagemTitle;
        private RichTextBox rtxtMensagemCustomizada;
        private Label lblAtualizarPorEmail;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorEmail;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorWhatsapp;
        private Panel panelSubHeaderPreferencias;
        private Label lblCRUDTitle;
        private CustomMaskedTextBox txtmWhatsapp;
        private CustomTextBox txtEmail;
        private PictureBox pcbEmail;
        private PictureBox pcbWhatsapp;
        private Label lblWhatsapp;
        private Label lblEmail;
        private Label lblNenhumResultado;
        private CustomTextBox txtNome;
        private PictureBox pcbNome;
        private Label lblNome;
    }
}
