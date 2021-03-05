using System;
using System.Windows.Forms;

namespace Акции
{
    public partial class Shares_gameForm : Form
    {
        public Shares_gameForm()
        {
            InitializeComponent();
        }
        //кол-во денег
        int money = 1000;


        //стоимости
        int cost_chalk = 80;//первичная стоимость мела
        int cost_gold = 4000;//первичная стоимость золота

        int first_cost_chalk = 80,//зафиксированная стоимость мела
            first_cost_gold = 4000;//зафиксированная стоимость золота

        //количества
        int count_chalk = 0;//кол-во мела
        int count_gold = 0;//кол-во золота




        //Дни
        int days = 0;
        int time_of_year = 1;






        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb_buy_chalk.Text = Int32.Parse(tb_buy_chalk.Text).ToString();
                int primer = Int32.Parse(tb_buy_chalk.Text) * Int32.Parse(tb_cost_chalk.Text);
                if (money >= primer)
                {
                    money -= primer;
                    count_chalk += Int32.Parse(tb_buy_chalk.Text);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tb_sale_chalk.Text = Int32.Parse(tb_sale_chalk.Text).ToString();
                if (count_chalk >= Int32.Parse(tb_sale_chalk.Text))
                {
                    count_chalk -= Int32.Parse(tb_sale_chalk.Text);
                    money += Int32.Parse(tb_sale_chalk.Text) * Int32.Parse(tb_cost_chalk.Text);
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int can_buy = money / Int32.Parse(tb_cost_chalk.Text);
                int cost_can_buy = can_buy * Int32.Parse(tb_cost_chalk.Text);
                money -= cost_can_buy;
                count_chalk += can_buy;
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int can_sale = Int32.Parse(tb_have_chalk.Text);
                int cost_can_sale = can_sale * Int32.Parse(tb_cost_chalk.Text);
                money += cost_can_sale;
                count_chalk -= can_sale;
            }
            catch { }
        }



        //Таймеры
        private void timer_reload_tick(object sender, EventArgs e)
        {
            try
            {
                tb_cost_chalk.Text = cost_chalk.ToString();
                tb_cost_gold.Text = cost_gold.ToString();



                tb_have_chalk.Text = count_chalk.ToString();
                tb_have_gold.Text = count_gold.ToString();



                tb_almoney_chalk.Text = (cost_chalk * count_chalk).ToString();
                tb_almoney_gold.Text = (cost_gold * count_gold).ToString();



                tb_money.Text = money.ToString();
            }
            catch { }
        }

        int Event;
        private void events_Tick(object sender, EventArgs e)
        {
            label6.Text = "";
            label6.Visible = false;

            var rand = new Random();
            events.Interval = rand.Next(8000) + 4000;


            //Бум на рынке
            {
                //шанс 5,8%
                //внезапный бум на рынке
                Event = rand.Next(1000) + 1;//макс шанс 1000 (= 100 %), т. е. 1=0,1 %

                if (Event < 58)
                {
                    label6.Visible = true;
                    cost_chalk += 8;
                    cost_gold += 120;
                    label6.Text += $"Внезапный бум на рынке\n\n";
                    //стоимость всего взлетела
                }
            }

            //Подарок от друга
            {
                //шанс 8,0%
                //друг вам подарил подарок
                Event = rand.Next(1000) + 1;//макс шанс 1000 (= 100 %), т. е. 1=0,1 %

                if (Event < 80)
                {
                    label6.Visible = true;
                    int present = rand.Next(200);
                    cost_chalk += 8;
                    label6.Text += $"Друг подарил вам подарок - {present}$\n\n";
                    //стоимость всего взлетела
                }
            }

            //Уменьшение цены акций мела
            {
                //шанс 8,0%
                //одна из компаний по производству мела неудачно продала болльшую партию товара
                Event = rand.Next(1000) + 1;//макс шанс 1000 (= 100 %), т. е. 1=0,1 %


                if (Event < 80)
                {
                    label6.Visible = true;
                    cost_chalk -= 12;
                    if (cost_chalk <= 0)
                    {
                        cost_chalk += rand.Next(10) + 1;
                    }

                    label6.Text += $"Одна из компаний по производству мела неудачно продала болльшую партию товара\n\n";
                    //стоимость мела упала
                }
            }

        }

