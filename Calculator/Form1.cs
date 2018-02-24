using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private String left;
        private String right="";
        private bool init = false;
        private bool writed;
        private String coma;
        private bool lastequal=false;
        private string oper="";
        public Form1()
        {
            InitializeComponent();
            coma = ".";//Convert.ToString(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            b_separator.Text = coma;
        }
        private void addNumber(object sender, EventArgs e){
            if(!writed){
                l_text.Text = "";
            }
            Button button = sender as Button;
                if (button != null){
                    if (l_text.Text == "0"){
                        l_text.Text = button.Text;
                    }
                    else{
                        if (containComa(l_text.Text) && l_text.Text.Length<16)
                        {
                            l_text.Text += button.Text;
                        }
                        else if (!containComa(l_text.Text) && l_text.Text.Length < 15)
                        {
                            l_text.Text += button.Text;
                        }
                    }
                    writed = true;
                    if (lastequal)
                    {
                       left = l_text.Text;
                       init = false;
                    }
                }
                lastequal = false;
               
        }
        private void deleteLastNumber(object sender, EventArgs e){
            if (!lastequal)
            {
                if (l_text.Text.Length > 1)
                {
                    l_text.Text = l_text.Text.Remove(l_text.Text.Length - 1);
                }
                else
                {
                    l_text.Text = "0";
                }
            }

        }
        private void setOperator(object sender, EventArgs e) {

            right = l_text.Text;
            Button button = sender as Button;
           
            if (!init)
            {
                init = true;
                left = l_text.Text;
            }
            else
            {
                if (writed)
                {
                    calculate();
                }
            }
            if (button != null) {
                oper = button.Text;
            }

            writed = false;
            right = l_text.Text;
            lastequal = false;
            
        }


        private void calculate(){
            //CultureInfo.InvariantCulture.NumberFormat
            if (writed&&!lastequal)
            {
                right = l_text.Text;
            }
            
                if (oper == "+")
                {
                    left = (double.Parse(left, CultureInfo.InvariantCulture.NumberFormat) + double.Parse(right, CultureInfo.InvariantCulture.NumberFormat)).ToString();
                }
                else if (oper == "-")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) - double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                else if (oper == "*")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) * double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                else if (oper == "/"&& right!="0")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) / double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                left=left.Replace(",", ".");
                l_text.Text = left;
           

        }

        private void equal(object sender, EventArgs e)
        {
           
            if(!writed)
            {
                left=l_text.Text;
            }

            if (right!="")
            {
                calculate();
                writed = false;
            }
            lastequal = true;
        }

        private void addComa(object sender, EventArgs e)
        {
            if (!containComa(l_text.Text))
            {
                l_text.Text+= coma;
                writed = true;
            }

        }

        private bool containComa(String napis)
        {
            return napis.Contains(coma);       

        }



    }
}
