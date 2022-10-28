using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Result.Text ="0";
        }
      
        private void OnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (Result.Text == "0")
                Result.Text = String.Empty; 

           Result.Text += clickedValue;
        }

        private void OnButtonOperation(object sender, EventArgs e)
        {

        }

        private void OnButtonResult(object sender, EventArgs e)
        {

        }

        private void OnButtonClear(object sender, EventArgs e)
        {

        }
    }
}