        private void btn_buy_gold_Click(object sender, EventArgs e)
        {
            try
            {
                int primer = Int32.Parse(tb_buy_gold.Text) * Int32.Parse(tb_cost_gold.Text);
                if (money >= primer)
                {
                    money -= primer;
                    count_gold += Int32.Parse(tb_buy_gold.Text);
                }
            }
            catch { }
        }

        private void btn_sale_gold_Click(object sender, EventArgs e)
        {
            try
            {
                if (count_gold >= Int32.Parse(tb_sale_gold.Text))
                {
                    count_gold -= Int32.Parse(tb_sale_gold.Text);
                    money += Int32.Parse(tb_sale_gold.Text) * Int32.Parse(tb_cost_gold.Text);
                }
            }
            catch { }
        }

        private void btn_buyAll_gold_Click(object sender, EventArgs e)
        {
            try
            {
                int can_buy = money / Int32.Parse(tb_cost_gold.Text);
                int cost_can_buy = can_buy * Int32.Parse(tb_cost_gold.Text);
                money -= cost_can_buy;
                count_gold += can_buy;
            }
            catch { }
        }

        private void btn_saleAll_gold_Click(object sender, EventArgs e)
        {
            try
            {
                int can_sale = Int32.Parse(tb_have_gold.Text);
                int cost_can_sale = can_sale * Int32.Parse(tb_cost_gold.Text);
                money += cost_can_sale;
                count_gold -= can_sale;
            }
            catch { }
        }

       

