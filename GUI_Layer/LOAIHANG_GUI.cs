using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace GUI_Layer
{
    public partial class LOAIHANG_GUI : Form
    {
        public LOAIHANG_GUI()
        {
            InitializeComponent();
        }
        LOAIHANG_BLL lhbll = new LOAIHANG_BLL();
        private void LOAIHANG_GUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lhbll.lh_select();
        }

        public void HienThi()
        {
            dataGridView1.DataSource = lhbll.lh_select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lhbll.lh_update(textBox1.Text, textBox2.Text, textBox3.Text);
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lhbll.lh_insert(textBox1.Text, textBox2.Text, textBox3.Text);
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lhbll.lh_delete(textBox1.Text);
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lhbll.lh_select_codk(textBox4.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();


        }
    }
}
