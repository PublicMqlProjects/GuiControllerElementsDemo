namespace DemoForm
{
    partial class NumericForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.StopLoss = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TakeProfit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.StopLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StopLoss:";
            // 
            // StopLoss
            // 
            this.StopLoss.DecimalPlaces = 4;
            this.StopLoss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.StopLoss.Location = new System.Drawing.Point(89, 7);
            this.StopLoss.Name = "StopLoss";
            this.StopLoss.Size = new System.Drawing.Size(120, 20);
            this.StopLoss.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TakeProfit:";
            // 
            // TakeProfit
            // 
            this.TakeProfit.DecimalPlaces = 4;
            this.TakeProfit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.TakeProfit.Location = new System.Drawing.Point(89, 51);
            this.TakeProfit.Name = "TakeProfit";
            this.TakeProfit.Size = new System.Drawing.Size(120, 20);
            this.TakeProfit.TabIndex = 3;
            // 
            // NumericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 95);
            this.Controls.Add(this.TakeProfit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StopLoss);
            this.Controls.Add(this.label1);
            this.Name = "NumericForm";
            this.Text = "NumericForm";
            ((System.ComponentModel.ISupportInitialize)(this.StopLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StopLoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TakeProfit;
    }
}