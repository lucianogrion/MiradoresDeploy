namespace MiradorSPVsBD
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
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.griCotejar = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdCotejar = new System.Windows.Forms.Button();
            this.griConfigDestino = new System.Windows.Forms.DataGridView();
            this.cmdConfigDestino = new System.Windows.Forms.Button();
            this.txtConfigDestino = new System.Windows.Forms.TextBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.griSQL = new System.Windows.Forms.DataGridView();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.cmdCarpeta = new System.Windows.Forms.Button();
            this.cmdProcesarCarpeta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoE = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griSQL)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "SPs";
            // 
            // griCotejar
            // 
            this.griCotejar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griCotejar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griCotejar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griCotejar.Location = new System.Drawing.Point(570, 31);
            this.griCotejar.Name = "griCotejar";
            this.griCotejar.Size = new System.Drawing.Size(285, 281);
            this.griCotejar.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdCotejar
            // 
            this.cmdCotejar.Location = new System.Drawing.Point(570, 2);
            this.cmdCotejar.Name = "cmdCotejar";
            this.cmdCotejar.Size = new System.Drawing.Size(285, 23);
            this.cmdCotejar.TabIndex = 33;
            this.cmdCotejar.Text = "Cotejar Valores SP";
            this.cmdCotejar.UseVisualStyleBackColor = true;
            // 
            // griConfigDestino
            // 
            this.griConfigDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griConfigDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griConfigDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griConfigDestino.Location = new System.Drawing.Point(12, 99);
            this.griConfigDestino.Name = "griConfigDestino";
            this.griConfigDestino.Size = new System.Drawing.Size(267, 213);
            this.griConfigDestino.TabIndex = 32;
            // 
            // cmdConfigDestino
            // 
            this.cmdConfigDestino.Location = new System.Drawing.Point(12, 57);
            this.cmdConfigDestino.Name = "cmdConfigDestino";
            this.cmdConfigDestino.Size = new System.Drawing.Size(267, 23);
            this.cmdConfigDestino.TabIndex = 30;
            this.cmdConfigDestino.Text = "Conectar";
            this.cmdConfigDestino.UseVisualStyleBackColor = true;
            // 
            // txtConfigDestino
            // 
            this.txtConfigDestino.Location = new System.Drawing.Point(12, 4);
            this.txtConfigDestino.Multiline = true;
            this.txtConfigDestino.Name = "txtConfigDestino";
            this.txtConfigDestino.Size = new System.Drawing.Size(267, 49);
            this.txtConfigDestino.TabIndex = 29;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(9, 83);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(62, 13);
            this.lblConfig.TabIndex = 28;
            this.lblConfig.Text = "Base Datos";
            // 
            // griSQL
            // 
            this.griSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griSQL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griSQL.Location = new System.Drawing.Point(285, 99);
            this.griSQL.Name = "griSQL";
            this.griSQL.Size = new System.Drawing.Size(279, 213);
            this.griSQL.TabIndex = 31;
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(285, 31);
            this.txtCarpeta.Multiline = true;
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(195, 49);
            this.txtCarpeta.TabIndex = 38;
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.Location = new System.Drawing.Point(285, 2);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(279, 23);
            this.cmdCarpeta.TabIndex = 39;
            this.cmdCarpeta.Text = "Seleccionar Carpeta";
            this.cmdCarpeta.UseVisualStyleBackColor = true;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // cmdProcesarCarpeta
            // 
            this.cmdProcesarCarpeta.Location = new System.Drawing.Point(486, 31);
            this.cmdProcesarCarpeta.Name = "cmdProcesarCarpeta";
            this.cmdProcesarCarpeta.Size = new System.Drawing.Size(75, 49);
            this.cmdProcesarCarpeta.TabIndex = 40;
            this.cmdProcesarCarpeta.Text = "Procesar";
            this.cmdProcesarCarpeta.UseVisualStyleBackColor = true;
            this.cmdProcesarCarpeta.Click += new System.EventHandler(this.cmdProcesarCarpeta_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoE,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 41;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 385);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdProcesarCarpeta);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.griCotejar);
            this.Controls.Add(this.cmdCotejar);
            this.Controls.Add(this.griConfigDestino);
            this.Controls.Add(this.griSQL);
            this.Controls.Add(this.cmdConfigDestino);
            this.Controls.Add(this.txtConfigDestino);
            this.Controls.Add(this.lblConfig);
            this.Name = "Form1";
            this.Text = "Comprobador BD vs SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griSQL)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView griCotejar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdCotejar;
        private System.Windows.Forms.DataGridView griConfigDestino;
        private System.Windows.Forms.Button cmdConfigDestino;
        private System.Windows.Forms.TextBox txtConfigDestino;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.DataGridView griSQL;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button cmdCarpeta;
        private System.Windows.Forms.Button cmdProcesarCarpeta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoE;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}

