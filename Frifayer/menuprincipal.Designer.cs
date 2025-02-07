namespace Frifayer
{
    partial class menuprincipal
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
            pnl_desplegable = new Panel();
            pnl_ventanas = new Panel();
            SuspendLayout();
            // 
            // pnl_desplegable
            // 
            pnl_desplegable.BackColor = Color.LawnGreen;
            pnl_desplegable.Dock = DockStyle.Left;
            pnl_desplegable.Location = new Point(0, 0);
            pnl_desplegable.Name = "pnl_desplegable";
            pnl_desplegable.Size = new Size(136, 681);
            pnl_desplegable.TabIndex = 0;
            // 
            // pnl_ventanas
            // 
            pnl_ventanas.Dock = DockStyle.Fill;
            pnl_ventanas.Location = new Point(136, 0);
            pnl_ventanas.Name = "pnl_ventanas";
            pnl_ventanas.Size = new Size(872, 681);
            pnl_ventanas.TabIndex = 1;
            // 
            // menuprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1008, 681);
            Controls.Add(pnl_ventanas);
            Controls.Add(pnl_desplegable);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "menuprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuprincipal";
            Load += menuprincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_desplegable;
        private Panel pnl_ventanas;
    }
}