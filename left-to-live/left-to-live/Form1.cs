using System;
using System.Windows.Forms;

namespace left_to_live
{
    public partial class App : Form
    {
        DateTime birthDateValue;  // Variable to store the selected birth date
        public App()
        {
            InitializeComponent();
            birthDate.Format = DateTimePickerFormat.Custom;
            birthDate.CustomFormat = "dd/MM/yyyy";
            //birthDate.KeyUp += new KeyEventHandler(birthDate_KeyUp);
        }

        private void App_Load(object sender, EventArgs e)
        {
            DisplayAverageLifespan();
            CalculateWeeksLived();
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {
            birthDateValue = birthDate.Value;  // Save the selected birth date
            CalculateWeeksLived();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CalculateWeeksLived();
        }

        private void CalculateWeeksLived()
        {
            var timeSpan = DateTime.Now - birthDateValue;
            var weeks = timeSpan.TotalDays / 7;
            weeksLived.Text = $"{Math.Floor(weeks)} weeks lived";
            CalculateWeeksLeft();
        }

        private void CalculateWeeksLeft()
        {
            var averageLifespanInWeeks = 72.6 * 52;  // Approximate conversion from years to weeks
            var timeSpan = DateTime.Now - birthDateValue;
            var weeksLived = timeSpan.TotalDays / 7;
            var weeksLeft = averageLifespanInWeeks - weeksLived;
            leftToLive.Text = $"{Math.Floor(weeksLeft)} weeks left"; // $"You have approximately {Math.Floor(weeksLeft)} weeks left to live.";

            int totalWeeks = (int)(averageLifespanInWeeks);
            int livedPercentage = (int)((double)weeksLived / totalWeeks * 100);
            int leftPercentage = (int)((double)weeksLeft / totalWeeks * 100);

            progressBarLived.Value = Math.Max(0, Math.Min(100, livedPercentage));
            progressBarLeft.Value = Math.Max(0, Math.Min(100, leftPercentage));
        }

        private void DisplayAverageLifespan()
        {
            var averageLifespanInWeeks = 72.6 * 52;  // Approximate conversion from years to weeks
            leftToLive.Text = $"The average lifespan is about {Math.Floor(averageLifespanInWeeks)} weeks.";
        }

        // Add these lines to prevent errors due to these methods referenced in Form1.Designer.cs
        private void bornLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthDate_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                SendKeys.Send("{RIGHT}");
            }
        }

        private void weeksLived_Click(object sender, EventArgs e)
        {

        }

        private void weeksLived_Click_1(object sender, EventArgs e)
        {

        }

        private void App_Load_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
