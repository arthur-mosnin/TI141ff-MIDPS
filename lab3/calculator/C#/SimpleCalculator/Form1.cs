using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        
        
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        txtInput.Text += "1";
                        break;
                    case "btnTwo":
                        txtInput.Text += "2";
                        break;
                    case "btnThree":
                        txtInput.Text += "3";
                        break;
                    case "btnFour":
                        txtInput.Text += "4";
                        break;
                    case "btnFive":
                        txtInput.Text += "5";
                        break;
                    case "btnSix":
                        txtInput.Text += "6";
                        break;
                    case "btnSeven":
                        txtInput.Text += "7";
                        break;
                    case "btnEight":
                        txtInput.Text += "8";
                        break;
                    case "btnNine":
                        txtInput.Text += "9";
                        break;
                    case "btnZero":
                        txtInput.Text += "0";
                        break;
                    case "btnDot":
                        if(!txtInput.Text.Contains("."))
                            txtInput.Text += ".";
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':

                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }           
        }
        
            
        
        
    }
}
