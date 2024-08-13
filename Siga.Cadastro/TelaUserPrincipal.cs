using Bot.Core.Helper;
using Bot.Core.Model;
using Bot.Core.Service;
using System.Text;
using Bot.Siga;


namespace Siga.Cadastro
{
    public partial class TelaUserPrincipal : Form
    {

        private EstudanteService _alunoService;
        private Validacoes _validator;

        public TelaUserPrincipal()
        {

            InitializeComponent();
            this._alunoService = new EstudanteService();
            this._validator = new Validacoes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = _validator.cpfCast(txtCPF.Text);
            string senha = txtSenha.Text;
            string nome = txtNome.Text;


            //verificar se já existe cadastro igual no banco
            Estudante? alunoBanco = _alunoService.GetByCpf(cpf);
            if (alunoBanco != null &&  alunoBanco.Autenticado == true)
            {
               //fazer login
            }

            string confirmaSenha = txtConfirmaSenha.Text;
            string email = txtEmail.Text;
            string whatsapp = txtWhatsapp.Text;
            bool atualizarPorEmail = cbxAtualizarPeloEmail.Checked;
            bool atualizarPorWhatsapp = cbxAtualizarPeloWhatsapp.Checked;
            bool termos = cbxTermos.Checked;

            Estudante aluno = new(nome, senha, email, atualizarPorEmail, cpf, whatsapp, atualizarPorWhatsapp);
            ValidarCadastroPrincipal(cpf, senha, aluno);

        }



        // VALIDAÇÕES DE INPUT -------------------------------------------------

        private void ValidarCadastroPrincipal(string cpf, string senha, Estudante aluno)
        {
            var listaDeProblemas = ValidarCadastroComLista(aluno);
            if (listaDeProblemas.Count > 1)
            {
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine("Seu cadastro não foi efetivado devido aos seguintes problemas:");

                foreach (string problema in listaDeProblemas)
                {
                    mensagem.AppendLine(problema);
                }

                MessageBox.Show(mensagem.ToString(), "Cadastro não efetivado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    OrquestadorSiga botSiga = new OrquestadorSiga(idEstudante: 1);
                    bool autenticado = botSiga.FazerLogin(cpf, senha);
                    if (!autenticado)
                    {
                        throw new Exception("O seu cpf ou senha constam como incorreto no site do SIGA");
                    }
                    else
                    {
                        this._alunoService.Save(aluno);
                        MessageBox.Show("Cadastro efetivado com sucesso!", "Cadastro efetivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains(""))
                    {
                        MessageBox.Show("O Cadastro não foi salvo no banco devido a algum problema de conexão", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show($"Erro: {ex.Message}", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public List<String> ValidarCadastroComLista(Estudante aluno)
        {

            var lista = new List<string>();

            if (aluno.Cpf == "" || aluno.Senha == "" || aluno.Cpf == null || aluno.Senha == null)
            {
                lista.Add("-Existem campos obrigatórios vazios");
            }
            if (aluno.Cpf.Count() != 11)
            {
                lista.Add("-O campo CPF deve conter 11 dígitos");
            }
            if (aluno.Email == "" || aluno.Email == null && aluno.Whatsapp == "" || aluno.Whatsapp == null)
            {
                lista.Add("-Ou o Campo Email ou o Campo whatsapp devem estar preenchidos para uso da aplicação");
            }
            if (aluno.Email != null && !_validator.IsValidEmail(aluno.Email))
            {
                lista.Add("-O formato de Email inserido é inválido");
            }
            if (aluno.AtualizarPorEmail == false && aluno.AtualizarPorWhatsapp == false)
            {
                lista.Add("-Ao menos um dos checkbox de contato deve estar marcado");
            }



            return lista;
        }




        // VALIDAÇÕES DE INPUT -------------------------------------------------

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}

