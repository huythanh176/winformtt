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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }
        KHACHHANG_BLL khbll = new KHACHHANG_BLL();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khbll.kh_select();
        }
        public void HienThi()
        {
            dataGridView1.DataSource = khbll.kh_select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khbll.kh_insert(textBox2.Text, textBox5.Text, textBox4.Text, textBox6.Text, textBox3.Text, textBox1.Text);
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            khbll.kh_update(textBox2.Text, textBox5.Text, textBox4.Text, textBox6.Text, textBox3.Text, textBox1.Text);
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            khbll.kh_delete(textBox2.Text);
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khbll.kh_select_codk(textBox8.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox5.Text = row.Cells[1].Value.ToString();
            textBox4.Text = row.Cells[2].Value.ToString();
            textBox6.Text = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            textBox1.Text = row.Cells[5].Value.ToString();
        }
    }
}
