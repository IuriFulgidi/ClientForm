
namespace ClientForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.btnInvia = new System.Windows.Forms.Button();
            this.lstMsgs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConnessione = new System.Windows.Forms.Label();
            this.imgConnesso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgConnesso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Messaggio";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(48, 35);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(101, 20);
            this.txtIp.TabIndex = 3;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(199, 35);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(101, 20);
            this.txtPorta.TabIndex = 4;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(81, 113);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(331, 20);
            this.txtMsg.TabIndex = 5;
            // 
            // btnConnetti
            // 
            this.btnConnetti.Location = new System.Drawing.Point(433, 33);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(75, 23);
            this.btnConnetti.TabIndex = 6;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(433, 110);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 7;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // lstMsgs
            // 
            this.lstMsgs.FormattingEnabled = true;
            this.lstMsgs.Location = new System.Drawing.Point(28, 156);
            this.lstMsgs.Name = "lstMsgs";
            this.lstMsgs.Size = new System.Drawing.Size(480, 212);
            this.lstMsgs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inserire le informazioni del server con cui ocnnettersi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(25, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Digitare il messaggio da inviare al server";
            // 
            // lblConnessione
            // 
            this.lblConnessione.AutoSize = true;
            this.lblConnessione.Location = new System.Drawing.Point(306, 43);
            this.lblConnessione.Name = "lblConnessione";
            this.lblConnessione.Size = new System.Drawing.Size(76, 13);
            this.lblConnessione.TabIndex = 12;
            this.lblConnessione.Text = "Non connesso";
            // 
            // imgConnesso
            // 
            this.imgConnesso.ErrorImage = null;
            this.imgConnesso.Location = new System.Drawing.Point(389, 33);
            this.imgConnesso.Name = "imgConnesso";
            this.imgConnesso.Size = new System.Drawing.Size(23, 23);
            this.imgConnesso.TabIndex = 13;
            this.imgConnesso.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 395);
            this.Controls.Add(this.imgConnesso);
            this.Controls.Add(this.lblConnessione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstMsgs);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.btnConnetti);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgConnesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.ListBox lstMsgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConnessione;
        private System.Windows.Forms.PictureBox imgConnesso;
    }
}

