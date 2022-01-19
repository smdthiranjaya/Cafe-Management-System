using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.AllUserControl
{
    public partial class UC_Update : UserControl
    {
        function fn = new function();
        String query;

        public UC_Update()
        {
            InitializeComponent();
        }

        private void UC_Update_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from items"; ;
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());


            txtitemName.Text = name;
            txtcategory.Text = category;
            txtprice.Text = price.ToString();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            query = "update items set name ='" + txtitemName.Text + "',category='" + txtcategory.Text + "',price=" + txtprice.Text + " where id =" + id + "";
            fn.setData(query);
            loadData();

            txtitemName.Clear();
            txtcategory.Clear();
            txtprice.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
