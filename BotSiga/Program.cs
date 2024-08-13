using Bot.Core.src.Model.Enum;
using Bot.Siga;

ColetorSiga coletor = new ColetorSiga();

List<EnumTipoDeExecucao> acoes = new List<EnumTipoDeExecucao>() 
{
    EnumTipoDeExecucao.COLETAR_NOTA
};

coletor.IniciarColeta(1, acoes);