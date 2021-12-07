using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace Timer_Alarm
{
    
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;

        SoundPlayer sound = new SoundPlayer(Properties.Resources.timeUpRing);
        List<Alarm> alarmList;
        List<AlarmPanel> panelsList;
        public Form1()
        {
            InitializeComponent();
            alarmList = new List<Alarm>();
            panelsList = new List<AlarmPanel>();
            timer1.Interval = 1000;//ms
            timer2.Interval = 1000;//ms
            timer2.Enabled = true;
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(h==0 && m == 0 && s == 0)
            {
                sound.Play();
                timer1.Enabled = false;
            }
            if (s != 0 && s!= -1)
            {
                s--;
                label6.Text = s.ToString();
                if (s == 0)
                {
                    if (m != 0)
                    {
                        m--;
                        s = 59;
                        label6.Text = s.ToString();
                        label5.Text = m.ToString();
                        if (m == 0)
                        {
                            if (h != 0)
                            {
                                h--;
                                m = 59;
                                label5.Text = m.ToString();
                                s = 59;
                                label6.Text = s.ToString();
                                label4.Text = h.ToString();
                            }
                        }
                    }
                }
            }
            else if(m!=0 && m!= -1)
            {
                m--;
                s = 59;
                label6.Text = s.ToString();
                label5.Text = m.ToString();
                if (m == 0)
                {
                    if (h != 0)
                    {
                        h--;
                        m = 59;
                        label5.Text = m.ToString();
                        label4.Text = h.ToString();
                    }
                }
            }else if (h != 0 && h != -1)
            {
                h--;
                m = 59;
                label5.Text = m.ToString();
                s = 59;
                label6.Text = s.ToString();
                label4.Text = h.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            h = ((int)hoursUpDown.Value);
            label4.Text = h.ToString();
            label4.Visible = true;
            m = ((int)minutesUpDown.Value);
            label5.Text = m.ToString();
            label5.Visible = true;
            s = ((int)secondsUpDown.Value);
            label6.Text = s.ToString();
            label6.Visible = true;
            hoursUpDown.Visible = !hoursUpDown.Visible;
            minutesUpDown.Visible = !minutesUpDown.Visible;
            secondsUpDown.Visible = !secondsUpDown.Visible;
            timer1.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                
                timer1.Enabled = false;
                button3.Text = "Start";
                sound.Stop();
            }
            else
            {
                if(h == 0 && m == 0 && s == 0)
                {
                    sound.Stop();
                    h = -1;
                    m = -1;
                    s = -1;
                    button3.Text = "Start";
                    timer1.Enabled = true;
                    hoursUpDown.Visible = true;
                    minutesUpDown.Visible = true;
                    secondsUpDown.Visible = true;
                }
                else
                {
                    timer1.Enabled = true;
                    button3.Text = "Stop";
                }
                
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            if (addForm.DoneSuccsessfully)
            {
                AlarmPanel panel = new AlarmPanel(addForm.NewAlarm);
                panel.OnDelete = OnAlarmDelete;
                panel.OnEdit = OnAlarmEdit;
                AlarmflowLayout.Controls.Add(panel);
                alarmList.Add(panel.alarm);
                panelsList.Add(panel);
            }
            else
            {
                
            }
            addForm.Dispose();
            
        }
        void OnAlarmDelete(Alarm alarm)
        {
            foreach(Control panelControl in AlarmflowLayout.Controls)
            {
                AlarmPanel panel = panelControl as AlarmPanel;
                if (panel.alarm.Id == alarm.Id)
                {
                    AlarmflowLayout.Controls.Remove(panel);
                    break;
                }
            }
            alarmList.Remove(alarm);
        }
        void OnAlarmEdit(Alarm alarm)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            if (addForm.DoneSuccsessfully)
            {
                OnAlarmDelete(alarm);
                AlarmPanel panel = new AlarmPanel(addForm.NewAlarm);
                panel.OnDelete = OnAlarmDelete;
                panel.OnEdit = OnAlarmEdit;
                AlarmflowLayout.Controls.Add(panel);
                alarmList.Add(panel.alarm);
            }
            addForm.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            if (alarmList.Count!=0)
            {
                foreach(AlarmPanel panel in panelsList)
                {
                    if(panel.alarm.Hours==currentTime.Hour && panel.alarm.Minutes == currentTime.Minute)
                    {
                        if(!panel.alarm.isActive)
                        {
                            sound.Play();
                            panel.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
                        }
                            
                        panel.alarm.isActive = true;
                    }
                }
            }
            
            
        }
    }
}
