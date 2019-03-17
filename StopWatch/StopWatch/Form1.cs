using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public bool timer_runs;
        public long ticks_start;
        public long timer_ticked;

        public Form1()
        {
            InitializeComponent();
            timer_runs = false;
            timer_ticked = 0;
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            timer_runs = !timer_runs;
            if (timer_runs)
            {
                btn_Start.Text = "Стоп";
                btn_Reset.Enabled = false;
                mytimer.Enabled = true;
                ticks_start = DateTime.Now.Ticks-timer_ticked;
            }
            else
            {
                btn_Start.Text = "Старт";
                btn_Reset.Enabled = true;
                mytimer.Enabled = false;      
            }

            

        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
            timer_ticked = (DateTime.Now.Ticks - ticks_start);
            TimeSpan ts = new TimeSpan(timer_ticked);
            tb_H.Text = ((int)ts.TotalHours).ToString();
            tb_M.Text = String.Format("{0:00}", ts.Minutes);
            tb_S.Text =  String.Format("{0:00}",ts.Seconds);
            tb_MS.Text = String.Format("{0:000}", ts.Milliseconds);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            timer_ticked = 0;
            tb_H.Text = "0";
            tb_M.Text = "00";
            tb_S.Text = "00";
            tb_MS.Text = "000";
        }
    }
}
