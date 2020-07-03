using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace M318.Exercises.Nr5
{
    public partial class StopwatchForm : Form
    {
        private StopwatchStatus status = StopwatchStatus.Initial;

        private DateTime lapStartTime;
        private TimeSpan previousRunningTime;
        private TimeSpan previousLapTime;

        private const string TimeFormat = "mm':'ss'.'ff";

        public StopwatchForm()
        {
            InitializeComponent();
        }

        private void StartStopButtonClick(object sender, EventArgs e)
        {
            switch (status)
            {
                case StopwatchStatus.Initial:
                    StartTimer();
                    SetStatus(StopwatchStatus.Running);
                    break;
                case StopwatchStatus.Running:
                    StopTimer();
                    SetStatus(StopwatchStatus.Stopped);
                    break;
                case StopwatchStatus.Stopped:
                    StartTimer();
                    SetStatus(StopwatchStatus.Running);
                    break;
                default:
                    break;
            }
        }

        private void LapResetButtonClick(object sender, EventArgs e)
        {
            switch (status)
            {
                case StopwatchStatus.Running:
                    Lap();
                    break;
                case StopwatchStatus.Stopped:
                    Reset();
                    SetStatus(StopwatchStatus.Initial);
                    break;
                default:
                    break;
            }
        }

        private void RefreshTimerTick(object sender, EventArgs e)
        {
            var totalRunningTime = previousRunningTime + previousLapTime + (DateTime.Now - lapStartTime);
            timeDisplay.Text = totalRunningTime.ToString(TimeFormat);
        }

        private void StartTimer()
        {
            lapStartTime = DateTime.Now;
            refreshTimer.Start();
        }

        private void StopTimer()
        {
            previousLapTime = DateTime.Now - lapStartTime;
            lapStartTime = DateTime.MinValue;
            refreshTimer.Stop();
        }

        private void Lap()
        {
            var lapTime = DateTime.Now - lapStartTime + previousLapTime;
            lapStartTime = DateTime.Now;
            previousRunningTime += lapTime;
            previousLapTime = TimeSpan.Zero;

            var lapNumber = lapList.Items.Count + 1;
            lapList.Items.Insert(0, $"Lap {lapNumber:00}: {lapTime.ToString(TimeFormat)}");
        }

        private void Reset()
        {
            previousRunningTime = TimeSpan.Zero;
            previousLapTime = TimeSpan.Zero;
            lapStartTime = DateTime.MinValue;
            timeDisplay.Text = TimeSpan.Zero.ToString(TimeFormat);
            lapList.Items.Clear();
        }

        private void SetStatus(StopwatchStatus newStatus)
        {
            status = newStatus;

            switch (status)
            {
                case StopwatchStatus.Initial:
                    startStopButton.Text = "Start";
                    lapResetButton.Text = "Lap";
                    lapResetButton.Enabled = false;
                    break;
                case StopwatchStatus.Running:
                    startStopButton.Text = "Stop";
                    lapResetButton.Text = "Lap";
                    lapResetButton.Enabled = true;
                    break;
                case StopwatchStatus.Stopped:
                    startStopButton.Text = "Continue";
                    lapResetButton.Text = "Reset";
                    lapResetButton.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
