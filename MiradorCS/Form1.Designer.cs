namespace MiradorCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.cmdCarpeta = new System.Windows.Forms.Button();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdProcesarCarpeta = new System.Windows.Forms.Button();
            this.griCs = new System.Windows.Forms.DataGridView();
            this.griConfig = new System.Windows.Forms.DataGridView();
            this.cmdCotejar = new System.Windows.Forms.Button();
            this.griCotejar = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoE = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.griCs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Claves Necesarias";
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(12, 43);
            this.txtCarpeta.Multiline = true;
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(164, 49);
            this.txtCarpeta.TabIndex = 1;
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.Location = new System.Drawing.Point(12, 12);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(244, 23);
            this.cmdCarpeta.TabIndex = 2;
            this.cmdCarpeta.Text = "Seleccionar Carpeta";
            this.cmdCarpeta.UseVisualStyleBackColor = true;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // cmdConfig
            // 
            this.cmdConfig.Location = new System.Drawing.Point(262, 14);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(183, 23);
            this.cmdConfig.TabIndex = 6;
            this.cmdConfig.Text = "Seleccione .Config";
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(262, 43);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ReadOnly = true;
            this.txtConfig.Size = new System.Drawing.Size(183, 49);
            this.txtConfig.TabIndex = 5;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(259, 95);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(87, 13);
            this.lblConfig.TabIndex = 4;
            this.lblConfig.Text = "Claves en Config";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdProcesarCarpeta
            // 
            this.cmdProcesarCarpeta.Location = new System.Drawing.Point(181, 43);
            this.cmdProcesarCarpeta.Name = "cmdProcesarCarpeta";
            this.cmdProcesarCarpeta.Size = new System.Drawing.Size(75, 49);
            this.cmdProcesarCarpeta.TabIndex = 7;
            this.cmdProcesarCarpeta.Text = "Procesar";
            this.cmdProcesarCarpeta.UseVisualStyleBackColor = true;
            this.cmdProcesarCarpeta.Click += new System.EventHandler(this.cmdProcesarCarpeta_Click);
            // 
            // griCs
            // 
            this.griCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griCs.Location = new System.Drawing.Point(12, 111);
            this.griCs.Name = "griCs";
            this.griCs.Size = new System.Drawing.Size(244, 197);
            this.griCs.TabIndex = 8;
            // 
            // griConfig
            // 
            this.griConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griConfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griConfig.Location = new System.Drawing.Point(262, 111);
            this.griConfig.Name = "griConfig";
            this.griConfig.Size = new System.Drawing.Size(183, 197);
            this.griConfig.TabIndex = 9;
            // 
            // cmdCotejar
            // 
            this.cmdCotejar.Location = new System.Drawing.Point(460, 14);
            this.cmdCotejar.Name = "cmdCotejar";
            this.cmdCotejar.Size = new System.Drawing.Size(280, 23);
            this.cmdCotejar.TabIndex = 10;
            this.cmdCotejar.Text = "COMPARAR";
            this.cmdCotejar.UseVisualStyleBackColor = true;
            this.cmdCotejar.Click += new System.EventHandler(this.cmdCotejar_Click);
            // 
            // griCotejar
            // 
            this.griCotejar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griCotejar.Location = new System.Drawing.Point(460, 43);
            this.griCotejar.Name = "griCotejar";
            this.griCotejar.Size = new System.Drawing.Size(280, 265);
            this.griCotejar.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoE,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoE
            // 
            this.lblEstadoE.Name = "lblEstadoE";
            this.lblEstadoE.Size = new System.Drawing.Size(45, 17);
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
            this.ClientSize = new System.Drawing.Size(763, 349);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.griCotejar);
            this.Controls.Add(this.cmdCotejar);
            this.Controls.Add(this.griConfig);
            this.Controls.Add(this.griCs);
            this.Controls.Add(this.cmdProcesarCarpeta);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.txtConfig);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Comprobador CS vs Config";
            ((System.ComponentModel.ISupportInitialize)(this.griCs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button cmdCarpeta;
        private System.Windows.Forms.Button cmdConfig;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdProcesarCarpeta;
        private System.Windows.Forms.DataGridView griCs;
        private System.Windows.Forms.DataGridView griConfig;
        private System.Windows.Forms.Button cmdCotejar;
        private System.Windows.Forms.DataGridView griCotejar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoE;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}

