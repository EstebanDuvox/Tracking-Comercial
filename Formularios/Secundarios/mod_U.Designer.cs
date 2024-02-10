namespace Tracking_Comercial.Formularios.Secundarios
{
    partial class mod_U
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
            clb = new CheckedListBox();
            txtC = new TextBox();
            cbTU = new ComboBox();
            cbU = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // clb
            // 
            clb.BackColor = SystemColors.Control;
            clb.BorderStyle = BorderStyle.None;
            clb.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clb.FormattingEnabled = true;
            clb.Items.AddRange(new object[] { "Contraseña", "Tipo de Usuario" });
            clb.Location = new Point(139, 102);
            clb.Name = "clb";
            clb.Size = new Size(141, 72);
            clb.TabIndex = 0;
            // 
            // txtC
            // 
            txtC.Location = new Point(12, 102);
            txtC.Name = "txtC";
            txtC.Size = new Size(121, 23);
            txtC.TabIndex = 1;
            // 
            // cbTU
            // 
            cbTU.FormattingEnabled = true;
            cbTU.Items.AddRange(new object[] { "Empleado", "Gerente", "Administrador" });
            cbTU.Location = new Point(12, 131);
            cbTU.Name = "cbTU";
            cbTU.Size = new Size(121, 23);
            cbTU.TabIndex = 3;
            cbTU.Text = "Empleado";
            // 
            // cbU
            // 
            cbU.FormattingEnabled = true;
            cbU.Location = new Point(12, 38);
            cbU.Name = "cbU";
            cbU.Size = new Size(121, 23);
            cbU.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // mod_U
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 293);
            Controls.Add(label1);
            Controls.Add(cbU);
            Controls.Add(cbTU);
            Controls.Add(txtC);
            Controls.Add(clb);
            Name = "mod_U";
            Text = "mod_U";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clb;
        private TextBox txtC;
        private ComboBox cbTU;
        private ComboBox cbU;
        private Label label1;
    }
}