using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours , int minutes , int seconds)
        {
            Hours = hours ;
            Minutes = minutes ;
            Seconds = seconds ;
        }
        public Duration(int total) 
        {          
            Hours = total / 60 / 60;
            total %= 3600;
            Minutes = total / 60;
            Seconds = total % 60;

        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public static Duration operator +(Duration a, Duration b)
        {
           
            int Total = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) + (b.Hours * 3600 + b.Minutes * 60+ b.Seconds) ;
            return new Duration(Total);
        }
        public static Duration operator +(Duration a, int Total)
        {

             int newTotal = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) +Total;
            return new Duration(Total);
        }
        public static Duration operator +(int Total, Duration a)
        {
            return a + Total;
        }
        public static Duration operator ++(Duration a)
        {
            int Total = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) + 60;
            return new Duration(Total);
        }
        public static Duration operator --(Duration a)
        {
            int Total = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) - 60;
            return new Duration(Total);
        }
        public static Duration operator -(Duration a, Duration b)
        {

            int Total = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) - (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return new Duration(Total);
        }
        public static bool operator >(Duration a, Duration b)
        {

            int total1 = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int total2 = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return total1 > total2;
        }
        public static bool operator <(Duration a, Duration b)
        {
            int total1 = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int total2 = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return total1 < total2;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            int total1 = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int total2 = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return total1 <= total2;

        }
        public static bool operator >=(Duration a, Duration b)
        {

            int total1 = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int total2 = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return total1 >= total2;
        }
        public static explicit operator DateTime(Duration d)
        {

            return new DateTime( d.Hours, d.Minutes, d.Seconds);
            {
                d.Hours = 1;
                d.Minutes = 1;
                d.Seconds = 1;
            }
        }
    }
    }

