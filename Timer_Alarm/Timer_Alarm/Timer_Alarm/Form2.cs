using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Alarm
{
    public partial class Form2 : Form
    {
        public Alarm NewAlarm;
        public bool DoneSuccsessfully;

        public bool inputCheck(string h,string m)
        {
            bool isCorrect = true;
            if(h.Length > 2 || m.Length > 2)
            {
                isCorrect = false;
            }
            try
            {
                int.Parse(h);
                int.Parse(m);
                if(int.Parse(h) > 23 || int.Parse(m) > 59)
                {
                    isCorrect = false;
                }
            }
            catch (FormatException)
            {
                isCorrect = false;
            }

            return isCorrect;
        }
        public Form2()
        {
            NewAlarm = null;
            this.DoneSuccsessfully = false;
            InitializeComponent();
        }
        public Form2(Alarm alarm) : base()
        {
            NewAlarm = alarm;
            hoursTextBox.Text = alarm.Hours.ToString();
            minutesTextBox.Text = alarm.Minutes.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(inputCheck(hoursTextBox.Text, minutesTextBox.Text))
            {
                if (NewAlarm == null)
                {
                    int h = int.Parse(hoursTextBox.Text);
                    int m = int.Parse(minutesTextBox.Text);
                    NewAlarm = new Alarm(h,m);
                }
                else
                {
                    NewAlarm.Hours= int.Parse(hoursTextBox.Text);
                    NewAlarm.Minutes = int.Parse(minutesTextBox.Text);
                }

                this.DoneSuccsessfully = true;
                Close();
            }
            else
            {
                errorLabel.Visible = true;
            }                        
        }

        private void minutesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
