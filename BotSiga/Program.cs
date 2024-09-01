﻿using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Model.Enum;
using Bot.Siga;

ColetorSiga coletor = new ColetorSiga();

List<EnumTipoDeExecucao> acoes = new List<EnumTipoDeExecucao>() 
{
    EnumTipoDeExecucao.COLETAR_NOTA
};






//rotina aqui
try
{

    EstudanteService _estudanteService = new EstudanteService();
    Estudante? estudante = _estudanteService.GetById(1);
    if (estudante != null)
    {
        coletor.IniciarColeta(estudante, acoes);
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
