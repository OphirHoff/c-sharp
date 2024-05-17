using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analog_Clock
{
    class AnalogClock
    {
        private int hours;
        private int minutes;
        private int seconds;

        public AnalogClock()
        {
        }

        public bool SetTime(int h, int m, int s)
        {
            if (m < 60 && s < 60 && h < 24)
            {
                this.hours = h;
                this.minutes = m;
                this.seconds = s;
                return true;
            }
            return false;
        }

        public void AddSecond()
        {
            if(this.seconds == 59)
            {
                this.seconds = 0;
                if (this.minutes == 59)
                {
                    this.minutes = 0;
                    if (this.hours == 23)
                    {
                        this.hours = 0;
                    }
                }
            }
            else
            {
                this.seconds++;
            }
        }

        const double Hour_Angle_Per_Min = 0.5;
        const double Minute_Angle_Per_Min = 6;
        const double Hour_Angle_Per_Hour = 30;

        public double GetClockAngle()
        {
            double hours_angle;
            double minutes_angle;

            hours_angle = (Hour_Angle_Per_Min * minutes) + (Hour_Angle_Per_Hour * (hours % 12));

            minutes_angle = Minute_Angle_Per_Min * minutes;

            if (hours_angle > minutes_angle)
            {
                return (hours_angle - minutes_angle);
            }
            return (minutes_angle - hours_angle);
        }

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}  angle:{3:0.00} ", hours, minutes, seconds, GetClockAngle());
        }

    }
}
