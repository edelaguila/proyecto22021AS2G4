
namespace ProgramaUniversitario
{
    partial class FormCorreoAlumno
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSiguienteTelefono = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kollektif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(175, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "* Campos Obligatorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kollektif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Llene los siguientes campos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(119, 170);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(193, 20);
            this.txtCorreo.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(38, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Correo : ";
            // 
            // btnSiguienteTelefono
            // 
            this.btnSiguienteTelefono.BackColor = System.Drawing.Color.White;
            this.btnSiguienteTelefono.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnSiguienteTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguienteTelefono.FlatAppearance.BorderSize = 0;
            this.btnSiguienteTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteTelefono.Font = new System.Drawing.Font("DM Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteTelefono.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSiguienteTelefono.Location = new System.Drawing.Point(376, 162);
            this.btnSiguienteTelefono.Name = "btnSiguienteTelefono";
            this.btnSiguienteTelefono.Size = new System.Drawing.Size(115, 37);
            this.btnSiguienteTelefono.TabIndex = 45;
            this.btnSiguienteTelefono.Text = "Siguiente";
            this.btnSiguienteTelefono.UseVisualStyleBackColor = false;
            this.btnSiguienteTelefono.Click += new System.EventHandler(this.btnSiguienteTelefono_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Ayuda;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(464, 256);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(55, 46);
            this.btnAyuda.TabIndex = 31;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // FormCorreoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 314);
            this.Controls.Add(this.btnSiguienteTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCorreoAlumno";
            this.Text = "FormCorreoAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSiguienteTelefono;
    }
}