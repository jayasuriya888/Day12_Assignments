namespace CardWin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.txtccv = new System.Windows.Forms.TextBox();
            this.txtcard = new System.Windows.Forms.TextBox();
            this.btntrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "ccv no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "card no";
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(307, 261);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(274, 32);
            this.txtamt.TabIndex = 10;
            // 
            // txtccv
            // 
            this.txtccv.Location = new System.Drawing.Point(307, 177);
            this.txtccv.Name = "txtccv";
            this.txtccv.Size = new System.Drawing.Size(274, 32);
            this.txtccv.TabIndex = 9;
            // 
            // txtcard
            // 
            this.txtcard.Location = new System.Drawing.Point(307, 86);
            this.txtcard.Name = "txtcard";
            this.txtcard.Size = new System.Drawing.Size(274, 32);
            this.txtcard.TabIndex = 8;
            // 
            // btntrans
            // 
            this.btntrans.Location = new System.Drawing.Point(196, 373);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(227, 37);
            this.btntrans.TabIndex = 7;
            this.btntrans.Text = "transaction";
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.txtccv);
            this.Controls.Add(this.txtcard);
            this.Controls.Add(this.btntrans);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.TextBox txtccv;
        private System.Windows.Forms.TextBox txtcard;
        private System.Windows.Forms.Button btntrans;
    }
}

