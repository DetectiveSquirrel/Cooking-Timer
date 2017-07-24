using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Cooking_Timer
{
    public partial class CookingTimerForm : Form
    {
        public Timer timer { get; private set; }
        public int hours;
        public int minutes;
        public int seconds;
        public int starthours;
        public int startminutes;
        public int startseconds;


        public CookingTimerForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Tick += new EventHandler(TimerTick);
                timer.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer.Stop();
                timer.Tick -= new EventHandler(TimerTick);
                button1.Text = "Start";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(TimerTick);

            hours = starthours;
            minutes = startminutes;
            seconds = startseconds;

            SetText(starthours, startminutes, startseconds);
            progressBar1.Value = 0;

            button1.Text = "Start";
        }

        public void CountDown(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            starthours = this.hours;
            startminutes = this.minutes;
            startseconds = this.seconds;

            SetText();
        }

        public void TimerTick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds < 0)
            {
                seconds = 59;
                minutes--;
                if (minutes < 0)
                {
                    minutes = 59;
                    hours--;
                    if (hours < 0)
                    {
                        hours = 0;
                        minutes = 0;
                        seconds = 0;

                        // remove event handler
                        timer.Tick -= new EventHandler(TimerTick);
                    }
                }
            }

            SetText();
            double current = ((hours * 60 * 60) + (minutes * 60) + (seconds));
            double start = ((starthours * 60 * 60) + (startminutes * 60) + (startseconds));
            double percent = (current / start) * 100.0;
            
            progressBar1.Value = (int)percent;
        }

        public void SetText()
        {
            BigTimer.Text = string.Format("{0}:{1}:{2}",
                hours.ToString().PadLeft(2, '0'),
                minutes.ToString().PadLeft(2, '0'),
                seconds.ToString().PadLeft(2, '0'));

            this.Text = string.Format("{0}:{1}:{2} - Cooking Timer",
                hours.ToString().PadLeft(2, '0'),
                minutes.ToString().PadLeft(2, '0'),
                seconds.ToString().PadLeft(2, '0'));
        }

        public void SetText(int hours, int minutes, int seconds)
        {
            BigTimer.Text = string.Format("{0}:{1}:{2}",
                this.hours.ToString().PadLeft(2, '0'),
                this.minutes.ToString().PadLeft(2, '0'),
                this.seconds.ToString().PadLeft(2, '0'));

            this.Text = string.Format("{0}:{1}:{2} - Cooking Timer",
                this.hours.ToString().PadLeft(2, '0'),
                this.minutes.ToString().PadLeft(2, '0'),
                this.seconds.ToString().PadLeft(2, '0'));
        }

        public void MinuteRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioChanged();
        }

        public void RadioChanged()
        {
            bool CustomChecked = false;
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Tick -= new EventHandler(TimerTick);
            }

            if (MinuteRadio3.Checked == true)
            {
                BigTimer.Text = "00:03:00";
                CountDown(0, 3, 0);
            }
            else if (MinuteRadio5.Checked == true)
            {
                BigTimer.Text = "00:05:00";
                CountDown(0, 5, 0);
            }
            else if (MinuteRadio10.Checked == true)
            {
                BigTimer.Text = "00:10:00";
                CountDown(0, 10, 0);
            }
            else if (MinuteRadio15.Checked == true)
            {
                BigTimer.Text = "00:15:00";
                CountDown(0, 15, 0);
            }
            else if (MinuteRadioCustom.Checked == true)
            {
                SetText((int)HourUpDown.Value, (int)MinuteUpDown.Value, (int)SecondUpDown.Value);
                CountDown((int)HourUpDown.Value, (int)MinuteUpDown.Value, (int)SecondUpDown.Value);
                CustomChecked = true;
            }

            HoursMinutesSecondsEnabled(CustomChecked);
            button1.Text = "Start";
            progressBar1.Value = 0;
        }

        public void HoursMinutesSecondsEnabled(bool visable)
        {
            if (visable)
            {
                HourUpDown.Enabled = true;
                MinuteUpDown.Enabled = true;
                SecondUpDown.Enabled = true;
            }
            else if (!visable)
            {
                HourUpDown.Enabled = false;
                MinuteUpDown.Enabled = false;
                SecondUpDown.Enabled = false;
            }
        }

        public void HourUpDown_ValueChanged(object sender, EventArgs e)
        {
            hours = (int)HourUpDown.Value;
            RadioChanged();
        }

        public void MinuteUpDown_ValueChanged(object sender, EventArgs e)
        {
            minutes = (int)MinuteUpDown.Value;
            RadioChanged();
        }

        public void SecondUpDown_ValueChanged(object sender, EventArgs e)
        {
            seconds = (int)SecondUpDown.Value;
            RadioChanged();
        }
    }
}
