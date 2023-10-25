namespace Tracking_Comercial
{
    partial class LogIn
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
            btnS = new Button();
            btnL = new Button();
            label1 = new Label();
            label2 = new Label();
            txtU = new TextBox();
            txtC = new TextBox();
            SuspendLayout();
            // 
            // btnS
            // 
            btnS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnS.Location = new Point(12, 242);
            btnS.Name = "btnS";
            btnS.Size = new Size(75, 30);
            btnS.TabIndex = 0;
            btnS.Text = "Salir";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // btnL
            // 
            btnL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnL.Location = new Point(357, 242);
            btnL.Name = "btnL";
            btnL.Size = new Size(115, 30);
            btnL.TabIndex = 1;
            btnL.Text = "Iniciar Sesion";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 127);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txtU
            // 
            txtU.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtU.Location = new Point(127, 54);
            txtU.MaxLength = 25;
            txtU.Name = "txtU";
            txtU.Size = new Size(169, 27);
            txtU.TabIndex = 4;
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(127, 148);
            txtC.MaxLength = 20;
            txtC.Name = "txtC";
            txtC.Size = new Size(169, 27);
            txtC.TabIndex = 5;
            txtC.UseSystemPasswordChar = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(484, 284);
            ControlBox = false;
            Controls.Add(txtC);
            Controls.Add(txtU);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnL);
            Controls.Add(btnS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnS;
        private Button btnL;
        private Label label1;
        private Label label2;
        private TextBox txtU;
        private TextBox txtC;
    }
}