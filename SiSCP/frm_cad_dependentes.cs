using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siscp.DAL;

namespace SiSCP
{
    public partial class frm_cad_dependentes : Form
    {
        public frm_cad_dependentes()
        {
            InitializeComponent();
        }

        private void table_dependDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_cad_dependentes_Load(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void nome_dependLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_titular_dependComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_dependBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.table_dependBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Titular gravado com sucesso!");
        }

        private void desc_parentescoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_parentescoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void id_parentesco_dependComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.table_dependBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Titular gravado com sucesso!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void table_dependBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void nasc_dependLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
