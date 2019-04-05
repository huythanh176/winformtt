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
    public partial class NHANVIEN_GUI : Form
    {
        public NHANVIEN_GUI()
        {
            InitializeComponent();
        }
        NHANVIEN_BLL nvbll = new NHANVIEN_BLL();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nvbll.nv_select_codk(textBox8.Text);
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NHANVIEN_GUI_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = nvbll.nv_select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = (bool)row.Cells[3].Value == false ? "Nu" : "Nam";
            textBox5.Text = row.Cells[1].Value.ToString();
            textBox6.Text =  row.Cells[4].Value.ToString();
            dateTimePicker2.Value = (DateTime)row.Cells[2].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nvbll.nv_insert(textBox2.Text, textBox5.Text, dateTimePicker2.Value, textBox3.Text == "Nam" ? true :false, textBox6.Text);
            HienThi();
        }
        public void HienThi()
        {
            dataGridView1.DataSource = nvbll.nv_select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nvbll.nv_update(textBox2.Text, textBox5.Text, dateTimePicker2.Value, textBox3.Text == "Nam" ? true : false, textBox6.Text);
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nvbll.nv_delete(textBox2.Text);
            HienThi();
        }
    }
}
