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
            tpMP = new TabPage();
            button4 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            idp = new DataGridViewTextBoxColumn();
            cl = new DataGridViewTextBoxColumn();
            nc = new DataGridViewTextBoxColumn();
            apC = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            ETS = new DataGridViewTextBoxColumn();
            RT = new DataGridViewTextBoxColumn();
            RE = new DataGridViewTextBoxColumn();
            EP = new DataGridViewTextBoxColumn();
            DP = new DataGridViewTextBoxColumn();
            PTP = new DataGridViewTextBoxColumn();
            tpEP = new TabPage();
            tpGP = new TabPage();
            tpP = new TabPage();
            tpU = new TabPage();
            button5 = new Button();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            idpros = new DataGridViewTextBoxColumn();
            Pros = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tpMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpEP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpMP);
            tabControl1.Controls.Add(tpEP);
            tabControl1.Controls.Add(tpGP);
            tabControl1.Controls.Add(tpP);
            tabControl1.Controls.Add(tpU);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 461);
            tabControl1.TabIndex = 1;
            // 
            // tpMP
            // 
            tpMP.Controls.Add(button4);
            tpMP.Controls.Add(comboBox1);
            tpMP.Controls.Add(textBox1);
            tpMP.Controls.Add(button3);
            tpMP.Controls.Add(button2);
            tpMP.Controls.Add(button1);
            tpMP.Controls.Add(dataGridView1);
            tpMP.Location = new Point(4, 24);
            tpMP.Name = "tpMP";
            tpMP.Padding = new Padding(3);
            tpMP.Size = new Size(776, 433);
            tpMP.TabIndex = 0;
            tpMP.Text = "Prospecto";
            tpMP.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(693, 7);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id_proyecto", "Cliente", "Nombre_com", "Apellido_Com", "Descripcion", "Esp_Tec_Sol", "Restr_tiempo", "Restr_eco", "Estado_pros", "Doc", "Propuesta_T" });
            comboBox1.Location = new Point(566, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "id_proyecto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(89, 35);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(8, 35);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(8, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idp, cl, nc, apC, desc, ETS, RT, RE, EP, DP, PTP });
            dataGridView1.Location = new Point(8, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(760, 363);
            dataGridView1.TabIndex = 0;
            // 
            // idp
            // 
            idp.HeaderText = "id_proyecto";
            idp.Name = "idp";
            // 
            // cl
            // 
            cl.HeaderText = "Cliente";
            cl.Name = "cl";
            // 
            // nc
            // 
            nc.HeaderText = "Nombre_com";
            nc.Name = "nc";
            // 
            // apC
            // 
            apC.HeaderText = "Apellido_Com";
            apC.Name = "apC";
            // 
            // desc
            // 
            desc.HeaderText = "Descripcion";
            desc.Name = "desc";
            // 
            // ETS
            // 
            ETS.HeaderText = "Esp_Tec_Sol";
            ETS.Name = "ETS";
            // 
            // RT
            // 
            RT.HeaderText = "Restr_tiempo";
            RT.Name = "RT";
            // 
            // RE
            // 
            RE.HeaderText = "Restr_eco";
            RE.Name = "RE";
            // 
            // EP
            // 
            EP.HeaderText = "Estado_pros";
            EP.Name = "EP";
            // 
            // DP
            // 
            DP.HeaderText = "Doc";
            DP.Name = "DP";
            // 
            // PTP
            // 
            PTP.HeaderText = "Propuesta_T";
            PTP.Name = "PTP";
            // 
            // tpEP
            // 
            tpEP.Controls.Add(button5);
            tpEP.Controls.Add(comboBox2);
            tpEP.Controls.Add(textBox2);
            tpEP.Controls.Add(button6);
            tpEP.Controls.Add(button7);
            tpEP.Controls.Add(button8);
            tpEP.Controls.Add(dataGridView2);
            tpEP.Location = new Point(4, 24);
            tpEP.Name = "tpEP";
            tpEP.Padding = new Padding(3);
            tpEP.Size = new Size(776, 433);
            tpEP.TabIndex = 1;
            tpEP.Text = "Estados";
            tpEP.UseVisualStyleBackColor = true;
            tpEP.Click += tpEP_Click;
            // 
            // tpGP
            // 
            tpGP.Location = new Point(4, 24);
            tpGP.Name = "tpGP";
            tpGP.Size = new Size(776, 433);
            tpGP.TabIndex = 2;
            tpGP.Text = "Gestion";
            tpGP.UseVisualStyleBackColor = true;
            // 
            // tpP
            // 
            tpP.Location = new Point(4, 24);
            tpP.Name = "tpP";
            tpP.Size = new Size(776, 433);
            tpP.TabIndex = 4;
            tpP.Text = "Perfiles";
            tpP.UseVisualStyleBackColor = true;
            // 
            // tpU
            // 
            tpU.Location = new Point(4, 24);
            tpU.Name = "tpU";
            tpU.Size = new Size(776, 433);
            tpU.TabIndex = 3;
            tpU.Text = "Usuarios";
            tpU.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(693, 7);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "id_proyecto", "Cliente", "Nombre_com", "Apellido_Com", "Descripcion", "Esp_Tec_Sol", "Restr_tiempo", "Restr_eco", "Estado_pros", "Doc", "Propuesta_T" });
            comboBox2.Location = new Point(566, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "id_proyecto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(566, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 11;
            // 
            // button6
            // 
            button6.Location = new Point(89, 35);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(8, 35);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 9;
            button7.Text = "Modificar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(8, 6);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "Agregar";
            button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idpros, Pros, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridView2.Location = new Point(8, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(760, 363);
            dataGridView2.TabIndex = 7;
            // 
            // idpros
            // 
            idpros.HeaderText = "id_prospecto";
            idpros.Name = "idpros";
            // 
            // Pros
            // 
            Pros.HeaderText = "Prospecto";
            Pros.Name = "Pros";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre_com";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Apellido_Com";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Esp_Tec_Sol";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Restr_tiempo";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Restr_eco";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Estado_pros";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Doc";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Propuesta_T";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl1);
            Name = "app";
            Text = "Form1";
            FormClosing += app_Closing;
            tabControl1.ResumeLayout(false);
            tpMP.ResumeLayout(false);
            tpMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpEP.ResumeLayout(false);
            tpEP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpMP;
        private TabPage tpEP;
        private TabPage tpGP;
        private TabPage tpP;
        private TabPage tpU;
        private DataGridView dataGridView1;
        private Button button4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn idp;
        private DataGridViewTextBoxColumn cl;
        private DataGridViewTextBoxColumn nc;
        private DataGridViewTextBoxColumn apC;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn ETS;
        private DataGridViewTextBoxColumn RT;
        private DataGridViewTextBoxColumn RE;
        private DataGridViewTextBoxColumn EP;
        private DataGridViewTextBoxColumn DP;
        private DataGridViewTextBoxColumn PTP;
        private Button button5;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idpros;
        private DataGridViewTextBoxColumn Pros;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}