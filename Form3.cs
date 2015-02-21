using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamOutliers
{
    public partial class Form3 : Form
    {
       private Form previousForm;

        public Form3(Form form)
        {
            previousForm = form;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for entering your information!");
            this.Close();
        }
    }
}
