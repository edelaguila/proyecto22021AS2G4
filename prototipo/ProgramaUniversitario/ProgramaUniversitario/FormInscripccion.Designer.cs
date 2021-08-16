
namespace ProgramaUniversitario
{
    partial class FormInscripccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoleta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarnetI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxCarreras = new System.Windows.Forms.ComboBox();
            this.btnGuardarDireccion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Inscripcción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(129, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Llene los siguientes campos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(162, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "* Campos Obligatorios";
            // 
            // txtBoleta
            // 
            this.txtBoleta.Location = new System.Drawing.Point(195, 139);
            this.txtBoleta.Name = "txtBoleta";
            this.txtBoleta.Size = new System.Drawing.Size(193, 20);
            this.txtBoleta.TabIndex = 55;
            this.txtBoleta.TextChanged += new System.EventHandler(this.txtMunicipioAlumno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "No. Boleta";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Carnet:";
            // 
            // txtCarnetI
            // 
            this.txtCarnetI.Location = new System.Drawing.Point(195, 171);
            this.txtCarnetI.Name = "txtCarnetI";
            this.txtCarnetI.Size = new System.Drawing.Size(193, 20);
            this.txtCarnetI.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Carrera a asignarse";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cBoxCarreras
            // 
            this.cBoxCarreras.FormattingEnabled = true;
            this.cBoxCarreras.Items.AddRange(new object[] {
            "1101",
            "2201",
            "2202",
            "2203",
            "3301",
            "3302",
            "4401",
            "5501",
            "5502"});
            this.cBoxCarreras.Location = new System.Drawing.Point(251, 200);
            this.cBoxCarreras.Name = "cBoxCarreras";
            this.cBoxCarreras.Size = new System.Drawing.Size(137, 21);
            this.cBoxCarreras.TabIndex = 60;
            // 
            // btnGuardarDireccion
            // 
            this.btnGuardarDireccion.BackColor = System.Drawing.Color.White;
            this.btnGuardarDireccion.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnGuardarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarDireccion.FlatAppearance.BorderSize = 0;
            this.btnGuardarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDireccion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarDireccion.Location = new System.Drawing.Point(195, 288);
            this.btnGuardarDireccion.Name = "btnGuardarDireccion";
            this.btnGuardarDireccion.Size = new System.Drawing.Size(115, 37);
            this.btnGuardarDireccion.TabIndex = 61;
            this.btnGuardarDireccion.Text = "Guardar";
            this.btnGuardarDireccion.UseVisualStyleBackColor = false;
            this.btnGuardarDireccion.Click += new System.EventHandler(this.btnGuardarDireccion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Ayuda;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(433, 337);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(38, 34);
            this.btnAyuda.TabIndex = 62;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(107, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(107, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(107, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Fecha:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(195, 232);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(193, 20);
            this.txtfecha.TabIndex = 67;
            // 
            // FormInscripccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 383);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnGuardarDireccion);
            this.Controls.Add(this.cBoxCarreras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCarnetI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoleta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInscripccion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoleta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarnetI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxCarreras;
        private System.Windows.Forms.Button btnGuardarDireccion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfecha;
    }
}