using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Media;

namespace Cooking_Timer
{
    public partial class CookingTimerForm : Form
    {
        public Timer timer { get; private set; }
        public Timer timerSound { get; private set; }
        public int hours;
        public int minutes;
        public int seconds;
        public int startHours;
        public int startMinutes;
        public int startSeconds;
        public bool Fininshed = false;


        public CookingTimerForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timerSound = new Timer();
            timerSound.Interval = 10;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Tick += new EventHandler(TimerTick);
                timerSound.Tick += new EventHandler(TimerTickSound);
                timer.Start();
                timerSound.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer.Stop();
                timerSound.Stop();
                timer.Tick -= new EventHandler(TimerTick);
                timerSound.Tick -= new EventHandler(TimerTickSound);
                button1.Text = "Start";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerSound.Stop();
            timer.Tick -= new EventHandler(TimerTick);
            timerSound.Tick -= new EventHandler(TimerTickSound);

            hours = startHours;
            minutes = startMinutes;
            seconds = startSeconds;

            SetText(startHours, startMinutes, startSeconds);
            progressBar1.Value = 0;

            button1.Text = "Start";
        }

        public void CountDown(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            startHours = this.hours;
            startMinutes = this.minutes;
            startSeconds = this.seconds;

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
                        if (AutoRestart.Checked)
                        {
                            hours = startHours;
                            minutes = startMinutes;
                            seconds = startSeconds;

                            timerSound.Tick += new EventHandler(TimerTickSound);
                            timerSound.Start();
                        }
                        else
                        {
                            hours = startHours;
                            minutes = startMinutes;
                            seconds = startSeconds;

                            // remove event handler
                            timer.Tick -= new EventHandler(TimerTick);
                            button1.Text = "Start";
                            Fininshed = true;
                        }
                    }
                }
            }

            SetText();
            double current = ((hours * 60 * 60) + (minutes * 60) + (seconds));
            double start = ((startHours * 60 * 60) + (startMinutes * 60) + (startSeconds));
            double percent = (current / start) * 100.0;

            progressBar1.Value = (int)percent;
            if (Fininshed)
            {
                progressBar1.Value = 0;
                Fininshed = false;
            }
        }

        public void TimerTickSound(object sender, EventArgs e)
        {
            if (hours + minutes + seconds == 0)
            {

                playaudio();

                // remove event handler
                timerSound.Tick -= new EventHandler(TimerTickSound);
            }

            if (hours + minutes + seconds == startHours + startMinutes + startSeconds)
            {

                double current = ((hours * 60 * 60) + (minutes * 60) + (seconds));
                double start = ((startHours * 60 * 60) + (startMinutes * 60) + (startSeconds));
                double percent = (current / start) * 100.0;

                progressBar1.Value = (int)percent;
            }
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

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.Chime); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
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
                timerSound.Stop();
                timer.Tick -= new EventHandler(TimerTick);
                timerSound.Tick -= new EventHandler(TimerTickSound);
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

        private void CookingTimerForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.AlwaysOnTop = checkBox1.Checked;

            Properties.Settings.Default.Save();
        }

        public void LoadSettings()
        {
            TopMost = Properties.Settings.Default.AlwaysOnTop;
            checkBox1.Checked = Properties.Settings.Default.AlwaysOnTop;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
            SaveSettings();
        }
    }
}
