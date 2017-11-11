namespace WindowsFormsApp1
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
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(501, 29);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(136, 96);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 359);
            this.Controls.Add(this.placeOrderBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button placeOrderBtn;
    }
}

