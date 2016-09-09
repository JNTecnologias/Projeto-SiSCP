using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiSCP
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemCadastroTitulares_Click(object sender, EventArgs e)
        {
            frm_cad_titular cadtitular = new frm_cad_titular();
            cadtitular.Show();
        }

        private void itemCadastroDependentes_Click(object sender, EventArgs e)
        {
            frm_cad_dependentes caddependentes = new frm_cad_dependentes();
            caddependentes.Show();
        }

        private void itemCadastroProcedimentos_Click(object sender, EventArgs e)
        {
            frm_tratamento1 tratamento1 = new frm_tratamento1();
            tratamento1.Show();
        }

        private void itemCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void itemExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void itemWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("word");
        }

        private void itemInformaçõesDoSistema_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicação de uso restrido pela empresa" + 
            "LOE | Lara Odontologia Especializada" + "" 
            + "Att, Equipe LOE ", 
                "INFORMAÇÃO",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        
    }
}
