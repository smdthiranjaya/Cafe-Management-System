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
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btnAddNewitem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        } 
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();

        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
