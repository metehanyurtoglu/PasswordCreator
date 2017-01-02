using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PasswordCreator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btnSaveSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewPassword.SelectedRows)
            {
                dataGridViewPassword.Rows.RemoveAt(item.Index);
            }
        }
    }
}
