namespace Cooking_Timer
{
    partial class CookingTimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookingTimerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinuteRadioCustom = new System.Windows.Forms.RadioButton();
            this.MinuteRadio15 = new System.Windows.Forms.RadioButton();
            this.MinuteRadio10 = new System.Windows.Forms.RadioButton();
            this.MinuteRadio5 = new System.Windows.Forms.RadioButton();
            this.MinuteRadio3 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BigTimer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinuteRadioCustom);
            this.groupBox1.Controls.Add(this.MinuteRadio15);
            this.groupBox1.Controls.Add(this.MinuteRadio10);
            this.groupBox1.Controls.Add(this.MinuteRadio5);
            this.groupBox1.Controls.Add(this.MinuteRadio3);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presets";
            // 
            // MinuteRadioCustom
            // 
            this.MinuteRadioCustom.AutoSize = true;
            this.MinuteRadioCustom.Location = new System.Drawing.Point(247, 20);
            this.MinuteRadioCustom.Name = "MinuteRadioCustom";
            this.MinuteRadioCustom.Size = new System.Drawing.Size(60, 17);
            this.MinuteRadioCustom.TabIndex = 4;
            this.MinuteRadioCustom.TabStop = true;
            this.MinuteRadioCustom.Text = "Custom";
            this.MinuteRadioCustom.UseVisualStyleBackColor = true;
            this.MinuteRadioCustom.CheckedChanged += new System.EventHandler(this.MinuteRadio_CheckedChanged);
            // 
            // MinuteRadio15
            // 
            this.MinuteRadio15.AutoSize = true;
            this.MinuteRadio15.Location = new System.Drawing.Point(185, 20);
            this.MinuteRadio15.Name = "MinuteRadio15";
            this.MinuteRadio15.Size = new System.Drawing.Size(56, 17);
            this.MinuteRadio15.TabIndex = 3;
            this.MinuteRadio15.TabStop = true;
            this.MinuteRadio15.Text = "15 min";
            this.MinuteRadio15.UseVisualStyleBackColor = true;
            this.MinuteRadio15.CheckedChanged += new System.EventHandler(this.MinuteRadio_CheckedChanged);
            // 
            // MinuteRadio10
            // 
            this.MinuteRadio10.AutoSize = true;
            this.MinuteRadio10.Location = new System.Drawing.Point(123, 20);
            this.MinuteRadio10.Name = "MinuteRadio10";
            this.MinuteRadio10.Size = new System.Drawing.Size(56, 17);
            this.MinuteRadio10.TabIndex = 2;
            this.MinuteRadio10.TabStop = true;
            this.MinuteRadio10.Text = "10 min";
            this.MinuteRadio10.UseVisualStyleBackColor = true;
            this.MinuteRadio10.CheckedChanged += new System.EventHandler(this.MinuteRadio_CheckedChanged);
            // 
            // MinuteRadio5
            // 
            this.MinuteRadio5.AutoSize = true;
            this.MinuteRadio5.Location = new System.Drawing.Point(67, 20);
            this.MinuteRadio5.Name = "MinuteRadio5";
            this.MinuteRadio5.Size = new System.Drawing.Size(50, 17);
            this.MinuteRadio5.TabIndex = 1;
            this.MinuteRadio5.TabStop = true;
            this.MinuteRadio5.Text = "5 min";
            this.MinuteRadio5.UseVisualStyleBackColor = true;
            this.MinuteRadio5.CheckedChanged += new System.EventHandler(this.MinuteRadio_CheckedChanged);
            // 
            // MinuteRadio3
            // 
            this.MinuteRadio3.AutoSize = true;
            this.MinuteRadio3.Location = new System.Drawing.Point(11, 20);
            this.MinuteRadio3.Name = "MinuteRadio3";
            this.MinuteRadio3.Size = new System.Drawing.Size(50, 17);
            this.MinuteRadio3.TabIndex = 0;
            this.MinuteRadio3.TabStop = true;
            this.MinuteRadio3.Text = "3 min";
            this.MinuteRadio3.UseVisualStyleBackColor = true;
            this.MinuteRadio3.CheckedChanged += new System.EventHandler(this.MinuteRadio_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 158);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 46);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // BigTimer
            // 
            this.BigTimer.AutoSize = true;
            this.BigTimer.Font = new System.Drawing.Font("Roboto", 35F);
            this.BigTimer.Location = new System.Drawing.Point(65, 96);
            this.BigTimer.Name = "BigTimer";
            this.BigTimer.Size = new System.Drawing.Size(203, 57);
            this.BigTimer.TabIndex = 2;
            this.BigTimer.Text = "00:00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(338, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ring Forever";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Automatic Restart";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // HourUpDown
            // 
            this.HourUpDown.Enabled = false;
            this.HourUpDown.Location = new System.Drawing.Point(83, 73);
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.Size = new System.Drawing.Size(50, 20);
            this.HourUpDown.TabIndex = 4;
            this.HourUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HourUpDown.ValueChanged += new System.EventHandler(this.HourUpDown_ValueChanged);
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Enabled = false;
            this.MinuteUpDown.Location = new System.Drawing.Point(139, 73);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.Size = new System.Drawing.Size(50, 20);
            this.MinuteUpDown.TabIndex = 5;
            this.MinuteUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinuteUpDown.ValueChanged += new System.EventHandler(this.MinuteUpDown_ValueChanged);
            // 
            // SecondUpDown
            // 
            this.SecondUpDown.Enabled = false;
            this.SecondUpDown.Location = new System.Drawing.Point(195, 73);
            this.SecondUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondUpDown.Name = "SecondUpDown";
            this.SecondUpDown.Size = new System.Drawing.Size(50, 20);
            this.SecondUpDown.TabIndex = 6;
            this.SecondUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondUpDown.ValueChanged += new System.EventHandler(this.SecondUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seconds";
            // 
            // CookingTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondUpDown);
            this.Controls.Add(this.MinuteUpDown);
            this.Controls.Add(this.HourUpDown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BigTimer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CookingTimerForm";
            this.Text = "00:00:00 - Cooking Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MinuteRadioCustom;
        private System.Windows.Forms.RadioButton MinuteRadio15;
        private System.Windows.Forms.RadioButton MinuteRadio10;
        private System.Windows.Forms.RadioButton MinuteRadio5;
        private System.Windows.Forms.RadioButton MinuteRadio3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label BigTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown HourUpDown;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.NumericUpDown SecondUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

