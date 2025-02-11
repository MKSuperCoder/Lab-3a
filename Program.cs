using System;

class Appointment 
{
    List<string> periods = new List<string>();

    Appointment() {}

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
    public Appointment(int startPeriod, int endPeriod) {
        this.startPeriod = startPeriod;
        this.endPeriod = endPeriod;

        public bool isMinuteFree(int period, int minute) {
            return period == startPeriod && minute >= startMinute && minute < 60 
                period == endPeriod && minute >= 0 && minute < endMinute 
                period > startPeriod && period < endPeriod;

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
    public bool makeAppointment(int startPeriod, int endPeriod, int duration) {
        for (int i = startPeriod; i < endPeriod; i++) 
        {

        }
    }
}

class Test {
    static void main() {
        Console.WriteLine("Hello");

        
    }
}