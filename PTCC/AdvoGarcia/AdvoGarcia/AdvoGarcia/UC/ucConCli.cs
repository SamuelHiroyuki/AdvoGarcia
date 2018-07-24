using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Entidades;
using AdvoGarcia.DAO;
using AdvoGarcia.Telas;

namespace AdvoGarcia.UC
{
    public partial class ucConCli : UserControl
    {
        EntidadesContext contexto = new EntidadesContext();
        Advogado aaa;

        public ucConCli(Advogado aa)
        {
            this.aaa = aa;
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" select cli;
            dataGridView1.DataSource = buscaA.ToList();
            dataGridView1.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Equals(string.Empty))
            {
                var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" select cli;
                dataGridView1.DataSource = buscaA.ToList();
                dataGridView1.ClearSelection();
            }
            else
            {
                var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" && cli.Nome.Contains(txtNome.Text) select cli;
                dataGridView1.DataSource = buscaA.ToList();
                dataGridView1.ClearSelection();
            }
        }
    }
}
