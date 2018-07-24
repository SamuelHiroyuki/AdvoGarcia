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
    public partial class ucConCaso : UserControl
    {
        EntidadesContext contexto = new EntidadesContext();
        Advogado aaa;
        Cliente ccc;

        public ucConCaso(Advogado aa)
        {
            aaa = aa;
            InitializeComponent();
            cboTipoCon.SelectedIndex = cboTipoCon.Items.IndexOf("Meus casos");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            btnPegar.Visible = false;
            chbAnd.Checked = true;
            cboAdv.Visible = false;
            var busca = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" select new { c.ID, c.Status, cli.Nome };
            dataGridView1.DataSource = busca.ToList();
            dataGridView1.ClearSelection();
        }

        public ucConCaso(Cliente cc)
        {
            ccc = cc;
            InitializeComponent();
            cboTipoCon.SelectedIndex = cboTipoCon.Items.IndexOf("Meus casos");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            btnPegar.Text = "Novo caso";
            btnExcluir.Text = "Editar caso";
            chbAnd.Checked = true;
            label1.Visible = false;
            txtNome.Visible = false;
            cboTipoCon.Enabled = false;
            cboAdv.SelectedIndex = cboAdv.Items.IndexOf("Possui advogado");
            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID && c.Status == "Andamento" select new { c.ID, c.Status, a.Nome};
            dataGridView1.DataSource = busca.ToList();
            dataGridView1.ClearSelection();
        }   

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (aaa != null)
            {
                if (cboTipoCon.Text.Equals("Meus casos"))
                {
                    btnPegar.Visible = false;
                    if (chbAnd.Checked == false && chbEnc.Checked == false)
                    {
                        CustomMB.Show("Marque uma opção!", CustomMB.CorFundo.Amarelo);
                    }
                    else
                    {
                        if (chbAnd.Checked && chbEnc.Checked)
                        {
                            if (txtNome.Text.Trim().Equals(string.Empty))
                            {
                                var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID select new { c.ID, c.Status, cli.Nome };
                                dataGridView1.DataSource = buscaA.ToList();
                                dataGridView1.ClearSelection();
                            }
                            else
                            {
                                var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && cli.Nome.Contains(txtNome.Text) select new { c.ID, c.Status, cli.Nome };
                                dataGridView1.DataSource = buscaA.ToList();
                                dataGridView1.ClearSelection();
                            }
                        }
                        else
                        {
                            if (chbAnd.Checked)
                            {
                                if (txtNome.Text.Trim().Equals(string.Empty))
                                {
                                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" select new { c.ID, c.Status, cli.Nome };
                                    dataGridView1.DataSource = buscaA.ToList();
                                    dataGridView1.ClearSelection();
                                }
                                else
                                {
                                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status == "Andamento" && cli.Nome.Contains(txtNome.Text) select new { c.ID, c.Status, cli.Nome };
                                    dataGridView1.DataSource = buscaA.ToList();
                                    dataGridView1.ClearSelection();
                                }
                            }
                            if (chbEnc.Checked)
                            {
                                if (txtNome.Text.Trim().Equals(string.Empty))
                                {
                                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status != "Andamento" select new { c.ID, c.Status, cli.Nome };
                                    dataGridView1.DataSource = buscaA.ToList();
                                    dataGridView1.ClearSelection();
                                }
                                else
                                {
                                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == aaa.ID && c.Status != "Andamento" && cli.Nome.Contains(txtNome.Text) select new { c.ID, c.Status, cli.Nome };
                                    dataGridView1.DataSource = buscaA.ToList();
                                    dataGridView1.ClearSelection();
                                }
                            }
                        }
                    }
                }
                else
                {
                    chbAnd.Checked = false;
                    chbEnc.Checked = false;
                    btnPegar.Visible = true;
                    if (txtNome.Text.Trim().Equals(string.Empty))
                    {
                        var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == null && c.Status == "Andamento" select new { c.ID, c.Status, cli.Nome };
                        dataGridView1.DataSource = buscaA.ToList();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == null && c.Status == "Andamento" && cli.Nome.Contains(txtNome.Text) select new { c.ID, c.Status, cli.Nome };
                        dataGridView1.DataSource = buscaA.ToList();
                        dataGridView1.ClearSelection();
                    }
                }
            }
            else
            {
                if (cboAdv.Text.Equals("Possui advogado"))
                {
                    if (chbAnd.Checked && chbEnc.Checked)
                    {
                        var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID select new { c.ID, c.Status, a.Nome };
                        dataGridView1.DataSource = busca.ToList();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        if (chbAnd.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID && c.Status == "Andamento" select new { c.ID, c.Status, a.Nome };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                        if (chbEnc.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID && c.Status != "Andamento" select new { c.ID, c.Status, a.Nome };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    if (chbAnd.Checked && chbEnc.Checked)
                    {
                        var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null select new { c.ID, c.Status };
                        dataGridView1.DataSource = busca.ToList();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        if (chbAnd.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null && c.Status == "Andamento" select new { c.ID, c.Status };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                        if (chbEnc.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null && c.Status != "Andamento" select new { c.ID, c.Status };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtualC = dataGridView1.CurrentRow;
            int indiceC = linhaAtualC.Index;
            frmPedirCaso frm = new frmPedirCaso((int)dataGridView1.Rows[indiceC].Cells["ID"].Value, true);
            frm.ShowDialog();
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (aaa != null)
            {
                DataGridViewRow linhaAtualC = dataGridView1.CurrentRow;
                int indiceC = linhaAtualC.Index;
                CasoDAO cdao = new CasoDAO();
                Caso cc = cdao.BuscaPorID(Convert.ToInt32(dataGridView1.Rows[indiceC].Cells["ID"].Value));
                cc.AdvogadoID = aaa.ID;
                cdao.Atualizar();
                CustomMB.Show("Caso vinculado.", CustomMB.CorFundo.Verde);
                if (txtNome.Text.Trim().Equals(string.Empty))
                {
                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == null && c.Status == "Andamento" select new { c.ID, c.Status, cli.Nome };
                    dataGridView1.DataSource = buscaA.ToList();
                    dataGridView1.ClearSelection();
                }
                else
                {
                    var buscaA = from cli in contexto.Clientes join c in contexto.Casos on cli.ID equals c.ClienteID where c.AdvogadoID == null && c.Status == "Andamento" && cli.Nome.Contains(txtNome.Text) select new { c.ID, c.Status, cli.Nome };
                    dataGridView1.DataSource = buscaA.ToList();
                    dataGridView1.ClearSelection();
                }
            }
            else
            {
                frmPedirCaso pc = new frmPedirCaso();
                pc.ShowDialog();
                CasoDAO casodao = new CasoDAO();
                Caso caso = new Caso()
                {
                    Status = "Andamento",
                    Descricao = pc.txtCaso.Text,
                    Cliente = ccc
                };
                casodao.Salvar(caso);
                CustomMB.Show("Caso cadastrado!", CustomMB.CorFundo.Verde);
                if (cboAdv.Text.Equals("Possui advogado"))
                {
                    if (chbAnd.Checked && chbEnc.Checked)
                    {
                        var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID select new { c.ID, c.Status, a.Nome };
                        dataGridView1.DataSource = busca.ToList();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        if (chbAnd.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID && c.Status == "Andamento" select new { c.ID, c.Status, a.Nome };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                        if (chbEnc.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID join a in contexto.Advogados on c.AdvogadoID equals a.ID where c.ClienteID == ccc.ID && c.Status != "Andamento" select new { c.ID, c.Status, a.Nome };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    if (chbAnd.Checked && chbEnc.Checked)
                    {
                        var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null select new { c.ID, c.Status };
                        dataGridView1.DataSource = busca.ToList();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        if (chbAnd.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null && c.Status == "Andamento" select new { c.ID, c.Status };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                        if (chbEnc.Checked)
                        {
                            var busca = from c in contexto.Casos join cli in contexto.Clientes on c.ClienteID equals cli.ID where c.ClienteID == ccc.ID && c.AdvogadoID == null && c.Status != "Andamento" select new { c.ID, c.Status };
                            dataGridView1.DataSource = busca.ToList();
                            dataGridView1.ClearSelection();
                        }
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (aaa != null)
            {
                DataGridViewRow linhaAtualC = dataGridView1.CurrentRow;
                int indiceC = linhaAtualC.Index;
                CasoDAO cdao = new CasoDAO();
                Caso cc = cdao.BuscaPorID(Convert.ToInt32(dataGridView1.Rows[indiceC].Cells["ID"].Value));
                frmPedirCaso frm = new frmPedirCaso(cc);
                frm.ShowDialog();
                if (frm.Del)
                {
                    cc.Status = "Encerrado";
                    cdao.Atualizar();
                }
            }
            else
            {
                DataGridViewRow linhaAtualC = dataGridView1.CurrentRow;
                int indiceC = linhaAtualC.Index;
                frmPedirCaso frm = new frmPedirCaso((int)dataGridView1.Rows[indiceC].Cells["ID"].Value, 1, true);
                frm.ShowDialog();
                if (frm.Alt)
                {
                    CustomMB.Show("Caso alterado!", CustomMB.CorFundo.Verde);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.Equals("Andamento"))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Crimson;
                }
            }
        }
    }
}
