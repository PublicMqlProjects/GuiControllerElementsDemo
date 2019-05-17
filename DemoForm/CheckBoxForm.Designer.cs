namespace DemoForm
{
    partial class CheckBoxForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBPUSDProfit = new System.Windows.Forms.CheckBox();
            this.GBPUSDStop = new System.Windows.Forms.CheckBox();
            this.GBPUSDEnable = new System.Windows.Forms.CheckBox();
            this.EURUSDStop = new System.Windows.Forms.CheckBox();
            this.EURUSDProfit = new System.Windows.Forms.CheckBox();
            this.EURUSDEnable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.GBPUSDProfit);
            this.groupBox1.Controls.Add(this.GBPUSDStop);
            this.groupBox1.Controls.Add(this.GBPUSDEnable);
            this.groupBox1.Controls.Add(this.EURUSDStop);
            this.groupBox1.Controls.Add(this.EURUSDProfit);
            this.groupBox1.Controls.Add(this.EURUSDEnable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Trading Options:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBPUSDProfit
            // 
            this.GBPUSDProfit.AutoSize = true;
            this.GBPUSDProfit.Location = new System.Drawing.Point(43, 111);
            this.GBPUSDProfit.Name = "GBPUSDProfit";
            this.GBPUSDProfit.Size = new System.Drawing.Size(101, 17);
            this.GBPUSDProfit.TabIndex = 7;
            this.GBPUSDProfit.Text = "Allow take profit";
            this.GBPUSDProfit.UseVisualStyleBackColor = true;
            // 
            // GBPUSDStop
            // 
            this.GBPUSDStop.AutoSize = true;
            this.GBPUSDStop.Location = new System.Drawing.Point(43, 134);
            this.GBPUSDStop.Name = "GBPUSDStop";
            this.GBPUSDStop.Size = new System.Drawing.Size(95, 17);
            this.GBPUSDStop.TabIndex = 5;
            this.GBPUSDStop.Text = "Allow stop loss";
            this.GBPUSDStop.UseVisualStyleBackColor = true;
            // 
            // GBPUSDEnable
            // 
            this.GBPUSDEnable.AutoSize = true;
            this.GBPUSDEnable.Location = new System.Drawing.Point(6, 88);
            this.GBPUSDEnable.Name = "GBPUSDEnable";
            this.GBPUSDEnable.Size = new System.Drawing.Size(166, 17);
            this.GBPUSDEnable.TabIndex = 3;
            this.GBPUSDEnable.Text = "Enable Trading On GBPUSD:";
            this.GBPUSDEnable.UseVisualStyleBackColor = true;
            // 
            // EURUSDStop
            // 
            this.EURUSDStop.AutoSize = true;
            this.EURUSDStop.Location = new System.Drawing.Point(43, 65);
            this.EURUSDStop.Name = "EURUSDStop";
            this.EURUSDStop.Size = new System.Drawing.Size(95, 17);
            this.EURUSDStop.TabIndex = 2;
            this.EURUSDStop.Text = "Allow stop loss";
            this.EURUSDStop.UseVisualStyleBackColor = true;
            // 
            // EURUSDProfit
            // 
            this.EURUSDProfit.AutoSize = true;
            this.EURUSDProfit.Location = new System.Drawing.Point(43, 42);
            this.EURUSDProfit.Name = "EURUSDProfit";
            this.EURUSDProfit.Size = new System.Drawing.Size(101, 17);
            this.EURUSDProfit.TabIndex = 1;
            this.EURUSDProfit.Text = "Allow take profit";
            this.EURUSDProfit.UseVisualStyleBackColor = true;
            // 
            // EURUSDEnable
            // 
            this.EURUSDEnable.AutoSize = true;
            this.EURUSDEnable.Location = new System.Drawing.Point(6, 19);
            this.EURUSDEnable.Name = "EURUSDEnable";
            this.EURUSDEnable.Size = new System.Drawing.Size(167, 17);
            this.EURUSDEnable.TabIndex = 0;
            this.EURUSDEnable.Text = "Enable Trading On EURUSD:";
            this.EURUSDEnable.UseVisualStyleBackColor = true;
            // 
            // CheckBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(212, 182);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CheckBoxForm";
            this.Text = "Demonstration of element \'CheckBox\'";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox GBPUSDProfit;
        private System.Windows.Forms.CheckBox GBPUSDStop;
        private System.Windows.Forms.CheckBox GBPUSDEnable;
        private System.Windows.Forms.CheckBox EURUSDStop;
        private System.Windows.Forms.CheckBox EURUSDProfit;
        private System.Windows.Forms.CheckBox EURUSDEnable;
    }
}