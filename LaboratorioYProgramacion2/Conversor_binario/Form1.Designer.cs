namespace Conversor_binario
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
            this.txtDtoB = new System.Windows.Forms.Label();
            this.txtInputDtoB = new System.Windows.Forms.TextBox();
            this.btnDtoB = new System.Windows.Forms.Button();
            this.txtResultDtoB = new System.Windows.Forms.TextBox();
            this.txtResultBtoD = new System.Windows.Forms.TextBox();
            this.btnBtoD = new System.Windows.Forms.Button();
            this.txtInputBtoD = new System.Windows.Forms.TextBox();
            this.txtBtoD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDtoB
            // 
            this.txtDtoB.AutoSize = true;
            this.txtDtoB.Location = new System.Drawing.Point(12, 43);
            this.txtDtoB.Name = "txtDtoB";
            this.txtDtoB.Size = new System.Drawing.Size(99, 15);
            this.txtDtoB.TabIndex = 0;
            this.txtDtoB.Text = "Decimal a Binario";
            // 
            // txtInputDtoB
            // 
            this.txtInputDtoB.Location = new System.Drawing.Point(117, 39);
            this.txtInputDtoB.Name = "txtInputDtoB";
            this.txtInputDtoB.Size = new System.Drawing.Size(100, 23);
            this.txtInputDtoB.TabIndex = 1;
            // 
            // btnDtoB
            // 
            this.btnDtoB.Location = new System.Drawing.Point(223, 39);
            this.btnDtoB.Name = "btnDtoB";
            this.btnDtoB.Size = new System.Drawing.Size(75, 23);
            this.btnDtoB.TabIndex = 2;
            this.btnDtoB.Text = "--->";
            this.btnDtoB.UseVisualStyleBackColor = true;
            this.btnDtoB.Click += new System.EventHandler(this.btnDtoB_Click);
            // 
            // txtResultDtoB
            // 
            this.txtResultDtoB.AcceptsReturn = true;
            this.txtResultDtoB.Location = new System.Drawing.Point(304, 39);
            this.txtResultDtoB.Name = "txtResultDtoB";
            this.txtResultDtoB.Size = new System.Drawing.Size(100, 23);
            this.txtResultDtoB.TabIndex = 3;
            // 
            // txtResultBtoD
            // 
            this.txtResultBtoD.AcceptsReturn = true;
            this.txtResultBtoD.Location = new System.Drawing.Point(304, 82);
            this.txtResultBtoD.Name = "txtResultBtoD";
            this.txtResultBtoD.Size = new System.Drawing.Size(100, 23);
            this.txtResultBtoD.TabIndex = 7;
            this.txtResultBtoD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBtoD
            // 
            this.btnBtoD.Location = new System.Drawing.Point(223, 82);
            this.btnBtoD.Name = "btnBtoD";
            this.btnBtoD.Size = new System.Drawing.Size(75, 23);
            this.btnBtoD.TabIndex = 6;
            this.btnBtoD.Text = "--->";
            this.btnBtoD.UseVisualStyleBackColor = true;
            this.btnBtoD.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputBtoD
            // 
            this.txtInputBtoD.Location = new System.Drawing.Point(117, 82);
            this.txtInputBtoD.Name = "txtInputBtoD";
            this.txtInputBtoD.Size = new System.Drawing.Size(100, 23);
            this.txtInputBtoD.TabIndex = 5;
            this.txtInputBtoD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBtoD
            // 
            this.txtBtoD.AutoSize = true;
            this.txtBtoD.Location = new System.Drawing.Point(12, 86);
            this.txtBtoD.Name = "txtBtoD";
            this.txtBtoD.Size = new System.Drawing.Size(99, 15);
            this.txtBtoD.TabIndex = 4;
            this.txtBtoD.Text = "Binario a Decimal";
            this.txtBtoD.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 151);
            this.Controls.Add(this.txtResultBtoD);
            this.Controls.Add(this.btnBtoD);
            this.Controls.Add(this.txtInputBtoD);
            this.Controls.Add(this.txtBtoD);
            this.Controls.Add(this.txtResultDtoB);
            this.Controls.Add(this.btnDtoB);
            this.Controls.Add(this.txtInputDtoB);
            this.Controls.Add(this.txtDtoB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtDtoB;
        private TextBox txtInputDtoB;
        private Button btnDtoB;
        private TextBox txtResultDtoB;
        private TextBox txtResultBtoD;
        private Button btnBtoD;
        private TextBox txtInputBtoD;
        private Label txtBtoD;
    }
}