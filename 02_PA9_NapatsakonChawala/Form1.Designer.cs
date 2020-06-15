namespace _02_PA9_NapatsakonChawala
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
            this.Amount = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.Label();
            this.Converted = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(119, 65);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.Location = new System.Drawing.Point(119, 142);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(88, 13);
            this.Currency.TabIndex = 1;
            this.Currency.Text = "Select Currency :";
            // 
            // Converted
            // 
            this.Converted.AutoSize = true;
            this.Converted.Location = new System.Drawing.Point(112, 264);
            this.Converted.Name = "Converted";
            this.Converted.Size = new System.Drawing.Size(95, 13);
            this.Converted.TabIndex = 2;
            this.Converted.Text = "Converted Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(253, 65);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(161, 20);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(253, 257);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(161, 20);
            this.txt_Converted.TabIndex = 4;
            this.txt_Converted.TextChanged += new System.EventHandler(this.txt_Converted_TextChanged);
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(253, 142);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(75, 17);
            this.rb_US.TabIndex = 5;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollars";
            this.rb_US.UseVisualStyleBackColor = true;
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(253, 175);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 6;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(420, 113);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(127, 74);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(420, 229);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 74);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.Converted);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Currency;
        private System.Windows.Forms.Label Converted;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
    }
}

