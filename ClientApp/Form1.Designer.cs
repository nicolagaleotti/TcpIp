namespace ClientApp
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
            this.connectbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.statustxt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(655, 9);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(117, 20);
            this.connectbtn.TabIndex = 12;
            this.connectbtn.Text = "CONNESSIONE";
            this.connectbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PORT";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(102, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(147, 20);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOST";
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(655, 199);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(117, 20);
            this.sendbtn.TabIndex = 14;
            this.sendbtn.Text = "SEND";
            this.sendbtn.UseVisualStyleBackColor = true;
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(15, 64);
            this.statustxt.Multiline = true;
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(757, 103);
            this.statustxt.TabIndex = 13;
            // 
            // statustxt1
            // 
            this.statustxt1.Location = new System.Drawing.Point(15, 240);
            this.statustxt1.Multiline = true;
            this.statustxt1.Name = "statustxt1";
            this.statustxt1.Size = new System.Drawing.Size(757, 103);
            this.statustxt1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statustxt1);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.TextBox statustxt1;
    }
}

