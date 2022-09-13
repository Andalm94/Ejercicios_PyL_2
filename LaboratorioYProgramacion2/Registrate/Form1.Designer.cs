namespace Registrate
{
    partial class Registro
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.listPais = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGenero.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";

            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "C";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(4, 30);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(80, 19);
            this.radMasculino.TabIndex = 3;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.radFemenino);
            this.grpGenero.Controls.Add(this.radMasculino);
            this.grpGenero.Location = new System.Drawing.Point(256, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(113, 103);
            this.grpGenero.TabIndex = 4;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(6, 66);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(78, 19);
            this.radFemenino.TabIndex = 4;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            this.radFemenino.CheckedChanged += new System.EventHandler(this.radFemenino_CheckedChanged);
            // 
            // listPais
            // 
            this.listPais.DisplayMember = "Argentina";
            this.listPais.FormattingEnabled = true;
            this.listPais.ItemHeight = 15;
            this.listPais.Items.AddRange(new object[] {
            "Argentina",
            "Paraguay",
            "Uruguay",
            "Chile",
            "Bolivia",
            "Perú",
            "Ecuador",
            "Colombia",
            "Venezuela"});
            this.listPais.Location = new System.Drawing.Point(12, 213);
            this.listPais.Name = "listPais";
            this.listPais.Size = new System.Drawing.Size(227, 94);
            this.listPais.TabIndex = 5;
            this.listPais.Tag = "";
            this.listPais.ValueMember = "Argentina, Uruguay, Chile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numEdad);
            this.groupBox2.Controls.Add(this.lblEdad);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 167);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del usuario";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(95, 103);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(112, 23);
            this.numEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(13, 105);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 65);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(112, 23);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 68);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.checkBox4);
            this.grpCursos.Controls.Add(this.checkBox3);
            this.grpCursos.Controls.Add(this.checkBox2);
            this.grpCursos.Controls.Add(this.checkBox1);
            this.grpCursos.Location = new System.Drawing.Point(256, 121);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(113, 158);
            this.grpCursos.TabIndex = 7;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 117);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Javascript";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "C++";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(41, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "C#";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(256, 284);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(113, 23);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "País";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listPais);
            this.Controls.Add(this.grpGenero);
            this.Name = "Form1";
            this.Text = "Regístrate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private CheckBox checkBox1;
        private RadioButton radMasculino;
        private GroupBox grpGenero;
        private ListBox listPais;
        private GroupBox groupBox2;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private RadioButton radFemenino;
        private NumericUpDown numEdad;
        private Label lblEdad;
        private GroupBox grpCursos;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button btnIngresar;
        private Label label1;
    }
}