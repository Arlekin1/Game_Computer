using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int time = 0;
        public int day = 1;
        int pay = 0;
        public int money = 100;
        public int point = 0;
        public string status;
        public int HidenPoint =10;
        public int pc = 1;
        public int softlvl = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 6, 1);
            TimeSpan timeSpan = DateTime.Now - startDate;
            time = (int)timeSpan.TotalMinutes;
            day = timeSpan.Days + 1;

            time++;
            DateTime currentTime = startDate.AddMinutes(time % 1440);
            lbltime.Text = currentTime.ToString("HH:mm", CultureInfo.CurrentCulture);
            label2.Text = startDate.ToString("dd.MM.yyyy", CultureInfo.CurrentCulture);
            lblPoint.Text = point.ToString();

            if (point == 10 && point <= 20)
            {
                lblStatus.Text = "Нищий";
                status = "Нищий";
            }

            else if (point >= 21 && point <= 30)
            {
                lblStatus.Text = "Чел из норбита";
            }
            else if (point >= 31 && point <= 39)
            {
                lblStatus.Text = "Google";
                status = "Google";
            }
            else if (point >= 40 && point <= 31000)
            {
                lblStatus.Text = "Apple";
                status = "Apple";
            }
            while (time == 23)
            {
                time = 0;
                day++;
                money += pay;
                lblMoney.Text = money.ToString();
                lblPoint.Text = point.ToString();

                if (day == 10)
                {
                    money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Путину нужны деньги, плати налоги 100$", "налог");
                }
                else if (day == 20)
                {
                    money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Путину нужны деньги, плати налоги 100$", "налог");
                }
                else if (day == 30)
                {

                    money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Путину нужны деньги, плати налоги 100$", "налог");
                }
                else if (day == 40)
                {
                    money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Путину нужны деньги, плати налоги 100$", "налог");
                }
                else if (day == 45)
                {
                    money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Путину нужны деньги, плати налоги 100$", "налог");
                }

                вирус vs = new вирус(this);
                if (day == 7)
                {
                    vs.Show();
                }
                else if (day == 8)
                {
                    vs.Show();
                }
                else if (day == 10)
                {
                    vs.Show();
                }
                else if (day == 15)
                {
                    vs.Show();
                }
                else if (day == 16)
                {
                    vs.Show();
                }
                else if (day == 20)
                {
                    vs.Show();
                }
                else if (day == 25)
                {
                    vs.Show();
                }
                else if (day == 27)
                {
                    vs.Show();
                }
                else if (day == 30)
                {
                    vs.Show();
                }
                else if (day == 31)
                {
                    vs.Show();
                }
                else if (day == 35)
                {
                    vs.Show();
                }
                HidenPoint--;
                if (HidenPoint == 0)
                {
                    MessageBox.Show("Ты в лучшем месте(Попробуй заново", "Проигрыш");
                    Application.Exit();
                }
                if (HidenPoint <= 5)
                {
                    lblNastr.Text = "ты в тильте";

                }

            }
            if (HidenPoint >= 10)
            {
                lblNastr.Text = "Норм";

            }
            if (HidenPoint >= 15)
            {
                lblNastr.Text = "Норм +";
            }
            if (HidenPoint >= 20)
            {
                lblNastr.Text = "Норм ++";

            }
            if (lblJob.Text == "Дворник /10$ день")
            {
                pay = 10;


            }
            if (lblJob.Text == "Строитель/30$ день")
            {
                pay = 30;
            }
            if (lblJob.Text == "Фриланс/50$ день")
            {
                pay = 50;
            }
            if (lblJob.Text == "Программист/100$ день")
            {
                pay = 100;
            }
        }
            

         public void ChangeLabelText(string text)
        {  lblJob.Text = text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMoney.Text = money.ToString();
            lblPoint.Text = point.ToString();
            timer1.Start();

        }
        private void button4_Click(object sender, EventArgs e)
        {
      работа job = new работа(this);
           job.Show();
           
        }
    public void ChangeLabel(string text)
        {
         lblJob.Text = text;
        }

    private void button1_Click(object sender, EventArgs e)
        {
         Улучшение up = new Улучшение(this);
         up.Show();
        }

        private void lblLvl_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Развлечения vp = new Развлечения(this);
            vp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
     {
            софт sf = new софт(this);
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            хакер hc = new хакер(this);
            hc.Show();
        }

   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
