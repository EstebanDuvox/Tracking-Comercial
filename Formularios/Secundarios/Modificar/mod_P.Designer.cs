namespace Tracking_Comercial.Formularios.Secundarios
{
    partial class mod_P
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
            txtD = new TextBox();
            cbU = new ComboBox();
            btnOK = new Button();
            btnC = new Button();
            chD = new CheckBox();
            chE = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtP = new TextBox();
            txtE = new TextBox();
            dtP = new DateTimePicker();
            chP = new CheckBox();
            chF = new CheckBox();
            SuspendLayout();
            // 
            // txtD
            // 
            txtD.Enabled = false;
            txtD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtD.Location = new Point(10, 170);
            txtD.MaxLength = 100;
            txtD.Name = "txtD";
            txtD.ScrollBars = ScrollBars.Horizontal;
            txtD.Size = new Size(342, 26);
            txtD.TabIndex = 1;
            // 
            // cbU
            // 
            cbU.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbU.FormattingEnabled = true;
            cbU.Location = new Point(238, 34);
            cbU.Name = "cbU";
            cbU.Size = new Size(115, 29);
            cbU.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(278, 368);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "Confirmar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 368);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 7;
            btnC.Text = "Cancelar";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button2_Click;
            // 
            // chD
            // 
            chD.AutoSize = true;
            chD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chD.Location = new Point(12, 140);
            chD.Name = "chD";
            chD.Size = new Size(282, 24);
            chD.TabIndex = 8;
            chD.Text = "Descripcion del problema a resolver:";
            chD.UseVisualStyleBackColor = true;
            chD.CheckedChanged += chC_CheckedChanged;
            // 
            // chE
            // 
            chE.AutoSize = true;
            chE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chE.Location = new Point(10, 202);
            chE.Name = "chE";
            chE.Size = new Size(292, 24);
            chE.TabIndex = 9;
            chE.Text = "Especificaciones tecnicas solicitadas:";
            chE.UseVisualStyleBackColor = true;
            chE.CheckedChanged += chTU_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(241, 21);
            label2.TabIndex = 10;
            label2.Text = "Seleccione prospecto a modificar:";
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
            // txtP
            // 
            txtP.Enabled = false;
            txtP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtP.Location = new Point(169, 336);
            txtP.MaxLength = 20;
            txtP.Name = "txtP";
            txtP.Size = new Size(181, 26);
            txtP.TabIndex = 12;
            // 
            // txtE
            // 
            txtE.Enabled = false;
            txtE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtE.Location = new Point(10, 232);
            txtE.Name = "txtE";
            txtE.ScrollBars = ScrollBars.Horizontal;
            txtE.Size = new Size(343, 26);
            txtE.TabIndex = 13;
            // 
            // dtP
            // 
            dtP.CustomFormat = "";
            dtP.Enabled = false;
            dtP.Location = new Point(152, 265);
            dtP.Name = "dtP";
            dtP.Size = new Size(200, 23);
            dtP.TabIndex = 14;
            dtP.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            // 
            // chP
            // 
            chP.AutoSize = true;
            chP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chP.Location = new Point(10, 306);
            chP.Name = "chP";
            chP.Size = new Size(162, 24);
            chP.TabIndex = 15;
            chP.Text = "Presupuesto limite:";
            chP.UseVisualStyleBackColor = true;
            chP.CheckedChanged += chP_CheckedChanged;
            // 
            // chF
            // 
            chF.AutoSize = true;
            chF.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chF.Location = new Point(12, 266);
            chF.Name = "chF";
            chF.Size = new Size(117, 24);
            chF.TabIndex = 16;
            chF.Text = "Fecha limite:";
            chF.UseVisualStyleBackColor = true;
            chF.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // mod_P
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 398);
            ControlBox = false;
            Controls.Add(chF);
            Controls.Add(chP);
            Controls.Add(dtP);
            Controls.Add(txtE);
            Controls.Add(txtP);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(chE);
            Controls.Add(chD);
            Controls.Add(btnC);
            Controls.Add(btnOK);
            Controls.Add(cbU);
            Controls.Add(txtD);
            MaximizeBox = false;
            Name = "mod_P";
            Text = "Modificar Prospecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtD;
        private ComboBox cbU;
        private Button btnOK;
        private Button btnC;
        private CheckBox chD;
        private CheckBox chE;
        private Label label2;
        private Label label1;
        private TextBox txtP;
        private TextBox txtE;
        private DateTimePicker dtP;
        private CheckBox chP;
        private CheckBox chF;
    }
}