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
        private bool block = false;
        public Form1()
        {
            InitializeComponent();
            coma = Convert.ToString(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            b_separator.Text = coma;
            setText("0");
        }
        private void addNumber(object sender, EventArgs e){
            if (block) return;
            if(!writed){
                setText( "");
            }
            Button button = sender as Button;
                if (button != null){
                    if (l_text.Text == "0"){
                        setText( button.Text);
                    }
                    else{
                        if (containComa(l_text.Text) && l_text.Text.Length<16)
                        {
                            setText(l_text.Text + button.Text);
                        }
                        else if (!containComa(l_text.Text) && l_text.Text.Length < 15)
                        {
                            setText(l_text.Text + button.Text);
                        }
                    }       
                    if (lastequal)
                    {
                       left = l_text.Text;
                       init = false;
                    }
                }
               // lastequal = false;
                writed = true;
               
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
                    setText( "0");
                }
            }

        }
        private void setOperator(object sender, EventArgs e) {

            if (block) return;
            right = l_text.Text;
            Button button = sender as Button;
            String znakGuzika = "";
            if (button != null)
                znakGuzika = button.Text;

            if (!init)
            {
                init = true;
                left = l_text.Text;
                addTextToUpper(l_text.Text );   
                addTextToUpper(znakGuzika);
               
            }
            else
            {
                if (writed)
                {
                    addTextToUpper(l_text.Text+znakGuzika);
                    calculate();
                }
                else
                {
                    if(lastequal)
                        addTextToUpper(l_text.Text);
                    addTextToUpper(znakGuzika);
                }
                
            }

            
            oper = znakGuzika;          
          



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

            try
            {
                left = left.Replace(coma, ".");
                right = right.Replace(coma, ".");
                if (oper == "+")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) + double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                else if (oper == "-")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) - double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                else if (oper == "*")
                {
                    left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) * double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                else if (oper == "/")
                {
                    if (double.Parse(right, System.Globalization.CultureInfo.InvariantCulture) == 0.0){
                        left = "NIe można dzielic przez 0";
                        block = true;
                        }
                    else 
                        left = (double.Parse(left, System.Globalization.CultureInfo.InvariantCulture) / double.Parse(right, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                }
                left = left.Replace(".",coma);
                right = right.Replace(".",coma);
                setText(left);
            }
            catch
            {
                restart();
            }
           

        }

        private void equal(object sender, EventArgs e)
        {
            if (block) return;

            if (writed && left != ""&&!lastequal)
                right = l_text.Text;
            if(!writed)
            {
                left=l_text.Text;
            }
            else
            {
                lastequal = true;
            }

            if (right!="")            
            {
                
                calculate();
                writed = false;
                
            }
            lastequal = true;
            l_upper.Text = "";
        }

        private void addComa(object sender, EventArgs e)
        {
            if (block) return;
            if (!containComa(l_text.Text)&&writed)
            {
                setText(l_text.Text + coma);
                writed = true;
            }
            else if (!writed)
            {
                setText("0" + coma);
                writed = true;
            }

        }

        private bool containComa(String napis)
        {
            return napis.Contains(coma);       

        }
        private void restart()
        {

            left = "";
            right = "";
            init = false;
            writed = false;
            lastequal = false;
            oper = "";
            setText("0");
            l_upper.Text = "";
            block = false;
        }

        private void clear(object sender, EventArgs e)
        {
            restart();
        }

        private void setText(String text)
        {
            if (text.Length < 22)
            {
                l_text.Font = new Font("Arial", 13);
            }
            else
            {
                l_text.Font = new Font("Arial", 10);
            }

            l_text.Text = text;
        }

        private void addTextToUpper(String napis)
        {
            
            int n=l_upper.Text.Length - 1;
            if(n>=0)
                if ((napis == "+" || napis == "/" || napis == "*" || napis == "-") && (l_upper.Text[n]=='+'||l_upper.Text[n]=='/'||l_upper.Text[n]=='*'||l_upper.Text[n]=='-' ))
                    l_upper.Text = l_upper.Text.Remove(l_upper.Text.Length - 1);
            l_upper.Text += napis;

        }


    }
}
