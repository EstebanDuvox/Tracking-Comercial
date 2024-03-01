namespace Tracking_Comercial.Formularios.Secundarios
{
    partial class Archivos
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
            vScrollBar1 = new VScrollBar();
            lbAr = new ListBox();
            label1 = new Label();
            label2 = new Label();
            cbP = new ComboBox();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(346, 56);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 409);
            vScrollBar1.TabIndex = 0;
            // 
            // lbAr
            // 
            lbAr.FormattingEnabled = true;
            lbAr.ItemHeight = 15;
            lbAr.Location = new Point(14, 56);
            lbAr.Name = "lbAr";
            lbAr.Size = new Size(333, 409);
            lbAr.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione prospecto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Lista de archivos:";
            // 
            // cbP
            // 
            cbP.FormattingEnabled = true;
            cbP.Location = new Point(140, 6);
            cbP.Name = "cbP";
            cbP.Size = new Size(207, 23);
            cbP.TabIndex = 4;
            // 
            // Archivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 469);
            Controls.Add(cbP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbAr);
            Controls.Add(vScrollBar1);
            Name = "Archivos";
            Text = "Archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private ListBox lbAr;
        private Label label1;
        private Label label2;
        private ComboBox cbP;
    }
}