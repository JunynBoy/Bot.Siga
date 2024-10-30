using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Model.Enum;
using Bot.Siga;

IniciadorColeta coletor = new IniciadorColeta();

List<EnumTipoDeExecucao> acoes = new List<EnumTipoDeExecucao>() 
{
    EnumTipoDeExecucao.COLETAR_NOTA,
};

try
{

    EstudanteService _estudanteService = new EstudanteService();
    Estudante? estudante = _estudanteService.GetById(1);
    if (estudante != null)
    {
        coletor.IniciarColeta(estudante, acoes, false);
    }
    else
    {
        StringHelper.ConsoleColoredLog(ConsoleColor.Red, $"Atenção!!!!!!!", $"ERRO: Aluno nao encontrado");

    }
}
catch (Exception e)
{
    StringHelper.ConsoleColoredLog(ConsoleColor.Red, $"Atenção!!!!!!!", $"ERRO: {e.Message}");
}
