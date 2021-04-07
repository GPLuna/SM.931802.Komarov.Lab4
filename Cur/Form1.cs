using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Money account = new Money();
        const double k = 0.05;
        private void btStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double rate = (double)edRate.Value;
            int days = (int)edDays.Value;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, rate);

            LDollars.Text = "Доллары: " + account.Dollars;
            LRubles.Text = "Рубли: " + account.Rubles;

            for (int i = 1; i <= days; i++)
            {
                rate = rate * (1 + k * (random.NextDouble() - 0.5));
                edRate.Value = (decimal)rate;
                chart1.Series[0].Points.AddXY(i, rate);
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            double rate = (double)edRate.Value;
            double percent = (double)edPercent.Value;
            double value = (double)edValue.Value;
            account.Buy(value, rate, percent);
            LDollars.Text = "Доллары: " + account.Dollars;
            LRubles.Text = "Рубли: " + account.Rubles;
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            double rate = (double)edRate.Value;
            double percent = (double)edPercent.Value;
            double value = (double)edValue.Value;
            account.Sell(value, rate, percent);
            LDollars.Text = "Доллары: " + account.Dollars;
            LRubles.Text = "Рубли: " + account.Rubles; ;
        }

        private void SellAll_Click(object sender, EventArgs e)
        {
            double rate = (double)edRate.Value;
            double percent = (double)edPercent.Value;
            account.SellAll(rate, percent);
            LDollars.Text = "Доллары: " + account.Dollars;
            LRubles.Text = "Рубли: " + account.Rubles;
        }

        private void BuyAll_Click(object sender, EventArgs e)
        {
            double rate = (double)edRate.Value;
            double percent = (double)edPercent.Value;
            account.BuyAll(rate, percent);
            LDollars.Text = "Доллары: " + account.Dollars;
            LRubles.Text = "Рубли: " + account.Rubles;
        }
    }
    public class Money
    {
        public double Rubles = 0;
        public double Dollars = 10;
        public void Buy(double val, double rate, double per)
        {
            double cost = val * rate * (100 + per) / 100;
            if (Rubles >= cost)
            {
                Rubles -= cost;
                Dollars += val;
            }
        }
        public void Sell(double val, double rate, double per)
        {
            if (Dollars >= val)
            {
                Dollars -= val;
                Rubles += val * rate * (100 - per) / 100;
            }
        }
        public void BuyAll(double rate, double per)
        {
            double val = Rubles / rate;
            double cost = val * rate * (100 + per) / 100;
            while (cost > Rubles && val > 0)
            {
                val -= 0.01;
                cost = val * rate * (100 + per) / 100;
            }

            if (val > 0) Buy(val, rate, per);
        }
        public void SellAll(double rate, double per)
        {
            double val = Dollars;
            Sell(val, rate, per);
        }
    }
}
    