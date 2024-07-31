namespace GestionNotas
{
    partial class ACEstudiante
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
            nombreuser = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // nombreuser
            // 
            nombreuser.AutoSize = true;
            nombreuser.BackColor = System.Drawing.Color.DarkSlateBlue;
            nombreuser.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nombreuser.ForeColor = System.Drawing.SystemColors.Control;
            nombreuser.Location = new System.Drawing.Point(12, 18);
            nombreuser.Name = "nombreuser";
            nombreuser.Size = new System.Drawing.Size(546, 40);
            nombreuser.TabIndex = 3;
            nombreuser.Text = "Asignar Calificaciones a Estudiantes";
            // 
            // ACEstudiante
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1027, 522);
            Controls.Add(nombreuser);
            Name = "ACEstudiante";
            Text = "ACEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nombreuser;
    }
}