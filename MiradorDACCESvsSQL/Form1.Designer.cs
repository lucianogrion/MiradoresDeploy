namespace MiradorDACCESvsSQL
{
    partial class Form1
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
            this.cmdProcesarCarpeta = new System.Windows.Forms.Button();
            this.cmdCarpeta = new System.Windows.Forms.Button();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.griCotejar = new System.Windows.Forms.DataGridView();
            this.cmdCotejar = new System.Windows.Forms.Button();
            this.griDB = new System.Windows.Forms.DataGridView();
            this.griDATA = new System.Windows.Forms.DataGridView();
            this.cmdConectar = new System.Windows.Forms.Button();
            this.txtConectionString = new System.Windows.Forms.TextBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoE = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDATA)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdProcesarCarpeta
            // 
            this.cmdProcesarCarpeta.Location = new System.Drawing.Point(203, 30);
            this.cmdProcesarCarpeta.Name = "cmdProcesarCarpeta";
            this.cmdProcesarCarpeta.Size = new System.Drawing.Size(75, 49);
            this.cmdProcesarCarpeta.TabIndex = 51;
            this.cmdProcesarCarpeta.Text = "Procesar";
            this.cmdProcesarCarpeta.UseVisualStyleBackColor = true;
            this.cmdProcesarCarpeta.Click += new System.EventHandler(this.cmdProcesarCarpeta_Click);
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.Location = new System.Drawing.Point(2, 1);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(279, 23);
            this.cmdCarpeta.TabIndex = 50;
            this.cmdCarpeta.Text = "Seleccionar Carpeta";
            this.cmdCarpeta.UseVisualStyleBackColor = true;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(2, 30);
            this.txtCarpeta.Multiline = true;
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(195, 49);
            this.txtCarpeta.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Sps Invocados En Data Access";
            // 
            // griCotejar
            // 
            this.griCotejar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griCotejar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griCotejar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griCotejar.Location = new System.Drawing.Point(568, 30);
            this.griCotejar.Name = "griCotejar";
            this.griCotejar.Size = new System.Drawing.Size(285, 281);
            this.griCotejar.TabIndex = 47;
            // 
            // cmdCotejar
            // 
            this.cmdCotejar.Location = new System.Drawing.Point(568, 1);
            this.cmdCotejar.Name = "cmdCotejar";
            this.cmdCotejar.Size = new System.Drawing.Size(285, 23);
            this.cmdCotejar.TabIndex = 46;
            this.cmdCotejar.Text = "Cotejar Valores SP";
            this.cmdCotejar.UseVisualStyleBackColor = true;
            this.cmdCotejar.Click += new System.EventHandler(this.cmdCotejar_Click);
            // 
            // griDB
            // 
            this.griDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griDB.Location = new System.Drawing.Point(287, 98);
            this.griDB.Name = "griDB";
            this.griDB.Size = new System.Drawing.Size(267, 213);
            this.griDB.TabIndex = 45;
            // 
            // griDATA
            // 
            this.griDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griDATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griDATA.Location = new System.Drawing.Point(2, 98);
            this.griDATA.Name = "griDATA";
            this.griDATA.Size = new System.Drawing.Size(279, 213);
            this.griDATA.TabIndex = 44;
            // 
            // cmdConectar
            // 
            this.cmdConectar.Location = new System.Drawing.Point(479, 30);
            this.cmdConectar.Name = "cmdConectar";
            this.cmdConectar.Size = new System.Drawing.Size(75, 49);
            this.cmdConectar.TabIndex = 43;
            this.cmdConectar.Text = "PROBAR";
            this.cmdConectar.UseVisualStyleBackColor = true;
            this.cmdConectar.Click += new System.EventHandler(this.cmdConectar_Click);
            // 
            // txtConectionString
            // 
            this.txtConectionString.Location = new System.Drawing.Point(287, 30);
            this.txtConectionString.Multiline = true;
            this.txtConectionString.Name = "txtConectionString";
            this.txtConectionString.ReadOnly = true;
            this.txtConectionString.Size = new System.Drawing.Size(194, 49);
            this.txtConectionString.TabIndex = 42;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(284, 82);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(62, 13);
            this.lblConfig.TabIndex = 41;
            this.lblConfig.Text = "Base Datos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoE,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoE
            // 
            this.lblEstadoE.Name = "lblEstadoE";
            this.lblEstadoE.Size = new System.Drawing.Size(44, 17);
            this.lblEstadoE.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Conection String (App.config)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdProcesarCarpeta);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.griCotejar);
            this.Controls.Add(this.cmdCotejar);
            this.Controls.Add(this.griDB);
            this.Controls.Add(this.griDATA);
            this.Controls.Add(this.cmdConectar);
            this.Controls.Add(this.txtConectionString);
            this.Controls.Add(this.lblConfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDATA)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProcesarCarpeta;
        private System.Windows.Forms.Button cmdCarpeta;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView griCotejar;
        private System.Windows.Forms.Button cmdCotejar;
        private System.Windows.Forms.DataGridView griDB;
        private System.Windows.Forms.DataGridView griDATA;
        private System.Windows.Forms.Button cmdConectar;
        private System.Windows.Forms.TextBox txtConectionString;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoE;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

