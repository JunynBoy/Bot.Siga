using Bot.Core.src.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Siga.src.ColetaModular.Interface
{
    public class EstrategiaColeta
    {
        private readonly Dictionary<EnumTipoDeExecucao, IColetaModular> _estrategias;

        public EstrategiaColeta()
        {
            _estrategias = new Dictionary<EnumTipoDeExecucao, IColetaModular>
            {
                { EnumTipoDeExecucao.COLETAR_NOTA, new ColetorNotas() },
                { EnumTipoDeExecucao.COLETAR_FALTA, new ColetorFaltas() },
                { EnumTipoDeExecucao.COLETAR_MATERIA, new ColetorMaterias() },

            };
        }

        public IColetaModular ObterEstrategia(EnumTipoDeExecucao tipoDeExecucao)
        {
            if (_estrategias.TryGetValue(tipoDeExecucao, out var estrategia))
            {
                return estrategia;
            }
            throw new ArgumentException("Tipo de execução não suportado.", nameof(tipoDeExecucao));
        }
    }
}
