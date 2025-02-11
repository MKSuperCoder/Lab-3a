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
    // Joseph
    public Appointment(int startPeriod, int endPeriod) {
        this.startPeriod = startPeriod;
        this.endPeriod = endPeriod;

        // Joseph
        public bool isMinuteFree(int period, int minute) {
            return period == startPeriod && minute >= startMinute && minute < 60 
                period == endPeriod && minute >= 0 && minute < endMinute 
                period > startPeriod && period < endPeriod;
        // Joseph
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
                // Search for earliest available block of duration minutes 
                // Use findFreeBlock(int period, int duration) - returns -1 if no block is available
                for (int i = startPeriod; i <= endPeriod; i++) {
                    int block = -1;
                    block = findFreeBlock(i, duration);
                // test
                    if (block != -1) {
                        reserveBlock()
                        isBooked = true;
                    }
                }
            }

            return isBooked;
        }
    }
}

// Emmanuel 
class Test {
    static void main() {
        Console.WriteLine("Hello");

        
    }
}