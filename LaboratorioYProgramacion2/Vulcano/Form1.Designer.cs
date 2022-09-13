namespace Vulcano
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.lblCol1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFtoF = new System.Windows.Forms.TextBox();
            this.txtFtoC = new System.Windows.Forms.TextBox();
            this.txtFtoK = new System.Windows.Forms.TextBox();
            this.lblCol2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRow1 = new System.Windows.Forms.Label();
            this.txtCtoK = new System.Windows.Forms.TextBox();
            this.txtCtoC = new System.Windows.Forms.TextBox();
            this.txtCtoF = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKtoK = new System.Windows.Forms.TextBox();
            this.txtKtoC = new System.Windows.Forms.TextBox();
            this.txtKtoF = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.lblRow2 = new System.Windows.Forms.Label();
            this.lblRow3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(99, 48);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.Size = new System.Drawing.Size(100, 23);
            this.txtFarenheit.TabIndex = 0;
            // 
            // lblCol1
            // 
            this.lblCol1.AutoSize = true;
            this.lblCol1.Location = new System.Drawing.Point(332, 31);
            this.lblCol1.Name = "lblCol1";
            this.lblCol1.Size = new System.Drawing.Size(56, 15);
            this.lblCol1.TabIndex = 1;
            this.lblCol1.Text = "Farenheit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConvertirFarenheit);
            // 
            // txtFtoF
            // 
            this.txtFtoF.Location = new System.Drawing.Point(312, 49);
            this.txtFtoF.Name = "txtFtoF";
            this.txtFtoF.ReadOnly = true;
            this.txtFtoF.Size = new System.Drawing.Size(100, 23);
            this.txtFtoF.TabIndex = 3;
            // 
            // txtFtoC
            // 
            this.txtFtoC.Location = new System.Drawing.Point(432, 49);
            this.txtFtoC.Name = "txtFtoC";
            this.txtFtoC.ReadOnly = true;
            this.txtFtoC.Size = new System.Drawing.Size(100, 23);
            this.txtFtoC.TabIndex = 4;
            // 
            // txtFtoK
            // 
            this.txtFtoK.Location = new System.Drawing.Point(551, 49);
            this.txtFtoK.Name = "txtFtoK";
            this.txtFtoK.ReadOnly = true;
            this.txtFtoK.Size = new System.Drawing.Size(100, 23);
            this.txtFtoK.TabIndex = 5;
            this.txtFtoK.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblCol2
            // 
            this.lblCol2.AutoSize = true;
            this.lblCol2.Location = new System.Drawing.Point(459, 31);
            this.lblCol2.Name = "lblCol2";
            this.lblCol2.Size = new System.Drawing.Size(44, 15);
            this.lblCol2.TabIndex = 6;
            this.lblCol2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kelvin";
            // 
            // lblRow1
            // 
            this.lblRow1.AutoSize = true;
            this.lblRow1.Location = new System.Drawing.Point(29, 52);
            this.lblRow1.Name = "lblRow1";
            this.lblRow1.Size = new System.Drawing.Size(56, 15);
            this.lblRow1.TabIndex = 8;
            this.lblRow1.Text = "Farenheit";
            // 
            // txtCtoK
            // 
            this.txtCtoK.Location = new System.Drawing.Point(551, 87);
            this.txtCtoK.Name = "txtCtoK";
            this.txtCtoK.ReadOnly = true;
            this.txtCtoK.Size = new System.Drawing.Size(100, 23);
            this.txtCtoK.TabIndex = 13;
            // 
            // txtCtoC
            // 
            this.txtCtoC.Location = new System.Drawing.Point(432, 87);
            this.txtCtoC.Name = "txtCtoC";
            this.txtCtoC.ReadOnly = true;
            this.txtCtoC.Size = new System.Drawing.Size(100, 23);
            this.txtCtoC.TabIndex = 12;
            // 
            // txtCtoF
            // 
            this.txtCtoF.Location = new System.Drawing.Point(312, 87);
            this.txtCtoF.Name = "txtCtoF";
            this.txtCtoF.ReadOnly = true;
            this.txtCtoF.Size = new System.Drawing.Size(100, 23);
            this.txtCtoF.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "--->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(99, 86);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsius.TabIndex = 9;
            // 
            // txtKtoK
            // 
            this.txtKtoK.Location = new System.Drawing.Point(551, 128);
            this.txtKtoK.Name = "txtKtoK";
            this.txtKtoK.ReadOnly = true;
            this.txtKtoK.Size = new System.Drawing.Size(100, 23);
            this.txtKtoK.TabIndex = 18;
            // 
            // txtKtoC
            // 
            this.txtKtoC.Location = new System.Drawing.Point(432, 128);
            this.txtKtoC.Name = "txtKtoC";
            this.txtKtoC.ReadOnly = true;
            this.txtKtoC.Size = new System.Drawing.Size(100, 23);
            this.txtKtoC.TabIndex = 17;
            // 
            // txtKtoF
            // 
            this.txtKtoF.Location = new System.Drawing.Point(312, 128);
            this.txtKtoF.Name = "txtKtoF";
            this.txtKtoF.ReadOnly = true;
            this.txtKtoF.Size = new System.Drawing.Size(100, 23);
            this.txtKtoF.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "--->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(99, 127);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvin.TabIndex = 14;
            // 
            // lblRow2
            // 
            this.lblRow2.AutoSize = true;
            this.lblRow2.Location = new System.Drawing.Point(29, 94);
            this.lblRow2.Name = "lblRow2";
            this.lblRow2.Size = new System.Drawing.Size(44, 15);
            this.lblRow2.TabIndex = 19;
            this.lblRow2.Text = "Celsius";
            // 
            // lblRow3
            // 
            this.lblRow3.AutoSize = true;
            this.lblRow3.Location = new System.Drawing.Point(29, 136);
            this.lblRow3.Name = "lblRow3";
            this.lblRow3.Size = new System.Drawing.Size(39, 15);
            this.lblRow3.TabIndex = 20;
            this.lblRow3.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 190);
            this.Controls.Add(this.lblRow3);
            this.Controls.Add(this.lblRow2);
            this.Controls.Add(this.txtKtoK);
            this.Controls.Add(this.txtKtoC);
            this.Controls.Add(this.txtKtoF);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCtoK);
            this.Controls.Add(this.txtCtoC);
            this.Controls.Add(this.txtCtoF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblRow1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCol2);
            this.Controls.Add(this.txtFtoK);
            this.Controls.Add(this.txtFtoC);
            this.Controls.Add(this.txtFtoF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCol1);
            this.Controls.Add(this.txtFarenheit);
            this.Name = "Form1";
            this.Text = "Conversor de temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFarenheit;
        private Label lblCol1;
        private Button button1;
        private TextBox txtFtoF;
        private TextBox txtFtoC;
        private TextBox txtFtoK;
        private Label lblCol2;
        private Label label3;
        private Label lblRow1;
        private TextBox txtCtoK;
        private TextBox txtCtoC;
        private TextBox txtCtoF;
        private Button button2;
        private TextBox txtCelsius;
        private TextBox txtKtoK;
        private TextBox txtKtoC;
        private TextBox txtKtoF;
        private Button button3;
        private TextBox txtKelvin;
        private Label lblRow2;
        private Label lblRow3;
    }
}