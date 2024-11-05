using Bot.Core.src.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Bot.App.DataTables
{
    public partial class DataTableMensagens : DataTable
    {
        public IList<Mensagem> Itens { get; private set; } = new List<Mensagem>();

        public DataTableMensagens()
        {
            DefineColumns();
        }

        private void DefineColumns()
        {
            Columns.Add("Id", typeof(int));
            Columns.Add("Nome", typeof(string));
            Columns.Add("Atualizar por Email", typeof(string));
            Columns.Add("Atualizar por Whatsapp", typeof(string));
            Columns.Add("Texto", typeof(string));

            foreach (DataColumn column in Columns)
            {
                column.ReadOnly = true;
            }
        }

        public void AddItems(IList<Mensagem> list)
        {
            foreach (Mensagem item in list)
                Itens.Add(item);
            UpdateList();
        }

        public void SetItens(IList<Mensagem> list)
        {
            Itens = list;
            UpdateList();
        }

        public void UpdateList()
        {
            Rows.Clear();

            foreach (Mensagem item in Itens)
            {
                if (item != null)
                {
                    Rows.Add(new object[] {
                        item.Id,
                        item.Nome ?? "-",
                        item.IsAtualizarPorEmail == true ? "Sim" : "Não", 
                        item.IsAtualizarPorWhatsapp == true ? "Sim" : "Não",
                        item.Texto ?? "-",
                    });
                }
            }
        }

        public Mensagem GetItemSelected(int rowSelected)
        {
            if (rowSelected >= 0 && rowSelected < Itens.Count)
                return Itens[rowSelected];
            return null;
        }

        public int GetSize()
        {
            return Rows.Count;
        }

        public Mensagem GetItemById(int value)
        {
            return Itens.FirstOrDefault(i => i.Id == value);
        }
    }
}
