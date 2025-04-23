namespace WindowsFormsAlarmApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button startButton;

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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(30, 30);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 22);
            this.timeTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(250, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Alarm";
            this.startButton.UseVisualStyleBackColor = true;
            // Attach the click event handler.
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeTextBox);
            this.Name = "Form1";
            this.Text = "Alarm Application";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
