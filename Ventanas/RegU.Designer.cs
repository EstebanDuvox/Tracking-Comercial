namespace Tracking_Comercial.Ventanas
{
    partial class RegU
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
            txtU = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnC = new Button();
            btnA = new Button();
            SuspendLayout();
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.ForeColor = SystemColors.InactiveCaption;
            txtC.Location = new Point(120, 190);
            txtC.MaxLength = 20;
            txtC.Name = "txtC";
            txtC.Size = new Size(169, 27);
            txtC.TabIndex = 9;
            txtC.Text = "ej:admin123";
            txtC.Click += txtC_Click;
            // 
            // txtU
            // 
            txtU.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtU.ForeColor = SystemColors.InactiveCaption;
            txtU.Location = new Point(120, 96);
            txtU.MaxLength = 25;
            txtU.Name = "txtU";
            txtU.Size = new Size(169, 27);
            txtU.TabIndex = 8;
            txtU.Text = "ej:pepito";
            txtU.Click += txtU_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 169);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 76);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 6;
            label1.Text = "Usuario:";
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.Location = new Point(12, 394);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 30);
            btnC.TabIndex = 10;
            btnC.Text = "Cancelar";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnA
            // 
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnA.Location = new Point(247, 394);
            btnA.Name = "btnA";
            btnA.Size = new Size(75, 30);
            btnA.TabIndex = 11;
            btnA.Text = "Aceptar";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // RegU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 436);
            ControlBox = false;
            Controls.Add(btnA);
            Controls.Add(btnC);
            Controls.Add(txtC);
            Controls.Add(txtU);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegU";
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtC;
        private TextBox txtU;
        private Label label2;
        private Label label1;
        private Button btnC;
        private Button btnA;
        private HelpProvider helpProvider1;
        private HelpProvider helpProvider2;
    }
}