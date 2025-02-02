namespace Frifayer
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
            lbl_Olvidarcontraseña = new Label();
            tb_Correo = new TextBox();
            tb_Contraseña = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_Olvidarcontraseña
            // 
            lbl_Olvidarcontraseña.AutoSize = true;
            lbl_Olvidarcontraseña.Font = new Font("Verdana", 9.75F);
            lbl_Olvidarcontraseña.Location = new Point(333, 245);
            lbl_Olvidarcontraseña.Name = "lbl_Olvidarcontraseña";
            lbl_Olvidarcontraseña.Size = new Size(180, 16);
            lbl_Olvidarcontraseña.TabIndex = 0;
            lbl_Olvidarcontraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // tb_Correo
            // 
            tb_Correo.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Correo.Location = new Point(333, 113);
            tb_Correo.Name = "tb_Correo";
            tb_Correo.Size = new Size(389, 23);
            tb_Correo.TabIndex = 1;
            tb_Correo.Text = "Correo";
            // 
            // tb_Contraseña
            // 
            tb_Contraseña.Font = new Font("Verdana", 9.75F);
            tb_Contraseña.Location = new Point(333, 171);
            tb_Contraseña.Name = "tb_Contraseña";
            tb_Contraseña.Size = new Size(389, 23);
            tb_Contraseña.TabIndex = 2;
            tb_Contraseña.Text = "Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(551, 298);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tb_Contraseña);
            Controls.Add(tb_Correo);
            Controls.Add(lbl_Olvidarcontraseña);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Olvidarcontraseña;
        private TextBox tb_Correo;
        private TextBox tb_Contraseña;
        private Button button1;
    }
}