        private void next_day_Tick(object sender, EventArgs e)
        {
            //interval=4000
            int r1,
                r2;

            int interval_chalk = 2,
                interval_gold = 50;

            var rand = new Random();

            //Лето
            if (time_of_year == 1)
            {
                {//Мел
                    r1 = rand.Next(100) + 1;
                    if (r1 < 20)
                        cost_chalk -= rand.Next(interval_chalk * 3) + 1;

                    else if (r1 < 40)
                        cost_chalk -= rand.Next(interval_chalk * 2) + 1;

                    else if (r1 < 50)
                        cost_chalk -= rand.Next(interval_chalk) + 1;

                    else if (r1 < 80)
                        cost_chalk += rand.Next(interval_chalk + 1) + 1;

                    else if (r1 < 90)
                        cost_chalk += rand.Next(interval_chalk * 2 + 2) + 1;

                    else
                        cost_chalk += rand.Next(interval_chalk * 3 + 2) + 1;
                }//Мел


                {//Золото
                    r2 = rand.Next(100) + 1;
                    if (r2 < 20)
                        cost_gold -= rand.Next(interval_gold * 3) + 1;
                    else if (r2 < 40)
                        cost_gold -= rand.Next(interval_gold * 2) + 1;

                    else if (r2 < 50)
                        cost_gold -= rand.Next(interval_gold) + 1;

                    else if (r2 < 80)
                        cost_gold += rand.Next(interval_gold + 1) + 1;

                    else if (r2 < 90)
                        cost_gold += rand.Next(interval_gold * 2 + 2) + 1;

                    else
                        cost_gold += rand.Next(interval_gold * 3 + 2) + 1;
                }//Золото
            }
            //Лето

            //Осень
            else if (time_of_year == 2)
            {
                {
                    r1 = rand.Next(100) + 1;
                    if (r1 < 20)
                        cost_chalk -= rand.Next(interval_chalk * 3) + 1;

                    else if (r1 < 40)
                        cost_chalk -= rand.Next(interval_chalk * 2) + 1;

                    else if (r1 < 50)
                        cost_chalk -= rand.Next(interval_chalk) + 1;

                    else if (r1 < 80)
                        cost_chalk += rand.Next(interval_chalk + 1) + 1;

                    else if (r1 < 90)
                        cost_chalk += rand.Next(interval_chalk * 2 + 2) + 1;

                    else
                        cost_chalk += rand.Next(interval_chalk * 3 + 2) + 1;
                }//Мел

                {//Золото
                    r2 = rand.Next(100) + 1;
                    if (r2 < 20)
                        cost_gold -= rand.Next(interval_gold * 3) + 1;

                    else if (r2 < 40)
                        cost_gold -= rand.Next(interval_gold * 2) + 1;

                    else if (r2 < 50)
                        cost_gold -= rand.Next(interval_gold) + 1;

                    else if (r2 < 80)
                        cost_gold += rand.Next(interval_gold + 1) + 1;

                    else if (r2 < 90)
                        cost_gold += rand.Next(interval_gold * 2 + 2) + 1;

                    else
                        cost_gold += rand.Next(interval_gold * 3 + 2) + 1;
                }//Золото
            }
            //Осень

            //Зима
            else if (time_of_year == 3)
            {
                {
                    r1 = rand.Next(100) + 1;
                    if (r1 < 20)
                        cost_chalk -= rand.Next(interval_chalk * 3) + 1;

                    else if (r1 < 40)
                        cost_chalk -= rand.Next(interval_chalk * 2) + 1;

                    else if (r1 < 50)
                        cost_chalk -= rand.Next(interval_chalk) + 1;

                    else if (r1 < 80)
                        cost_chalk += rand.Next(interval_chalk + 1) + 1;

                    else if (r1 < 90)
                        cost_chalk += rand.Next(interval_chalk * 2 + 2) + 1;

                    else
                        cost_chalk += rand.Next(interval_chalk * 3 + 2) + 1;
                }//Мел

                {//Золото
                    r2 = rand.Next(100) + 1;
                    if (r2 < 20)
                        cost_gold -= rand.Next(interval_gold * 3) + 1;

                    else if (r2 < 40)
                        cost_gold -= rand.Next(interval_gold * 2) + 1;

                    else if (r2 < 50)
                        cost_gold -= rand.Next(interval_gold) + 1;

                    else if (r2 < 80)
                        cost_gold += rand.Next(interval_gold + 1) + 1;

                    else if (r2 < 90)
                        cost_gold += rand.Next(interval_gold * 2 + 2) + 1;

                    else
                        cost_gold += rand.Next(interval_gold * 3 + 2) + 1;
                }//Золото
            }
            //Зима

            //Весна
            else if (time_of_year == 4)
            {
                {//Мел
                    r1 = rand.Next(100) + 1;
                    if (r1 < 20)
                        cost_chalk -= rand.Next(interval_chalk * 3) + 1;

                    else if (r1 < 40)
                        cost_chalk -= rand.Next(interval_chalk * 2) + 1;

                    else if (r1 < 50)
                        cost_chalk -= rand.Next(interval_chalk) + 1;

                    else if (r1 < 80)
                        cost_chalk += rand.Next(interval_chalk + 1) + 1;

                    else if (r1 < 90)
                        cost_chalk += rand.Next(interval_chalk * 2 + 2) + 1;

                    else
                        cost_chalk += rand.Next(interval_chalk * 3 + 2) + 1;
                }//Мел

                {//Золото
                    r2 = rand.Next(100) + 1;
                    if (r2 < 20)
                        cost_gold -= rand.Next(interval_gold * 3) + 1;

                    else if (r2 < 40)
                        cost_gold -= rand.Next(interval_gold * 2) + 1;

                    else if (r2 < 50)
                        cost_gold -= rand.Next(interval_gold) + 1;

                    else if (r2 < 80)
                        cost_gold += rand.Next(interval_gold + 1) + 1;

                    else if (r2 < 90)
                        cost_gold += rand.Next(interval_gold * 2 + 2) + 1;

                    else
                        cost_gold += rand.Next(interval_gold * 3 + 2) + 1;
                }//Золото
            }
            //Весна







            //Контроль
            {
                //Мел
                if (cost_chalk < first_cost_chalk / 10)
                    cost_chalk += rand.Next(5);

                //Золото
                if (cost_gold < first_cost_gold / 12)
                    cost_gold += rand.Next(150);
            }
            //Контроль






            //Дни
            days++;
            if (days >= 30)
            {
                days -= 30;
                time_of_year++;
                if (time_of_year >= 4)
                {
                    time_of_year = 1;
                }
            }



            //Банкротство компаний
            if (cost_chalk <= 0)
            {
                count_chalk = 0;
            }
            if (cost_gold <= 0)
            {
                count_gold = 0;
            }
        }
    }
}