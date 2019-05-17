namespace DemoForm
{
    partial class ButtonForm
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
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.IndianRed;
            this.btnSell.Location = new System.Drawing.Point(12, 25);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(139, 99);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuy.Location = new System.Drawing.Point(186, 25);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(132, 99);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(12, 139);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(306, 29);
            this.btnCancelAll.TabIndex = 2;
            this.btnCancelAll.Text = "Cancel All Pending Orders";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // ButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 180);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSell);
            this.MaximizeBox = false;
            this.Name = "ButtonForm";
            this.Text = "ButtonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCancelAll;
    }
}