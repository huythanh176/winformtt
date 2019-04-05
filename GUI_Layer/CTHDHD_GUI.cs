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
    public partial class CTHDHD_GUI : Form
    {
        public CTHDHD_GUI()
        {
            InitializeComponent();
        }
        HOADON_BLL hdbll = new HOADON_BLL();
        NHANVIEN_BLL nvbll = new NHANVIEN_BLL();
        KHACHHANG_BLL khbll = new KHACHHANG_BLL();
        HangHoa_BLL hhbll = new HangHoa_BLL();
        LOAIHANG_BLL lhbll = new LOAIHANG_BLL();
        private void CTHDHD_GUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdbll.hoadon_select_secle();
            comboBox1.DataSource = lhbll.lh_select();
            comboBox1.ValueMember = "MaLoaiHang";

            comboBox1.DisplayMember = "TenLoaiHang";
        }
        public void HienThi()
        {
            dataGridView1.DataSource = hdbll.hoadon_select_secle();
            comboBox1.DataSource = lhbll.lh_select();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            dateTimePicker1.Value =(DateTime) row.Cells[1].Value;
            comboBox3.Text = row.Cells[3].Value.ToString();
            comboBox4.Text = row.Cells[2].Value.ToString();
            dt = cthdbll.CTHD_select_secle(row.Cells[0].Value.ToString());

            dataGridView2.Rows.Clear();
            int sum = 0;
            foreach (DataRow rows in dt.Rows )
            {
                dataGridView2.Rows.Add(rows.ItemArray);
                sum += int.Parse(rows.ItemArray[2].ToString()) * int.Parse(rows.ItemArray[4].ToString());
            }
            label11.Text = Convert.ToString(sum);
            
          
            
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = comboBox1.SelectedValue.ToString();
            comboBox2.DataSource = hhbll.hanghoa_select_codk_mlh(s);
            comboBox2.DisplayMember = "TenHang";
            comboBox2.ValueMember = "MaHang";


        }
        DataTable dt;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            dt = hhbll.hanghoa_select_codk(comboBox2.SelectedValue.ToString());
            textBox5.Text = dt.Rows[0][2].ToString();
            textBox6.Text = dt.Rows[0][3].ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt = hhbll.hanghoa_select();
            ErrorProvider errorProvider = new ErrorProvider();
            if (int.Parse(textBox2.Text) < 0) {  errorProvider.SetError(textBox2, "So luong khong duoc nho hon 0"); return; }
            if (int.Parse(textBox2.Text) > int.Parse(dt.Rows[0][4].ToString())) { errorProvider.SetError(textBox2, "So luong con khong du"); return; }
            string[] row = new string[] { comboBox1.Text, comboBox2.Text, textBox2.Text, textBox5.Text, textBox6.Text,comboBox2.SelectedValue.ToString() };
            foreach(DataGridViewRow rows in dataGridView2.Rows)
            {
                if (dataGridView2.Rows.Count == 1) break;
                if (rows.Cells[1].Value == null) continue;
                if (comboBox2.Text == rows.Cells[1].Value.ToString())
                {
                    rows.Cells[2].Value = int.Parse(rows.Cells[2].Value.ToString())+int.Parse(textBox2.Text);
                    return;
                }
            }
            dataGridView2.Rows.Add(row);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.DataSource = nvbll.nv_select();
            comboBox3.ValueMember = "MaNV";
            comboBox3.DisplayMember = "TenNV";

            comboBox4.DataSource = khbll.kh_select();
            comboBox4.ValueMember = "MaKH";
            comboBox4.DisplayMember = "TenKH";
            dt = hdbll.hoadon_select();
            int a = int.Parse(dt.Rows.Count.ToString()) + 1;
            textBox1.Text = "HD" + a;
           

        }
        CTHD_BLL cthdbll = new CTHD_BLL();
        private void button2_Click(object sender, EventArgs e)
        {
            dt = hhbll.hanghoa_select();
            hdbll.hoadon_insert(textBox1.Text.ToString(), dateTimePicker1.Value, comboBox3.SelectedValue.ToString(), comboBox4.SelectedValue.ToString());
            foreach (DataGridViewRow rows in dataGridView2.Rows)
            {
                if (rows.Cells[5].Value == null) continue;
                cthdbll.CTHD_insert(textBox1.Text.ToString(), rows.Cells[5].Value.ToString(), int.Parse(rows.Cells[2].Value.ToString()));
                hhbll.hh_update(rows.Cells[5].Value.ToString(), int.Parse(dt.Rows[0][4].ToString())-int.Parse(rows.Cells[2].Value.ToString()));
            }
            MessageBox.Show("Them Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
            dataGridView2.Rows.Clear();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
            textBox6.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[0].Value.ToString();
            comboBox2.Text = row.Cells[1].Value.ToString();
        }
    }
}
