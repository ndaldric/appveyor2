namespace Total_Sales
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.salesListbox = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(76, 113);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Total Cost";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // salesListbox
            // 
            this.salesListbox.FormattingEnabled = true;
            this.salesListbox.Location = new System.Drawing.Point(102, 12);
            this.salesListbox.Name = "salesListbox";
            this.salesListbox.Size = new System.Drawing.Size(120, 95);
            this.salesListbox.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(73, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(145, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.salesListbox);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ListBox salesListbox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

