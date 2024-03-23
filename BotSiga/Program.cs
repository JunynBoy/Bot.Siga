using Bot.Siga;

BotSiga siga = new BotSiga(idEstudante: 1);

List<string> acoes = new List<string>();
acoes.Add("COLETAR_NOTAS");

siga.ColetarDados(acoes);