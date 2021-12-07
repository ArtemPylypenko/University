using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Alarm
{
    public class AlarmPanel:Panel
    {
        private System.Windows.Forms.PictureBox deleteButton;
        private System.Windows.Forms.PictureBox editButton;
        private System.Windows.Forms.Label timeLabel;
        public Action<Alarm> OnDelete;
        public Action<Alarm> OnEdit;
        public Alarm alarm;


        public AlarmPanel(Alarm alarm)
        {
            this.alarm = alarm;
            this.deleteButton = new PictureBox();
            this.editButton = new PictureBox();
            this.timeLabel = new Label();

            CreateElements();

            this.Controls.Add(deleteButton);
            this.Controls.Add(editButton);
            this.Controls.Add(timeLabel);

            deleteButton.Click += OnDeleteButtonClicked;
            editButton.Click += OnEditButtonClicked;

        }


        private void CreateElements()
        {
            // panel
            //
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(245)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.timeLabel);
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "panel"+alarm.Id;
            this.Size = new System.Drawing.Size(280, 61);
            this.TabIndex = 0;
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(13, 11);
            this.timeLabel.Name = "timeLabel"+alarm.Id;
            this.timeLabel.Size = new System.Drawing.Size(127, 36);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = $"{alarm.Hours.ToString().PadLeft(2)}:{alarm.Minutes.ToString().PadLeft(2, '0')}";
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Image = Properties.Resources.editIcon;
            this.editButton.Location = new System.Drawing.Point(165, 11);
            this.editButton.Name = "editButton" + alarm.Id;
            this.editButton.Size = new System.Drawing.Size(37, 36);
            this.editButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButton.TabIndex = 1;
            this.editButton.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = Properties.Resources.deleteIcon;
            this.deleteButton.Location = new System.Drawing.Point(224, 11);
            this.deleteButton.Name = "deleteButton" + alarm.Id;
            this.deleteButton.Size = new System.Drawing.Size(37, 36);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 2;
            this.deleteButton.TabStop = false;


        }
        private void OnDeleteButtonClicked(Object sender,EventArgs args)
        {
            OnDelete(alarm);
        }
        private void OnEditButtonClicked(Object sender, EventArgs args)
        {
            OnEdit(alarm);
        }

    }

}
