using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Q3
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Method Overriding
        public override string ToString()
        {
            if (Hours == 0) return $"Minutes: {Minutes}, Seconds: {Seconds}";
            if (Hours == 0 && Minutes == 0) return $"Seconds: {Seconds}";
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region Constructors
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
            Normalize();
        }

        public Duration(int _seconds)
        {
            Hours = _seconds / 3600;
            _seconds %= 3600;
            Minutes = _seconds / 60;
            Seconds = _seconds % 60;
        }
        #endregion

        #region Methods
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
            if (Seconds < 0)
            {
                Minutes -= 1 + (-Seconds / 60);
                Seconds = 60 - (-Seconds % 60);
            }
            if (Minutes < 0)
            {
                Hours -= 1 + (-Minutes / 60);
                Minutes = 60 - (-Minutes % 60);
            }
        }
        #endregion

        #region Operators Overloading
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration((left?.Hours ?? 0) + (right?.Hours ?? 0),
                                (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                                (left?.Seconds ?? 0) + (right?.Seconds ?? 0));
        }

        public static Duration operator +(Duration left, int right)
        {
            return new Duration(left?.Hours ?? 0,
                                left?.Minutes ?? 0,
                                (left?.Seconds ?? 0) + right);
        }

        public static Duration operator +(int left, Duration right)
        {
            return new Duration(right?.Hours ?? 0,
                                right?.Minutes ?? 0,
                                left + (right?.Seconds ?? 0));
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration?.Hours ?? 0,
                                (duration?.Minutes ?? 0) + 1,
                                duration?.Seconds ?? 0);
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration(duration?.Hours ?? 0,
                                (duration?.Minutes ?? 0) - 1,
                                duration?.Seconds ?? 0);
        }

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration((left?.Hours ?? 0) - (right?.Hours ?? 0),
                                (left?.Minutes ?? 0) - (right?.Minutes ?? 0),
                                (left?.Seconds ?? 0) - (right?.Seconds ?? 0));
        }

        public static bool operator >(Duration left, Duration right)
        {
            if ((left?.Hours ?? 0) > (right?.Hours ?? 0)) return true;
            if ((left?.Hours ?? 0) < (right?.Hours ?? 0)) return false;
            if ((left?.Minutes ?? 0) > (right?.Minutes ?? 0)) return true;
            if ((left?.Minutes ?? 0) < (right?.Minutes ?? 0)) return false;
            return (left?.Seconds ?? 0) > (right?.Seconds ?? 0);
        }

        public static bool operator <(Duration left, Duration right)
        {
            if ((left?.Hours ?? 0) < (right?.Hours ?? 0)) return true;
            if ((left?.Hours ?? 0) > (right?.Hours ?? 0)) return false;
            if ((left?.Minutes ?? 0) < (right?.Minutes ?? 0)) return true;
            if ((left?.Minutes ?? 0) > (right?.Minutes ?? 0)) return false;
            return (left?.Seconds ?? 0) < (right?.Seconds ?? 0);
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if ((left?.Hours ?? 0) > (right?.Hours ?? 0)) return true;
            if ((left?.Hours ?? 0) < (right?.Hours ?? 0)) return false;
            if ((left?.Minutes ?? 0) > (right?.Minutes ?? 0)) return true;
            if ((left?.Minutes ?? 0) < (right?.Minutes ?? 0)) return false;
            return (left?.Seconds ?? 0) >= (right?.Seconds ?? 0);
        }

        public static bool operator <=(Duration left, Duration right)
        {
            if ((left?.Hours ?? 0) < (right?.Hours ?? 0)) return true;
            if ((left?.Hours ?? 0) > (right?.Hours ?? 0)) return false;
            if ((left?.Minutes ?? 0) < (right?.Minutes ?? 0)) return true;
            if ((left?.Minutes ?? 0) > (right?.Minutes ?? 0)) return false;
            return (left?.Seconds ?? 0) <= (right?.Seconds ?? 0);
        }

        public static bool operator true(Duration duration)
        {
            return (duration?.Hours ?? 0) != 0 || (duration?.Minutes ?? 0) != 0 || (duration?.Seconds ?? 0) != 0;
        }

        public static bool operator false(Duration duration)
        {
            return (duration?.Hours ?? 0) == 0 && (duration?.Minutes ?? 0) == 0 && (duration?.Seconds ?? 0) == 0;
        }

        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(2025, 1, 9, duration?.Hours ?? 0, duration?.Minutes ?? 0, duration?.Seconds ?? 0);
        }
        #endregion
    }
}
