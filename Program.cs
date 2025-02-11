using System;

class Appointment {
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


    public int isMinuteFree(int period, int minute) 
    {

    }
    public int reserveBlock(int period, int startMinute, int duration)
    {

    }
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

class Test {
    static void main() {
        Console.WriteLine("Hello");

        
    }
}