namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_number1 = new System.Windows.Forms.Button();
            this.b_number2 = new System.Windows.Forms.Button();
            this.b_number3 = new System.Windows.Forms.Button();
            this.b_number4 = new System.Windows.Forms.Button();
            this.b_number5 = new System.Windows.Forms.Button();
            this.b_number6 = new System.Windows.Forms.Button();
            this.b_number7 = new System.Windows.Forms.Button();
            this.b_number8 = new System.Windows.Forms.Button();
            this.b_number9 = new System.Windows.Forms.Button();
            this.b_number0 = new System.Windows.Forms.Button();
            this.b_separator = new System.Windows.Forms.Button();
            this.b_equal = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_multiple = new System.Windows.Forms.Button();
            this.b_divide = new System.Windows.Forms.Button();
            this.b_del = new System.Windows.Forms.Button();
            this.l_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_number1
            // 
            this.b_number1.Location = new System.Drawing.Point(15, 163);
            this.b_number1.Name = "b_number1";
            this.b_number1.Size = new System.Drawing.Size(42, 42);
            this.b_number1.TabIndex = 0;
            this.b_number1.Text = "1";
            this.b_number1.UseVisualStyleBackColor = true;
            this.b_number1.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number2
            // 
            this.b_number2.Location = new System.Drawing.Point(63, 162);
            this.b_number2.Name = "b_number2";
            this.b_number2.Size = new System.Drawing.Size(42, 42);
            this.b_number2.TabIndex = 1;
            this.b_number2.Text = "2";
            this.b_number2.UseVisualStyleBackColor = true;
            this.b_number2.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number3
            // 
            this.b_number3.Location = new System.Drawing.Point(111, 162);
            this.b_number3.Name = "b_number3";
            this.b_number3.Size = new System.Drawing.Size(42, 42);
            this.b_number3.TabIndex = 2;
            this.b_number3.Text = "3";
            this.b_number3.UseVisualStyleBackColor = true;
            this.b_number3.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number4
            // 
            this.b_number4.Location = new System.Drawing.Point(15, 114);
            this.b_number4.Name = "b_number4";
            this.b_number4.Size = new System.Drawing.Size(42, 42);
            this.b_number4.TabIndex = 3;
            this.b_number4.Text = "4";
            this.b_number4.UseVisualStyleBackColor = true;
            this.b_number4.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number5
            // 
            this.b_number5.Location = new System.Drawing.Point(63, 114);
            this.b_number5.Name = "b_number5";
            this.b_number5.Size = new System.Drawing.Size(42, 42);
            this.b_number5.TabIndex = 4;
            this.b_number5.Text = "5";
            this.b_number5.UseVisualStyleBackColor = true;
            this.b_number5.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number6
            // 
            this.b_number6.Location = new System.Drawing.Point(111, 114);
            this.b_number6.Name = "b_number6";
            this.b_number6.Size = new System.Drawing.Size(42, 42);
            this.b_number6.TabIndex = 5;
            this.b_number6.Text = "6";
            this.b_number6.UseVisualStyleBackColor = true;
            this.b_number6.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number7
            // 
            this.b_number7.Location = new System.Drawing.Point(15, 66);
            this.b_number7.Name = "b_number7";
            this.b_number7.Size = new System.Drawing.Size(42, 42);
            this.b_number7.TabIndex = 6;
            this.b_number7.Text = "7";
            this.b_number7.UseVisualStyleBackColor = true;
            this.b_number7.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number8
            // 
            this.b_number8.Location = new System.Drawing.Point(63, 66);
            this.b_number8.Name = "b_number8";
            this.b_number8.Size = new System.Drawing.Size(42, 42);
            this.b_number8.TabIndex = 7;
            this.b_number8.Text = "8";
            this.b_number8.UseVisualStyleBackColor = true;
            this.b_number8.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number9
            // 
            this.b_number9.Location = new System.Drawing.Point(111, 66);
            this.b_number9.Name = "b_number9";
            this.b_number9.Size = new System.Drawing.Size(42, 42);
            this.b_number9.TabIndex = 8;
            this.b_number9.Text = "9";
            this.b_number9.UseVisualStyleBackColor = true;
            this.b_number9.Click += new System.EventHandler(this.addNumber);
            // 
            // b_number0
            // 
            this.b_number0.Location = new System.Drawing.Point(16, 211);
            this.b_number0.Name = "b_number0";
            this.b_number0.Size = new System.Drawing.Size(89, 42);
            this.b_number0.TabIndex = 9;
            this.b_number0.Text = "0";
            this.b_number0.UseVisualStyleBackColor = true;
            this.b_number0.Click += new System.EventHandler(this.addNumber);
            // 
            // b_separator
            // 
            this.b_separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_separator.Location = new System.Drawing.Point(111, 211);
            this.b_separator.Name = "b_separator";
            this.b_separator.Size = new System.Drawing.Size(42, 42);
            this.b_separator.TabIndex = 10;
            this.b_separator.Text = "a";
            this.b_separator.UseVisualStyleBackColor = true;
            this.b_separator.Click += new System.EventHandler(this.addComa);
            // 
            // b_equal
            // 
            this.b_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_equal.Location = new System.Drawing.Point(159, 211);
            this.b_equal.Name = "b_equal";
            this.b_equal.Size = new System.Drawing.Size(89, 42);
            this.b_equal.TabIndex = 11;
            this.b_equal.Text = "=";
            this.b_equal.UseVisualStyleBackColor = true;
            this.b_equal.Click += new System.EventHandler(this.equal);
            // 
            // b_plus
            // 
            this.b_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_plus.Location = new System.Drawing.Point(159, 162);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(89, 42);
            this.b_plus.TabIndex = 12;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = true;
            this.b_plus.Click += new System.EventHandler(this.setOperator);
            // 
            // b_minus
            // 
            this.b_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_minus.Location = new System.Drawing.Point(159, 114);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(42, 42);
            this.b_minus.TabIndex = 13;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = true;
            this.b_minus.Click += new System.EventHandler(this.setOperator);
            // 
            // b_multiple
            // 
            this.b_multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_multiple.Location = new System.Drawing.Point(159, 66);
            this.b_multiple.Name = "b_multiple";
            this.b_multiple.Size = new System.Drawing.Size(42, 42);
            this.b_multiple.TabIndex = 14;
            this.b_multiple.Text = "*";
            this.b_multiple.UseVisualStyleBackColor = true;
            this.b_multiple.Click += new System.EventHandler(this.setOperator);
            // 
            // b_divide
            // 
            this.b_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_divide.Location = new System.Drawing.Point(206, 111);
            this.b_divide.Name = "b_divide";
            this.b_divide.Size = new System.Drawing.Size(42, 42);
            this.b_divide.TabIndex = 15;
            this.b_divide.Text = "/";
            this.b_divide.UseVisualStyleBackColor = true;
            this.b_divide.Click += new System.EventHandler(this.setOperator);
            // 
            // b_del
            // 
            this.b_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_del.Location = new System.Drawing.Point(206, 66);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(42, 42);
            this.b_del.TabIndex = 16;
            this.b_del.Text = "del";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.deleteLastNumber);
            // 
            // l_text
            // 
            this.l_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_text.Location = new System.Drawing.Point(15, 21);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(233, 42);
            this.l_text.TabIndex = 17;
            this.l_text.Text = "0";
            this.l_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 274);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.b_divide);
            this.Controls.Add(this.b_multiple);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.b_plus);
            this.Controls.Add(this.b_equal);
            this.Controls.Add(this.b_separator);
            this.Controls.Add(this.b_number0);
            this.Controls.Add(this.b_number9);
            this.Controls.Add(this.b_number8);
            this.Controls.Add(this.b_number7);
            this.Controls.Add(this.b_number6);
            this.Controls.Add(this.b_number5);
            this.Controls.Add(this.b_number4);
            this.Controls.Add(this.b_number3);
            this.Controls.Add(this.b_number2);
            this.Controls.Add(this.b_number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_number1;
        private System.Windows.Forms.Button b_number2;
        private System.Windows.Forms.Button b_number3;
        private System.Windows.Forms.Button b_number4;
        private System.Windows.Forms.Button b_number5;
        private System.Windows.Forms.Button b_number6;
        private System.Windows.Forms.Button b_number7;
        private System.Windows.Forms.Button b_number8;
        private System.Windows.Forms.Button b_number9;
        private System.Windows.Forms.Button b_number0;
        private System.Windows.Forms.Button b_separator;
        private System.Windows.Forms.Button b_equal;
        private System.Windows.Forms.Button b_plus;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_multiple;
        private System.Windows.Forms.Button b_divide;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Label l_text;
    }
}

