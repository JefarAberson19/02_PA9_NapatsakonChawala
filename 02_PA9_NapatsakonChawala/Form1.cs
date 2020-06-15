using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_PA9_NapatsakonChawala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (rb_US.Checked == false)
                if (rb_Yen.Checked == false)
                    label4.Text = "Choose anyone of the currency.";

            if (rb_US.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 0.74M;
                    txt_Converted.Text = "$" + converted_amount.ToString();
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    label4.Text = "Invalid Input.";
                }
            }
            else if (rb_Yen.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 81.97M;
                    txt_Converted.Text = "Y" + converted_amount.ToString();
                    label4.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    label4.Text = "Invalid Input.";
                }
            }
            else if (rb_MYR.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 3.01M;
                    txt_Converted.Text = "MYR" + converted_amount.ToString();
                    label4.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    label4.Text = "Invalid Input.";
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();

        }

        private void rb_MYR_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
