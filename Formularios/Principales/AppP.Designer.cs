namespace Tracking_Comercial.Ventanas
{
    partial class AppP
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
            tabControl1 = new TabControl();
            tpGP = new TabPage();
            tpMP = new TabPage();
            btnVA = new Button();
            btnBP = new Button();
            cbP = new ComboBox();
            txtBP = new TextBox();
            btnEP = new Button();
            btnMP = new Button();
            btnAP = new Button();
            dgP = new DataGridView();
            tpEP = new TabPage();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnBE = new Button();
            groupBox4 = new GroupBox();
            btnEE = new Button();
            btnME = new Button();
            btnAE = new Button();
            dataGridView1 = new DataGridView();
            tpP = new TabPage();
            btnBPe = new Button();
            cbPe = new ComboBox();
            txtBPe = new TextBox();
            btnEPe = new Button();
            btnMPe = new Button();
            btnAPe = new Button();
            dgPe = new DataGridView();
            tpU = new TabPage();
            groupBox2 = new GroupBox();
            txtBU = new TextBox();
            cbU = new ComboBox();
            btnBU = new Button();
            groupBox1 = new GroupBox();
            btnEU = new Button();
            btnMU = new Button();
            btnAU = new Button();
            dgU = new DataGridView();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tpMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgP).BeginInit();
            tpEP.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPe).BeginInit();
            tpU.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgU).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tpGP);
            tabControl1.Controls.Add(tpMP);
            tabControl1.Controls.Add(tpEP);
            tabControl1.Controls.Add(tpP);
            tabControl1.Controls.Add(tpU);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 459);
            tabControl1.TabIndex = 1;
            // 
            // tpGP
            // 
            tpGP.Location = new Point(4, 27);
            tpGP.Name = "tpGP";
            tpGP.Size = new Size(776, 428);
            tpGP.TabIndex = 2;
            tpGP.Text = "Gestion";
            tpGP.UseVisualStyleBackColor = true;
            // 
            // tpMP
            // 
            tpMP.Controls.Add(btnVA);
            tpMP.Controls.Add(btnBP);
            tpMP.Controls.Add(cbP);
            tpMP.Controls.Add(txtBP);
            tpMP.Controls.Add(btnEP);
            tpMP.Controls.Add(btnMP);
            tpMP.Controls.Add(btnAP);
            tpMP.Controls.Add(dgP);
            tpMP.Location = new Point(4, 27);
            tpMP.Name = "tpMP";
            tpMP.Padding = new Padding(3);
            tpMP.Size = new Size(776, 428);
            tpMP.TabIndex = 0;
            tpMP.Text = "Prospecto";
            tpMP.UseVisualStyleBackColor = true;
            // 
            // btnVA
            // 
            btnVA.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnVA.Location = new Point(89, 7);
            btnVA.Name = "btnVA";
            btnVA.Size = new Size(75, 23);
            btnVA.TabIndex = 7;
            btnVA.Text = "Ver archivos";
            btnVA.UseVisualStyleBackColor = true;
            btnVA.Click += btnVA_Click;
            // 
            // btnBP
            // 
            btnBP.Location = new Point(693, 7);
            btnBP.Name = "btnBP";
            btnBP.Size = new Size(75, 23);
            btnBP.TabIndex = 6;
            btnBP.Text = "Buscar";
            btnBP.UseVisualStyleBackColor = true;
            // 
            // cbP
            // 
            cbP.FormattingEnabled = true;
            cbP.Location = new Point(566, 6);
            cbP.Name = "cbP";
            cbP.Size = new Size(121, 23);
            cbP.TabIndex = 5;
            // 
            // txtBP
            // 
            txtBP.Location = new Point(566, 35);
            txtBP.Name = "txtBP";
            txtBP.Size = new Size(202, 23);
            txtBP.TabIndex = 4;
            // 
            // btnEP
            // 
            btnEP.Location = new Point(89, 35);
            btnEP.Name = "btnEP";
            btnEP.Size = new Size(75, 23);
            btnEP.TabIndex = 3;
            btnEP.Text = "Eliminar";
            btnEP.UseVisualStyleBackColor = true;
            // 
            // btnMP
            // 
            btnMP.Location = new Point(8, 35);
            btnMP.Name = "btnMP";
            btnMP.Size = new Size(75, 23);
            btnMP.TabIndex = 2;
            btnMP.Text = "Modificar";
            btnMP.UseVisualStyleBackColor = true;
            btnMP.Click += btnMP_Click;
            // 
            // btnAP
            // 
            btnAP.Location = new Point(8, 6);
            btnAP.Name = "btnAP";
            btnAP.Size = new Size(75, 23);
            btnAP.TabIndex = 1;
            btnAP.Text = "Agregar";
            btnAP.UseVisualStyleBackColor = true;
            // 
            // dgP
            // 
            dgP.AllowUserToAddRows = false;
            dgP.AllowUserToDeleteRows = false;
            dgP.AllowUserToOrderColumns = true;
            dgP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgP.Location = new Point(8, 64);
            dgP.Name = "dgP";
            dgP.ReadOnly = true;
            dgP.RowTemplate.Height = 25;
            dgP.Size = new Size(760, 363);
            dgP.TabIndex = 0;
            // 
            // tpEP
            // 
            tpEP.Controls.Add(groupBox3);
            tpEP.Controls.Add(groupBox4);
            tpEP.Controls.Add(dataGridView1);
            tpEP.Location = new Point(4, 27);
            tpEP.Name = "tpEP";
            tpEP.Padding = new Padding(3);
            tpEP.Size = new Size(776, 428);
            tpEP.TabIndex = 1;
            tpEP.Text = "Estados";
            tpEP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(btnBE);
            groupBox3.Location = new Point(492, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(278, 70);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 12;
            // 
            // btnBE
            // 
            btnBE.Location = new Point(199, 11);
            btnBE.Name = "btnBE";
            btnBE.Size = new Size(75, 23);
            btnBE.TabIndex = 13;
            btnBE.Text = "Buscar";
            btnBE.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEE);
            groupBox4.Controls.Add(btnME);
            groupBox4.Controls.Add(btnAE);
            groupBox4.Location = new Point(6, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.RightToLeft = RightToLeft.Yes;
            groupBox4.Size = new Size(480, 70);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gestion";
            // 
            // btnEE
            // 
            btnEE.Location = new Point(87, 42);
            btnEE.Name = "btnEE";
            btnEE.Size = new Size(75, 23);
            btnEE.TabIndex = 10;
            btnEE.Text = "Eliminar";
            btnEE.UseVisualStyleBackColor = true;
            // 
            // btnME
            // 
            btnME.Location = new Point(6, 42);
            btnME.Name = "btnME";
            btnME.Size = new Size(75, 23);
            btnME.TabIndex = 9;
            btnME.Text = "Modificar";
            btnME.UseVisualStyleBackColor = true;
            // 
            // btnAE
            // 
            btnAE.Location = new Point(6, 12);
            btnAE.Name = "btnAE";
            btnAE.Size = new Size(75, 23);
            btnAE.TabIndex = 8;
            btnAE.Text = "Agregar";
            btnAE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(760, 350);
            dataGridView1.TabIndex = 16;
            // 
            // tpP
            // 
            tpP.Controls.Add(btnBPe);
            tpP.Controls.Add(cbPe);
            tpP.Controls.Add(txtBPe);
            tpP.Controls.Add(btnEPe);
            tpP.Controls.Add(btnMPe);
            tpP.Controls.Add(btnAPe);
            tpP.Controls.Add(dgPe);
            tpP.Location = new Point(4, 27);
            tpP.Name = "tpP";
            tpP.Size = new Size(776, 428);
            tpP.TabIndex = 4;
            tpP.Text = "Perfiles";
            tpP.UseVisualStyleBackColor = true;
            // 
            // btnBPe
            // 
            btnBPe.Location = new Point(693, 7);
            btnBPe.Name = "btnBPe";
            btnBPe.Size = new Size(75, 23);
            btnBPe.TabIndex = 20;
            btnBPe.Text = "Buscar";
            btnBPe.UseVisualStyleBackColor = true;
            // 
            // cbPe
            // 
            cbPe.FormattingEnabled = true;
            cbPe.Location = new Point(566, 6);
            cbPe.Name = "cbPe";
            cbPe.Size = new Size(121, 23);
            cbPe.TabIndex = 19;
            // 
            // txtBPe
            // 
            txtBPe.Location = new Point(566, 35);
            txtBPe.Name = "txtBPe";
            txtBPe.Size = new Size(202, 23);
            txtBPe.TabIndex = 18;
            // 
            // btnEPe
            // 
            btnEPe.Location = new Point(89, 35);
            btnEPe.Name = "btnEPe";
            btnEPe.Size = new Size(75, 23);
            btnEPe.TabIndex = 17;
            btnEPe.Text = "Eliminar";
            btnEPe.UseVisualStyleBackColor = true;
            // 
            // btnMPe
            // 
            btnMPe.Location = new Point(8, 35);
            btnMPe.Name = "btnMPe";
            btnMPe.Size = new Size(75, 23);
            btnMPe.TabIndex = 16;
            btnMPe.Text = "Modificar";
            btnMPe.UseVisualStyleBackColor = true;
            // 
            // btnAPe
            // 
            btnAPe.Location = new Point(8, 6);
            btnAPe.Name = "btnAPe";
            btnAPe.Size = new Size(75, 23);
            btnAPe.TabIndex = 15;
            btnAPe.Text = "Agregar";
            btnAPe.UseVisualStyleBackColor = true;
            // 
            // dgPe
            // 
            dgPe.AllowUserToAddRows = false;
            dgPe.AllowUserToDeleteRows = false;
            dgPe.AllowUserToOrderColumns = true;
            dgPe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPe.Location = new Point(8, 64);
            dgPe.Name = "dgPe";
            dgPe.ReadOnly = true;
            dgPe.RowTemplate.Height = 25;
            dgPe.Size = new Size(760, 363);
            dgPe.TabIndex = 14;
            // 
            // tpU
            // 
            tpU.Controls.Add(groupBox2);
            tpU.Controls.Add(groupBox1);
            tpU.Controls.Add(dgU);
            tpU.Location = new Point(4, 27);
            tpU.Name = "tpU";
            tpU.Size = new Size(776, 428);
            tpU.TabIndex = 3;
            tpU.Text = "Usuarios";
            tpU.UseVisualStyleBackColor = true;
            tpU.Click += tpU_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBU);
            groupBox2.Controls.Add(cbU);
            groupBox2.Controls.Add(btnBU);
            groupBox2.Location = new Point(490, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 70);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // txtBU
            // 
            txtBU.Location = new Point(72, 42);
            txtBU.Name = "txtBU";
            txtBU.Size = new Size(202, 23);
            txtBU.TabIndex = 11;
            // 
            // cbU
            // 
            cbU.FormattingEnabled = true;
            cbU.Location = new Point(72, 12);
            cbU.Name = "cbU";
            cbU.Size = new Size(121, 23);
            cbU.TabIndex = 12;
            // 
            // btnBU
            // 
            btnBU.Location = new Point(199, 11);
            btnBU.Name = "btnBU";
            btnBU.Size = new Size(75, 23);
            btnBU.TabIndex = 13;
            btnBU.Text = "Buscar";
            btnBU.UseVisualStyleBackColor = true;
            btnBU.Click += btnBU_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEU);
            groupBox1.Controls.Add(btnMU);
            groupBox1.Controls.Add(btnAU);
            groupBox1.Location = new Point(4, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(480, 70);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion";
            // 
            // btnEU
            // 
            btnEU.Location = new Point(85, 41);
            btnEU.Name = "btnEU";
            btnEU.Size = new Size(75, 23);
            btnEU.TabIndex = 10;
            btnEU.Text = "Eliminar";
            btnEU.UseVisualStyleBackColor = true;
            // 
            // btnMU
            // 
            btnMU.Location = new Point(4, 41);
            btnMU.Name = "btnMU";
            btnMU.Size = new Size(75, 23);
            btnMU.TabIndex = 9;
            btnMU.Text = "Modificar";
            btnMU.UseVisualStyleBackColor = true;
            // 
            // btnAU
            // 
            btnAU.Location = new Point(4, 12);
            btnAU.Name = "btnAU";
            btnAU.Size = new Size(75, 23);
            btnAU.TabIndex = 8;
            btnAU.Text = "Agregar";
            btnAU.UseVisualStyleBackColor = true;
            btnAU.Click += btnAU_Click;
            // 
            // dgU
            // 
            dgU.AllowUserToAddRows = false;
            dgU.AllowUserToDeleteRows = false;
            dgU.AllowUserToOrderColumns = true;
            dgU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgU.Location = new Point(8, 77);
            dgU.Name = "dgU";
            dgU.ReadOnly = true;
            dgU.RowTemplate.Height = 25;
            dgU.Size = new Size(760, 350);
            dgU.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(695, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 2;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AppP
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "AppP";
            Text = "Prospectos Alcachofa";
            FormClosing += app_Closing;
            tabControl1.ResumeLayout(false);
            tpMP.ResumeLayout(false);
            tpMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgP).EndInit();
            tpEP.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpP.ResumeLayout(false);
            tpP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPe).EndInit();
            tpU.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgU).EndInit();
            ResumeLayout(false);
        }

        private void TpU_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpMP;
        private TabPage tpEP;
        private TabPage tpGP;
        private TabPage tpP;
        private TabPage tpU;
        private DataGridView dgP;
        private Button btnBP;
        private ComboBox cbP;
        private TextBox txtBP;
        private Button btnEP;
        private Button btnMP;
        private Button btnAP;
        private Button btnBU;
        private ComboBox cbU;
        private TextBox txtBU;
        private Button btnEU;
        private Button btnMU;
        private Button btnAU;
        private DataGridView dgU;
        private Button btnBPe;
        private ComboBox cbPe;
        private TextBox txtBPe;
        private Button btnEPe;
        private Button btnMPe;
        private Button btnAPe;
        private DataGridView dgPe;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnBE;
        private GroupBox groupBox4;
        private Button btnEE;
        private Button btnME;
        private Button btnAE;
        private DataGridView dataGridView1;
        private Button btnVA;
    }
}