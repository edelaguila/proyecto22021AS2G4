
namespace ProgramaUniversitario
{
    partial class FormDireccionAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMunicipioAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDepartamentoAlumno = new System.Windows.Forms.ListBox();
            this.txtCodigoPostalAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnGuardarDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kollektif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(298, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "* Campos Obligatorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kollektif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Llene los siguientes campos";
            // 
            // txtMunicipioAlumno
            // 
            this.txtMunicipioAlumno.Location = new System.Drawing.Point(548, 212);
            this.txtMunicipioAlumno.Name = "txtMunicipioAlumno";
            this.txtMunicipioAlumno.Size = new System.Drawing.Size(193, 20);
            this.txtMunicipioAlumno.TabIndex = 54;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(229, 156);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(512, 20);
            this.txtDireccionAlumno.TabIndex = 53;
            this.txtDireccionAlumno.TextChanged += new System.EventHandler(this.txtNombreAlumno_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(72, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(72, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(442, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Dirección Completa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Departamento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Municipio :";
            // 
            // lstDepartamentoAlumno
            // 
            this.lstDepartamentoAlumno.FormattingEnabled = true;
            this.lstDepartamentoAlumno.Items.AddRange(new object[] {
            "Alta Verapaz",
            "Baja Verapaz",
            "Chimaltenango",
            "Chiquimula",
            "Escuintla",
            "Guatemala",
            "Huehuetenango",
            "Izabal",
            "Jalapa",
            "Jutiapa",
            "Petén",
            "El Progreso",
            "Quetzaltenango\t",
            "Quiché",
            "Retalhuleu",
            "Sacatepéquez",
            "San Marcos",
            "Santa Rosa",
            "Sololá",
            "Suchitepéquez",
            "Totonicapán",
            "Zacapa"});
            this.lstDepartamentoAlumno.Location = new System.Drawing.Point(206, 209);
            this.lstDepartamentoAlumno.Name = "lstDepartamentoAlumno";
            this.lstDepartamentoAlumno.Size = new System.Drawing.Size(164, 82);
            this.lstDepartamentoAlumno.TabIndex = 55;
            // 
            // txtCodigoPostalAlumno
            // 
            this.txtCodigoPostalAlumno.Location = new System.Drawing.Point(577, 271);
            this.txtCodigoPostalAlumno.Name = "txtCodigoPostalAlumno";
            this.txtCodigoPostalAlumno.Size = new System.Drawing.Size(164, 20);
            this.txtCodigoPostalAlumno.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(442, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Código Postal :";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Ayuda;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(717, 382);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(55, 46);
            this.btnAyuda.TabIndex = 59;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDireccion
            // 
            this.btnGuardarDireccion.BackColor = System.Drawing.Color.White;
            this.btnGuardarDireccion.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnGuardarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarDireccion.FlatAppearance.BorderSize = 0;
            this.btnGuardarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDireccion.Font = new System.Drawing.Font("DM Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDireccion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarDireccion.Location = new System.Drawing.Point(363, 335);
            this.btnGuardarDireccion.Name = "btnGuardarDireccion";
            this.btnGuardarDireccion.Size = new System.Drawing.Size(115, 37);
            this.btnGuardarDireccion.TabIndex = 60;
            this.btnGuardarDireccion.Text = "Guardar";
            this.btnGuardarDireccion.UseVisualStyleBackColor = false;
            this.btnGuardarDireccion.Click += new System.EventHandler(this.btnGuardarDireccion_Click);
            // 
            // FormDireccionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarDireccion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.txtCodigoPostalAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstDepartamentoAlumno);
            this.Controls.Add(this.txtMunicipioAlumno);
            this.Controls.Add(this.txtDireccionAlumno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDireccionAlumno";
            this.Text = "FormDireccionAlumno";
            this.Load += new System.EventHandler(this.FormDireccionAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMunicipioAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDepartamentoAlumno;
        private System.Windows.Forms.TextBox txtCodigoPostalAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnGuardarDireccion;
    }
}