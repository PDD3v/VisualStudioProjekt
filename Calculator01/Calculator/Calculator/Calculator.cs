using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Calculator : Form
    {

        private string _firstValue;
        private string _secondValue;
        private string _operation;
                      
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

            if (_operation=="+" || _operation=="-" || _operation=="*" || _operation=="/")
            {
                _secondValue += clickedValue;
            }

        }

        private void OnButtonOperation(object sender, EventArgs e)
        {
            _firstValue = Result.Text;
            var clickedOperation = (sender as Button).Text;

            _operation = clickedOperation;

            Result.Text += $" {clickedOperation} ";


            if (_operation=="^2")
            {
                _secondValue = _firstValue;
            }
           


        }

        private void OnButtonResult(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);

            if (_operation == "+")
            {
                var result = firstNumber + secondNumber;
                Result.Text = result.ToString();
                
            }

            if (_operation == "-")
            {
                var result = firstNumber - secondNumber;
                Result.Text = result.ToString();

            }
            if (_operation == "*")
            {
                var result = firstNumber * secondNumber;
                Result.Text = result.ToString();

            }
            if (_operation == "/")
            {
                if (secondNumber==0)
                {
                    Result.Text="NaN";
                }
                    var result = firstNumber / secondNumber;
                    Result.Text = result.ToString();
                
            }
            if (_operation == "^2")
            {
                var result = firstNumber * secondNumber;
                Result.Text = result.ToString();

            }

            _operation = string.Empty;
            _secondValue = string.Empty;
          
        }

        private void OnButtonClear(object sender, EventArgs e)
        {
            Result.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _operation = string.Empty;
        }
    }
}
