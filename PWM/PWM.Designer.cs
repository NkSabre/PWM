namespace PWM
{
    partial class PWM
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lOne = new System.Windows.Forms.Label();
            this.vOne = new System.Windows.Forms.Label();
            this.lCurrent = new System.Windows.Forms.Label();
            this.vCurrent = new System.Windows.Forms.Label();
            this.lNew = new System.Windows.Forms.Label();
            this.tNew = new System.Windows.Forms.TextBox();
            this.bSet = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lOne);
            this.flowLayoutPanel1.Controls.Add(this.vOne);
            this.flowLayoutPanel1.Controls.Add(this.lCurrent);
            this.flowLayoutPanel1.Controls.Add(this.vCurrent);
            this.flowLayoutPanel1.Controls.Add(this.lNew);
            this.flowLayoutPanel1.Controls.Add(this.tNew);
            this.flowLayoutPanel1.Controls.Add(this.bSet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lOne
            // 
            this.lOne.AutoSize = true;
            this.lOne.Location = new System.Drawing.Point(2, 0);
            this.lOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOne.Name = "lOne";
            this.lOne.Size = new System.Drawing.Size(71, 18);
            this.lOne.TabIndex = 5;
            this.lOne.Text = "Value 1";
            // 
            // vOne
            // 
            this.vOne.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.vOne, true);
            this.vOne.Location = new System.Drawing.Point(77, 0);
            this.vOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vOne.Name = "vOne";
            this.vOne.Size = new System.Drawing.Size(35, 18);
            this.vOne.TabIndex = 6;
            this.vOne.Text = "???";
            // 
            // lCurrent
            // 
            this.lCurrent.AutoSize = true;
            this.lCurrent.Location = new System.Drawing.Point(2, 18);
            this.lCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Size = new System.Drawing.Size(71, 18);
            this.lCurrent.TabIndex = 0;
            this.lCurrent.Text = "Current";
            // 
            // vCurrent
            // 
            this.vCurrent.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.vCurrent, true);
            this.vCurrent.Location = new System.Drawing.Point(77, 18);
            this.vCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vCurrent.Name = "vCurrent";
            this.vCurrent.Size = new System.Drawing.Size(35, 18);
            this.vCurrent.TabIndex = 1;
            this.vCurrent.Text = "???";
            // 
            // lNew
            // 
            this.lNew.AutoSize = true;
            this.lNew.Location = new System.Drawing.Point(2, 36);
            this.lNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(35, 18);
            this.lNew.TabIndex = 2;
            this.lNew.Text = "New";
            // 
            // tNew
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.tNew, true);
            this.tNew.Location = new System.Drawing.Point(41, 38);
            this.tNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNew.Name = "tNew";
            this.tNew.Size = new System.Drawing.Size(83, 28);
            this.tNew.TabIndex = 3;
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(2, 70);
            this.bSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(83, 28);
            this.bSet.TabIndex = 4;
            this.bSet.Text = "Set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // PWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 99);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PWM";
            this.Text = "PWM";
            this.Load += new System.EventHandler(this.PWM_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lCurrent;
        private System.Windows.Forms.Label vCurrent;
        private System.Windows.Forms.Label lNew;
        private System.Windows.Forms.TextBox tNew;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label lOne;
        private System.Windows.Forms.Label vOne;
    }
}

