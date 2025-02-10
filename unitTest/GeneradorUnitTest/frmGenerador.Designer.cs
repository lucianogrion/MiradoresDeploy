namespace GeneradorUnitTest
{
    partial class frmGenerador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoE = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdProcesarCarpeta
            // 
            this.cmdProcesarCarpeta.Location = new System.Drawing.Point(181, 50);
            this.cmdProcesarCarpeta.Name = "cmdProcesarCarpeta";
            this.cmdProcesarCarpeta.Size = new System.Drawing.Size(75, 49);
            this.cmdProcesarCarpeta.TabIndex = 12;
            this.cmdProcesarCarpeta.Text = "Procesar DLL";
            this.cmdProcesarCarpeta.UseVisualStyleBackColor = true;
            this.cmdProcesarCarpeta.Click += new System.EventHandler(this.cmdProcesarCarpeta_Click);
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.Location = new System.Drawing.Point(12, 21);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(244, 23);
            this.cmdCarpeta.TabIndex = 11;
            this.cmdCarpeta.Text = "Seleccionar DLL";
            this.cmdCarpeta.UseVisualStyleBackColor = true;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(12, 50);
            this.txtCarpeta.Multiline = true;
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(164, 49);
            this.txtCarpeta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Claves Necesarias";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 119);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(615, 227);
            this.txtResult.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoE,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(639, 22);
            this.statusStrip1.TabIndex = 14;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 78);
            this.button1.TabIndex = 17;
            this.button1.Text = "Procesar CS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGenerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmdProcesarCarpeta);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.label1);
            this.Name = "frmGenerador";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProcesarCarpeta;
        private System.Windows.Forms.Button cmdCarpeta;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoE;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

