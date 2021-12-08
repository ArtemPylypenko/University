
namespace Timer_Alarm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlAlarm = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.AlarmflowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            this.tabControlAlarm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(146)))));
            this.button3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(117, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.hoursUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursUpDown.Location = new System.Drawing.Point(90, 49);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(43, 31);
            this.hoursUpDown.TabIndex = 4;
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.minutesUpDown.Location = new System.Drawing.Point(139, 49);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(43, 31);
            this.minutesUpDown.TabIndex = 5;
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.secondsUpDown.Location = new System.Drawing.Point(188, 49);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(43, 31);
            this.secondsUpDown.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(146)))));
            this.button2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(117, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Set timer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabControlAlarm
            // 
            this.tabControlAlarm.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabControlAlarm.Controls.Add(this.tabPage2);
            this.tabControlAlarm.Controls.Add(this.tabPage1);
            this.tabControlAlarm.Location = new System.Drawing.Point(1, 1);
            this.tabControlAlarm.Name = "tabControlAlarm";
            this.tabControlAlarm.SelectedIndex = 0;
            this.tabControlAlarm.Size = new System.Drawing.Size(324, 285);
            this.tabControlAlarm.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(195)))), ((int)(((byte)(227)))));
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.hoursUpDown);
            this.tabPage2.Controls.Add(this.secondsUpDown);
            this.tabPage2.Controls.Add(this.minutesUpDown);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.label6.Location = new System.Drawing.Point(190, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 19;
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.label5.Location = new System.Drawing.Point(139, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 18;
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.label4.Location = new System.Drawing.Point(91, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 17;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "secnd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "hours";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(195)))), ((int)(((byte)(227)))));
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.AlarmflowLayout);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 259);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alarms";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(146)))));
            this.button4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(114, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add Alarm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // AlarmflowLayout
            // 
            this.AlarmflowLayout.AutoScroll = true;
            this.AlarmflowLayout.Location = new System.Drawing.Point(7, 57);
            this.AlarmflowLayout.Name = "AlarmflowLayout";
            this.AlarmflowLayout.Size = new System.Drawing.Size(303, 190);
            this.AlarmflowLayout.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 282);
            this.Controls.Add(this.tabControlAlarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(338, 321);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            this.tabControlAlarm.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControlAlarm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel AlarmflowLayout;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

