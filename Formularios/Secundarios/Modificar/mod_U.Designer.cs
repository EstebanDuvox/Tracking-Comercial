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
            txtC = new TextBox();
            cbTU = new ComboBox();
            cbU = new ComboBox();
            btnOK = new Button();
            btnC = new Button();
            chC = new CheckBox();
            chTU = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtC
            // 
            txtC.Enabled = false;
            txtC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(232, 140);
            txtC.MaxLength = 25;
            txtC.Name = "txtC";
            txtC.Size = new Size(121, 26);
            txtC.TabIndex = 1;
            // 
            // cbTU
            // 
            cbTU.Enabled = false;
            cbTU.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTU.FormattingEnabled = true;
            cbTU.Items.AddRange(new object[] { "Comercial", "Empleado", "Gerente", "Administrador" });
            cbTU.Location = new Point(232, 185);
            cbTU.Name = "cbTU";
            cbTU.Size = new Size(121, 28);
            cbTU.TabIndex = 3;
            cbTU.Text = "Comercial";
            // 
            // cbU
            // 
            cbU.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbU.FormattingEnabled = true;
            cbU.Location = new Point(238, 30);
            cbU.Name = "cbU";
            cbU.Size = new Size(115, 29);
            cbU.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(278, 258);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "Confirmar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 258);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 7;
            btnC.Text = "Cancelar";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button2_Click;
            // 
            // chC
            // 
            chC.AutoSize = true;
            chC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chC.Location = new Point(114, 142);
            chC.Name = "chC";
            chC.Size = new Size(111, 24);
            chC.TabIndex = 8;
            chC.Text = "Contraseña";
            chC.UseVisualStyleBackColor = true;
            chC.CheckedChanged += chC_CheckedChanged;
            // 
            // chTU
            // 
            chTU.AutoSize = true;
            chTU.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chTU.Location = new Point(89, 187);
            chTU.Name = "chTU";
            chTU.Size = new Size(136, 24);
            chTU.TabIndex = 9;
            chTU.Text = "Tipo de usuario";
            chTU.UseVisualStyleBackColor = true;
            chTU.CheckedChanged += chTU_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(224, 21);
            label2.TabIndex = 10;
            label2.Text = "Seleccione usuario a modificar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 95);
            label1.Name = "label1";
            label1.Size = new Size(215, 21);
            label1.TabIndex = 11;
            label1.Text = "Marque los datos a modificar:";
            // 
            // mod_U
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 293);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(chTU);
            Controls.Add(chC);
            Controls.Add(btnC);
            Controls.Add(btnOK);
            Controls.Add(cbU);
            Controls.Add(cbTU);
            Controls.Add(txtC);
            MaximizeBox = false;
            Name = "mod_U";
            Text = "Modificar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtC;
        private ComboBox cbTU;
        private ComboBox cbU;
        private Button btnOK;
        private Button btnC;
        private CheckBox chC;
        private CheckBox chTU;
        private Label label2;
        private Label label1;
    }
}