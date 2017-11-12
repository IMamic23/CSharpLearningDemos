namespace ACM.Win
{
    partial class PedometerMetrics
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
            this.pedometerCalculateBtn = new System.Windows.Forms.Button();
            this.stepGoalTb = new System.Windows.Forms.TextBox();
            this.stepsTodayTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pedometerCalculateBtn
            // 
            this.pedometerCalculateBtn.Location = new System.Drawing.Point(313, 27);
            this.pedometerCalculateBtn.Name = "pedometerCalculateBtn";
            this.pedometerCalculateBtn.Size = new System.Drawing.Size(123, 47);
            this.pedometerCalculateBtn.TabIndex = 0;
            this.pedometerCalculateBtn.Text = "Calculate";
            this.pedometerCalculateBtn.UseVisualStyleBackColor = true;
            this.pedometerCalculateBtn.Click += new System.EventHandler(this.pedometerCalculateBtn_Click);
            // 
            // stepGoalTb
            // 
            this.stepGoalTb.Location = new System.Drawing.Point(163, 27);
            this.stepGoalTb.Name = "stepGoalTb";
            this.stepGoalTb.Size = new System.Drawing.Size(128, 20);
            this.stepGoalTb.TabIndex = 1;
            this.stepGoalTb.TextChanged += new System.EventHandler(this.stepGoalTb_TextChanged);
            // 
            // stepsTodayTb
            // 
            this.stepsTodayTb.Location = new System.Drawing.Point(163, 54);
            this.stepsTodayTb.Name = "stepsTodayTb";
            this.stepsTodayTb.Size = new System.Drawing.Size(128, 20);
            this.stepsTodayTb.TabIndex = 2;
            this.stepsTodayTb.TextChanged += new System.EventHandler(this.stepsTodayTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step Goal For Today";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Steps Today";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 92);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 5;
            // 
            // Pedometer_Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 155);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stepsTodayTb);
            this.Controls.Add(this.stepGoalTb);
            this.Controls.Add(this.pedometerCalculateBtn);
            this.Name = "PedometerMetrics";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pedometerCalculateBtn;
        private System.Windows.Forms.TextBox stepGoalTb;
        private System.Windows.Forms.TextBox stepsTodayTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
    }
}