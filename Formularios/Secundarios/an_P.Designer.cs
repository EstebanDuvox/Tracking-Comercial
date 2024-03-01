namespace Tracking_Comercial.Formularios.Secundarios
{
    partial class an_P
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
            btnOK = new Button();
            btnC = new Button();
            txtP = new TextBox();
            txtE = new TextBox();
            dtP = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtPro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtD
            // 
            txtD.Enabled = false;
            txtD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtD.Location = new Point(12, 136);
            txtD.MaxLength = 100;
            txtD.Name = "txtD";
            txtD.ScrollBars = ScrollBars.Horizontal;
            txtD.Size = new Size(342, 26);
            txtD.TabIndex = 1;
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
            // txtP
            // 
            txtP.Enabled = false;
            txtP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtP.Location = new Point(169, 305);
            txtP.MaxLength = 20;
            txtP.Name = "txtP";
            txtP.Size = new Size(181, 26);
            txtP.TabIndex = 12;
            // 
            // txtE
            // 
            txtE.Enabled = false;
            txtE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtE.Location = new Point(11, 200);
            txtE.Name = "txtE";
            txtE.ScrollBars = ScrollBars.Horizontal;
            txtE.Size = new Size(343, 26);
            txtE.TabIndex = 13;
            // 
            // dtP
            // 
            dtP.CustomFormat = "";
            dtP.Enabled = false;
            dtP.Location = new Point(150, 254);
            dtP.Name = "dtP";
            dtP.Size = new Size(200, 23);
            dtP.TabIndex = 14;
            dtP.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 11;
            label1.Text = "Prospecto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 10;
            label2.Text = "Ingrese datos";
            // 
            // txtPro
            // 
            txtPro.Enabled = false;
            txtPro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPro.Location = new Point(169, 55);
            txtPro.MaxLength = 30;
            txtPro.Name = "txtPro";
            txtPro.Size = new Size(185, 26);
            txtPro.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(262, 21);
            label3.TabIndex = 18;
            label3.Text = "Descripcion del problema a resolver:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 307);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 19;
            label4.Text = "Presupuesto limite:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 256);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 20;
            label5.Text = "Fecha limite:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 176);
            label6.Name = "label6";
            label6.Size = new Size(259, 21);
            label6.TabIndex = 21;
            label6.Text = "Especificaciones tecnicas solicitadas:";
            // 
            // an_P
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 398);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPro);
            Controls.Add(dtP);
            Controls.Add(txtE);
            Controls.Add(txtP);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnC);
            Controls.Add(btnOK);
            Controls.Add(txtD);
            MaximizeBox = false;
            Name = "an_P";
            Text = "Añadir usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtD;
        private Button btnOK;
        private Button btnC;
        private TextBox txtP;
        private TextBox txtE;
        private DateTimePicker dtP;
        private Label label1;
        private Label label2;
        private TextBox txtPro;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}