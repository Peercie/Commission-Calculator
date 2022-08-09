namespace Commission_Calculator
{
    partial class frmMain
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
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblEarned = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtbxRevenue = new System.Windows.Forms.TextBox();
            this.txtbxCommission = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(13, 34);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(78, 13);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Revenue Sale:";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(13, 74);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(123, 13);
            this.lblCommission.TabIndex = 1;
            this.lblCommission.Text = "Commission Percentage:";
            // 
            // lblEarned
            // 
            this.lblEarned.AutoSize = true;
            this.lblEarned.Location = new System.Drawing.Point(13, 141);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(101, 13);
            this.lblEarned.TabIndex = 2;
            this.lblEarned.Text = "Earned commission:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(120, 141);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // txtbxRevenue
            // 
            this.txtbxRevenue.Location = new System.Drawing.Point(142, 34);
            this.txtbxRevenue.Name = "txtbxRevenue";
            this.txtbxRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtbxRevenue.TabIndex = 4;
            // 
            // txtbxCommission
            // 
            this.txtbxCommission.Location = new System.Drawing.Point(142, 71);
            this.txtbxCommission.Name = "txtbxCommission";
            this.txtbxCommission.Size = new System.Drawing.Size(100, 20);
            this.txtbxCommission.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 176);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(123, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 252);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbxCommission);
            this.Controls.Add(this.txtbxRevenue);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEarned);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblRevenue);
            this.Name = "frmMain";
            this.Text = "Salesperson’s Commission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Label lblEarned;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtbxRevenue;
        private System.Windows.Forms.TextBox txtbxCommission;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

