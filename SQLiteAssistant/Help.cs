using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLiteAssistant
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.CancelButton = btnOk;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}