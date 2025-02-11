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
        //Marcus
        public bool makeAppointment(int startPeriod, int endPeriod, int duration) 
        {
            for (int i = startPeriod; i < endPeriod; i++) 
            {
                for (int minute = 0; i < duration; minute++) {
                    if (isMinuteFree(i, duration)) 
                    {
                        reserveBlock(i, minute, duration);
                        return true;
                    }
                    else 
                    {
                        return false;
                    }   
                }
           
            }
        }
    }
}

// Emmunuel 
class Test {
    static void main() {
        Console.WriteLine("Hello");

        
    }
}