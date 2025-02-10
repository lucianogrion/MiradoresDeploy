namespace MiradorConfig
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoE = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.griCotejar = new System.Windows.Forms.DataGridView();
            this.cmdCotejar = new System.Windows.Forms.Button();
            this.griConfigDestino = new System.Windows.Forms.DataGridView();
            this.griConfigOrigen = new System.Windows.Forms.DataGridView();
            this.cmdConfigDestino = new System.Windows.Forms.Button();
            this.txtConfigDestino = new System.Windows.Forms.TextBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdConfigOrigen = new System.Windows.Forms.Button();
            this.txtConfigOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoE,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 24;
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
            // griCotejar
            // 
            this.griCotejar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griCotejar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griCotejar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griCotejar.Location = new System.Drawing.Point(565, 41);
            this.griCotejar.Name = "griCotejar";
            this.griCotejar.Size = new System.Drawing.Size(285, 281);
            this.griCotejar.TabIndex = 23;
            // 
            // cmdCotejar
            // 
            this.cmdCotejar.Location = new System.Drawing.Point(565, 12);
            this.cmdCotejar.Name = "cmdCotejar";
            this.cmdCotejar.Size = new System.Drawing.Size(285, 23);
            this.cmdCotejar.TabIndex = 22;
            this.cmdCotejar.Text = "Cotejar Valores ";
            this.cmdCotejar.UseVisualStyleBackColor = true;
            this.cmdCotejar.Click += new System.EventHandler(this.cmdCotejar_Click);
            // 
            // griConfigDestino
            // 
            this.griConfigDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griConfigDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griConfigDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griConfigDestino.Location = new System.Drawing.Point(292, 109);
            this.griConfigDestino.Name = "griConfigDestino";
            this.griConfigDestino.Size = new System.Drawing.Size(267, 213);
            this.griConfigDestino.TabIndex = 21;
            // 
            // griConfigOrigen
            // 
            this.griConfigOrigen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.griConfigOrigen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.griConfigOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griConfigOrigen.Location = new System.Drawing.Point(12, 109);
            this.griConfigOrigen.Name = "griConfigOrigen";
            this.griConfigOrigen.Size = new System.Drawing.Size(274, 213);
            this.griConfigOrigen.TabIndex = 20;
            this.griConfigOrigen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griCs_CellContentClick);
            // 
            // cmdConfigDestino
            // 
            this.cmdConfigDestino.Location = new System.Drawing.Point(292, 12);
            this.cmdConfigDestino.Name = "cmdConfigDestino";
            this.cmdConfigDestino.Size = new System.Drawing.Size(267, 23);
            this.cmdConfigDestino.TabIndex = 18;
            this.cmdConfigDestino.Text = "Seleccione .Config COMPLETO";
            this.cmdConfigDestino.UseVisualStyleBackColor = true;
            this.cmdConfigDestino.Click += new System.EventHandler(this.cmdConfigDestino_Click);
            // 
            // txtConfigDestino
            // 
            this.txtConfigDestino.Location = new System.Drawing.Point(292, 41);
            this.txtConfigDestino.Multiline = true;
            this.txtConfigDestino.Name = "txtConfigDestino";
            this.txtConfigDestino.ReadOnly = true;
            this.txtConfigDestino.Size = new System.Drawing.Size(267, 49);
            this.txtConfigDestino.TabIndex = 17;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(377, 93);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(87, 13);
            this.lblConfig.TabIndex = 16;
            this.lblConfig.Text = "Claves en Config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-209, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Claves Necesarias";
            // 
            // cmdConfigOrigen
            // 
            this.cmdConfigOrigen.Location = new System.Drawing.Point(7, 12);
            this.cmdConfigOrigen.Name = "cmdConfigOrigen";
            this.cmdConfigOrigen.Size = new System.Drawing.Size(279, 23);
            this.cmdConfigOrigen.TabIndex = 26;
            this.cmdConfigOrigen.Text = "Seleccione .Config SOSPECHOSO";
            this.cmdConfigOrigen.UseVisualStyleBackColor = true;
            this.cmdConfigOrigen.Click += new System.EventHandler(this.cmdConfigOrigen_Click);
            // 
            // txtConfigOrigen
            // 
            this.txtConfigOrigen.Location = new System.Drawing.Point(7, 41);
            this.txtConfigOrigen.Multiline = true;
            this.txtConfigOrigen.Name = "txtConfigOrigen";
            this.txtConfigOrigen.ReadOnly = true;
            this.txtConfigOrigen.Size = new System.Drawing.Size(279, 49);
            this.txtConfigOrigen.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Claves en Config";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdConfigOrigen);
            this.Controls.Add(this.txtConfigOrigen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.griCotejar);
            this.Controls.Add(this.cmdCotejar);
            this.Controls.Add(this.griConfigDestino);
            this.Controls.Add(this.griConfigOrigen);
            this.Controls.Add(this.cmdConfigDestino);
            this.Controls.Add(this.txtConfigDestino);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Comparador Config vs Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griCotejar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griConfigOrigen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoE;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.DataGridView griCotejar;
        private System.Windows.Forms.Button cmdCotejar;
        private System.Windows.Forms.DataGridView griConfigDestino;
        private System.Windows.Forms.DataGridView griConfigOrigen;
        private System.Windows.Forms.Button cmdConfigDestino;
        private System.Windows.Forms.TextBox txtConfigDestino;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdConfigOrigen;
        private System.Windows.Forms.TextBox txtConfigOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

