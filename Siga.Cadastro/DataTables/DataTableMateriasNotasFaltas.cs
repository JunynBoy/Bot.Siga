using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.App.DataTables
{
    public partial class DataTableMateriasNotasFaltas : DataTable
    {
        public IList<Materia> Itens { get; private set; } = new List<Materia>();

        public DataTableMateriasNotasFaltas()
        {
            DefineColumns();
        }

        private void DefineColumns()
        {
            Columns.Add("Id");
            Columns.Add("NOME");
            Columns.Add("PROFESSOR");
            Columns.Add("P1");
            Columns.Add("P2");
            Columns.Add("P3");
            Columns.Add("AUSÊNCIAS");
            Columns.Add("MAX. AUSÊNCIAS");

            foreach (DataColumn column in Columns)
            {
                column.ReadOnly = true;
            }
        }

        public void AddItems(IList<Materia> list)
        {
            foreach (Materia item in list)
                Itens.Add(item);
            UpdateList();
        }

        public void SetItens(IList<Materia> list)
        {
            Itens = list;
            UpdateList();
        }

        public void UpdateList()
        {
            Rows.Clear();

            foreach (Materia item in Itens)
            {
                if (item != null)
                {
                    Rows.Add(new object[] {
                    item.Id.ToString(),
                    item.Nome ?? "-",
                    item.Professor ?? "-",
                    item.Notas?.P1?.ToString() ?? "-",
                    item.Notas?.P2?.ToString() ?? "-",
                    item.Notas?.P3?.ToString() ?? "-",
                    item.Faltas?.Ausencias?.ToString() ?? "-",
                    item.Faltas?.MaximoAusencia?.ToString() ?? "-",
            });
                }
            }
        }
        
        public Materia GetItemSelected(int rowSelected)
        {
            if (rowSelected >= 0 && rowSelected < Itens.Count)
                return Itens[rowSelected];
            return null; 
        }

        public int GetSize()
        {
            return Rows.Count;
        }

        public Materia GetItemById(int value)
        {
            return Itens.FirstOrDefault(i => i.Id == value);
        }


    }
}
