namespace HolaMundo
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
            ID = new Label();
            Nombre = new Label();
            Materia = new Label();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.Location = new Point(338, 149);
            ID.Name = "ID";
            ID.Size = new Size(84, 28);
            ID.TabIndex = 0;
            ID.Text = "176220";
            ID.Click += label1_Click;
            // 
            // Nombre
            // 
            Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(251, 190);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(265, 28);
            Nombre.TabIndex = 1;
            Nombre.Text = "Jose Eduardo Zarza Pineda";
            Nombre.Click += label2_Click;
            // 
            // Materia
            // 
            Materia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Materia.AutoSize = true;
            Materia.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Materia.Location = new Point(238, 234);
            Materia.Name = "Materia";
            Materia.Size = new Size(302, 28);
            Materia.TabIndex = 2;
            Materia.Text = "GRAFICACIÓN Y VIDEOJUEGOS";
            Materia.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Materia);
            Controls.Add(Nombre);
            Controls.Add(ID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label Nombre;
        private Label Materia;
    }
}
