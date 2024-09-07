using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1Prb4
{
    public partial class addForm : Form
    {
        public int returnOrderNum { get; set; }
        public string returnName { get; set; }
        public addForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            returnOrderNum = Int32.Parse(orderNumTextBox.Text);
            returnName = nameTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
