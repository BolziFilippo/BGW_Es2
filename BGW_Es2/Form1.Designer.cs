namespace BGW_Es2
{
    partial class frm_Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_S2 = new System.Windows.Forms.Button();
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.btn_A100 = new System.Windows.Forms.Button();
            this.btn_S100 = new System.Windows.Forms.Button();
            this.txt_box2 = new System.Windows.Forms.TextBox();
            this.bgw3 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_A2
            // 
            this.btn_A2.Location = new System.Drawing.Point(12, 34);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(76, 23);
            this.btn_A2.TabIndex = 0;
            this.btn_A2.Text = "Avvio 2";
            this.btn_A2.UseVisualStyleBackColor = true;
            this.btn_A2.Click += new System.EventHandler(this.btn_A2_Click);
            // 
            // btn_S2
            // 
            this.btn_S2.Location = new System.Drawing.Point(12, 73);
            this.btn_S2.Name = "btn_S2";
            this.btn_S2.Size = new System.Drawing.Size(76, 23);
            this.btn_S2.TabIndex = 1;
            this.btn_S2.Text = "Stop 2";
            this.btn_S2.UseVisualStyleBackColor = true;
            this.btn_S2.Click += new System.EventHandler(this.btn_S2_Click);
            // 
            // txt_box1
            // 
            this.txt_box1.Location = new System.Drawing.Point(110, 24);
            this.txt_box1.Multiline = true;
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(100, 340);
            this.txt_box1.TabIndex = 2;
            this.txt_box1.TextChanged += new System.EventHandler(this.txt_box1_TextChanged);
            // 
            // btn_A100
            // 
            this.btn_A100.Location = new System.Drawing.Point(376, 34);
            this.btn_A100.Name = "btn_A100";
            this.btn_A100.Size = new System.Drawing.Size(76, 23);
            this.btn_A100.TabIndex = 3;
            this.btn_A100.Text = "Avvio 100";
            this.btn_A100.UseVisualStyleBackColor = true;
            this.btn_A100.Click += new System.EventHandler(this.btn_A100_Click);
            // 
            // btn_S100
            // 
            this.btn_S100.Location = new System.Drawing.Point(377, 73);
            this.btn_S100.Name = "btn_S100";
            this.btn_S100.Size = new System.Drawing.Size(75, 23);
            this.btn_S100.TabIndex = 4;
            this.btn_S100.Text = "Stop 100";
            this.btn_S100.UseVisualStyleBackColor = true;
            this.btn_S100.Click += new System.EventHandler(this.btn_S100_Click);
            // 
            // txt_box2
            // 
            this.txt_box2.Location = new System.Drawing.Point(506, 24);
            this.txt_box2.Multiline = true;
            this.txt_box2.Name = "txt_box2";
            this.txt_box2.Size = new System.Drawing.Size(100, 340);
            this.txt_box2.TabIndex = 5;
            // 
            // bgw3
            // 
            this.bgw3.WorkerReportsProgress = true;
            this.bgw3.WorkerSupportsCancellation = true;
            this.bgw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw1_DoWork);
            this.bgw3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw1_ProgressChanged);
            this.bgw3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw1_RunWorkerCompleted);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_box2);
            this.Controls.Add(this.btn_S100);
            this.Controls.Add(this.btn_A100);
            this.Controls.Add(this.txt_box1);
            this.Controls.Add(this.btn_S2);
            this.Controls.Add(this.btn_A2);
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_S2;
        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.Button btn_A100;
        private System.Windows.Forms.Button btn_S100;
        private System.Windows.Forms.TextBox txt_box2;
        private System.ComponentModel.BackgroundWorker bgw;
    }
}

