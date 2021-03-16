using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDGV
{
    public partial class Frm1 :  System.Windows.Forms.UserControl
    {
        public DataTable table = new DataTable();
        public Frm1()
        {
            InitializeComponent();
         
            table.Columns.Add(new DataColumn("asd1"));
            table.Columns.Add(new DataColumn("asd2"));
            DataRow row = table.Rows.Add();
            row[0] = "dsa";
            row[1] = "dsa2";

            row = table.Rows.Add();
            row[0] = "dsa";
            row[1] = "dsa2";


            row = table.Rows.Add();
            row[0] = "dsa";
            row[1] = "dsa2";


            row = table.Rows.Add();
            row[0] = "dsa";
            row[1] = "dsa2";
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string expression = "asd1 LIKE '"+textBox1.Text+"%'";
            table.DefaultView.RowFilter = expression;
            dataGridView1.DataSource = table;

        }
    }
}
