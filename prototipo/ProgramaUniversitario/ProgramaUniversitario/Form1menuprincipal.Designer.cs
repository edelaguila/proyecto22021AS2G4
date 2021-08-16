
namespace ProgramaUniversitario
{
    partial class Form1menuprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCatedratico = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kollektif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(322, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrar como:";
            // 
            // btnCatedratico
            // 
            this.btnCatedratico.BackColor = System.Drawing.Color.White;
            this.btnCatedratico.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnCatedratico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatedratico.FlatAppearance.BorderSize = 0;
            this.btnCatedratico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatedratico.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCatedratico.Location = new System.Drawing.Point(343, 331);
            this.btnCatedratico.Name = "btnCatedratico";
            this.btnCatedratico.Size = new System.Drawing.Size(115, 37);
            this.btnCatedratico.TabIndex = 4;
            this.btnCatedratico.Text = "Catedratico";
            this.btnCatedratico.UseVisualStyleBackColor = false;
            this.btnCatedratico.Click += new System.EventHandler(this.btnCatedratico_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.White;
            this.btnEstudiante.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEstudiante.Location = new System.Drawing.Point(343, 384);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(115, 37);
            this.btnEstudiante.TabIndex = 5;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.Color.White;
            this.btnAdministrador.BackgroundImage = global::ProgramaUniversitario.Properties.Resources.Boton2;
            this.btnAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdministrador.Location = new System.Drawing.Point(343, 278);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(115, 37);
            this.btnAdministrador.TabIndex = 3;
            this.btnAdministrador.Text = "Administracion";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramaUniversitario.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(325, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 468);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnCatedratico);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1menuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎓 | Programa Universidad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnCatedratico;
        private System.Windows.Forms.Button btnEstudiante;
    }
}

