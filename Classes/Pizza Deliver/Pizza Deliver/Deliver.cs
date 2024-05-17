using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Deliver
{
    class Deliver
    {
        private string name;
        enum Level { regular, senior };//0-regular, 1-senior
        private Level level;
        private int month;
        private int monthlyWorkHours;
        private int specialHours;
        private double hourlyRate;
        private int quickDeliveries;
        private double Bonus;
        const double INCOME_TAX = 0.1;
        const double HEALT_TAX = 0.08;
        const double SUPERV_RATE_FACTOR = 1.5;
        const double SPECIAL_HOUR_VALUE_FACTOR = 2;

        public Deliver(string name, int level, int month, int monthlyWorkHours,int hourlyRate, int specialHours, int quickDeliveries)
        {
            this.name = name;
            this.level = (Level)level;
            this.month = month;
            this.monthlyWorkHours = monthlyWorkHours;
            this.hourlyRate = hourlyRate;
            this.specialHours = specialHours;
            this.quickDeliveries = quickDeliveries;
        }


        public string GetName()
        {
            return this.GetName();
        }

        public int GetMonthlyWorkHours()
        {
            return this.monthlyWorkHours;
        }

        public int GetSpecialHours()
        {
            return this.specialHours;
        }

        public double GetHourlyRate()
        {
            return this.hourlyRate;
        }

        public int GetQuickDeliveries()
        {
            return this.quickDeliveries;
        }

        public double GetBonus()
        {
            return this.Bonus;
        }

        public int GetLevel()
        {
            return (int)this.level;
        }

        public void SetMonthlyWorkHours(int h)
        {
            this.monthlyWorkHours = h;
        }

        public void SetSpecialHours(int h)
        {
            this.specialHours = h;
        }

        public void SetHourlyRate(int r)
        {
            this.hourlyRate = r;
        }

        public void SetQuickDeliveries(int num)
        {
            this.quickDeliveries = num;
        }

        public void SetBonus(int b)
        {
            this.Bonus = b;
        }

        public void SetLevel(int level)
        {
            this.level = (Level)level;
        }

        // פעולה לחישוב תשלום על שעות רגילות
        public double RegularHoursPayment()
        {
            if (this.level == Level.regular)
                return monthlyWorkHours * hourlyRate;
            else
                return monthlyWorkHours * hourlyRate * SUPERV_RATE_FACTOR;
        }

        // פעולה שמחזירה תשלום על שעות מיוחדות
        public double SpecialHoursPayment()
        {
            if (this.level == Level.regular)
                return specialHours * hourlyRate;
            else
                return specialHours * hourlyRate * SUPERV_RATE_FACTOR;
        }

        // פעולה שמחזירה תשלום של בונוס
        public double BonusPayment()
        {
            if (this.level == Level.regular)
                return Bonus * quickDeliveries;
            else
                return Bonus * quickDeliveries * SUPERV_RATE_FACTOR;
        }

        // פעולה שמחזירה משכורת ברוטו
        public double BrutoSalary()
        {
            return RegularHoursPayment() + SpecialHoursPayment() + BonusPayment();
        }
        
        // פעולה שמחזירה משכורת נטו
        public double NetSalary()
        {
            return BrutoSalary() - INCOME_TAX * BrutoSalary() - HEALT_TAX * BrutoSalary();
        }

        //**equals

        public override string ToString()
        {
            string s = "";
            s += "\n*************************************************\n";
            s += string.Format("|  Bill For: {0,-8}.  Month:{1,2:0}. Year:{2,4}.    |\n", this.name, this.month, 2023);
            s += "|                                               |\n";
            s += "|                                               |\n";
            s += "|  -------------------------------------------- |\n";
            s += string.Format("|  Hourly Rate          :  {0,5:0} NIS            |\n", hourlyRate );
            s += string.Format("|  Total Regular Hours  :  {0,5:0}                |\n",RegularHoursPayment() );
            s += string.Format("|  Total Special Hours :  {0,5:0}                |\n", SpecialHoursPayment());
            s += string.Format("|  Total Bonus          :  {0,5:0} times X {1,2:0} NIS |\n", BonusPayment());
            s += "|  -------------------------------------------- |\n";
            s += string.Format("|  Bruto Salary         :  {0,5:0.00} NIS          |\n", BrutoSalary());
            s += string.Format("|  Taxes                :  {0,5:0} %              |\n", INCOME_TAX*10+HEALT_TAX*10);
            s += string.Format("|  Net Salary           :  {0,5:0.00} NIS          |\n", NetSalary());
            s += "*************************************************\n\n";

            return s;
        }
    }
}
