using System;

class Appointment 
{
    //Marcus
    List<string> periods = new List<string>();

    Appointment() {}

    //Marcus
    public List<String> periods
    {
        get
        {
            return this.periods;
        }
        set
        {
            periods = value;
        }
    }
            // Joseph1
    public Appointment(int startPeriod, int endPeriod) {
        this.startPeriod = startPeriod;
        this.endPeriod = endPeriod;

        // Joseph2
        public bool isMinuteFree(int period, int minute) {
            return period == startPeriod && minute >= startMinute && minute < 60 
                period == endPeriod && minute >= 0 && minute < endMinute 
                period > startPeriod && period < endPeriod;
        // Joseph3
        public bool reserveBlock(int period, int startMinute, int duration)
        {
            if (isMinuteFree(period, startMinute) && isMinuteFree(period, startMinute + duration))
            {
            return true;
            }
            else
            {
            return false;
            }
        }

        }
        //Marcus
        public int findFreeBlock(int period, int duration) 
        {
            for (int i = 0; i < duration; i++) 
            {
                if (isMinuteFree(period, i))
                {
                    return i;
                }
                else 
                {
                    return -1;
                }
            }
        }

        // Emmanuel
        public bool makeAppointment(int startPeriod, int endPeriod, int duration) {
            bool isBooked = false;

            if (((startPeriod >= 1) && (startPeriod <= 8)) && ((endPeriod >= 1) && (endPeriod <= 8)) && ((duration >= 0) && (duration <= 59))) {
                for (int period = startPeriod; i <= endPeriod; i++) {
                    int startMinute = -1;
                    startMinute = findFreeBlock(period, duration);

                    if (startMinute != -1) {
                        reserveBlock(period, startMinute, duration);
                        isBooked = true;
                        break;
                    }
                }
            }

            return isBooked;
        }

        
    }
}

// Marcus
class Test {
    static void main() {
        Appointment appointment1 = new Appointment(1, 2);
        Console.WriteLine(appointment1.findFreeBlock(2, 20));
        Console.WriteLine(appointment1.makeAppointment(1, 8, 15));
        
    }
}