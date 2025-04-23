using System;
using System.Drawing;
using System.Windows.Forms; // For Windows Forms components

namespace WindowsFormsAlarmApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Use Windows Forms Timer explicitly
        private string targetTime;

        public Form1()
        {
            InitializeComponent();
            // Initialize Timer for 1-second intervals.
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            targetTime = timeTextBox.Text; // User input in HH:MM:SS format.
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // Change background color every second.
            this.BackColor = GetRandomColor();
            if (currentTime.Equals(targetTime))
            {
                timer.Stop();
                MessageBox.Show("Alarm! Target time reached.", "Alarm");
            }
        }

        private Color GetRandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}
