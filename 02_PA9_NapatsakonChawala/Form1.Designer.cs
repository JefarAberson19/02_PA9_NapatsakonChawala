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
            this.rb_MYR = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(178, 100);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(65, 20);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.Location = new System.Drawing.Point(178, 218);
            this.Currency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(129, 20);
            this.Currency.TabIndex = 1;
            this.Currency.Text = "Select Currency :";
            // 
            // Converted
            // 
            this.Converted.AutoSize = true;
            this.Converted.Location = new System.Drawing.Point(168, 406);
            this.Converted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Converted.Name = "Converted";
            this.Converted.Size = new System.Drawing.Size(142, 20);
            this.Converted.TabIndex = 2;
            this.Converted.Text = "Converted Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(380, 100);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(240, 26);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(380, 395);
            this.txt_Converted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(240, 26);
            this.txt_Converted.TabIndex = 4;
            this.txt_Converted.TextChanged += new System.EventHandler(this.txt_Converted_TextChanged);
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(380, 218);
            this.rb_US.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(110, 24);
            this.rb_US.TabIndex = 5;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollars";
            this.rb_US.UseVisualStyleBackColor = true;
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(380, 269);
            this.rb_Yen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(137, 24);
            this.rb_Yen.TabIndex = 6;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(630, 174);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(190, 114);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(630, 352);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(190, 114);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // rb_MYR
            // 
            this.rb_MYR.AutoSize = true;
            this.rb_MYR.Location = new System.Drawing.Point(379, 314);
            this.rb_MYR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_MYR.Name = "rb_MYR";
            this.rb_MYR.Size = new System.Drawing.Size(149, 24);
            this.rb_MYR.TabIndex = 10;
            this.rb_MYR.TabStop = true;
            this.rb_MYR.Text = "Malaysia Ringgit";
            this.rb_MYR.UseVisualStyleBackColor = true;
            this.rb_MYR.CheckedChanged += new System.EventHandler(this.rb_MYR_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rb_MYR);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.RadioButton rb_MYR;
    }
}

