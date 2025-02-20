using System;

public class Appointment
{
    //joseph.1 //test
    private bool[,] schedule = new bool[8, 60];

    public bool isMinuteFree(int period, int minute)
    {
        return !schedule[period - 1, minute];
    }
        // Joseph.2 //test     
    public void reserveBlock(int period, int startMinute, int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            schedule[period - 1, startMinute + i] = true;
        }
    }    
        // Joseph.3
        
         public int findFreeBlock(int period, int duration)
    {
        for (int start = 0; start <= 60 - duration; start++)
        {
            bool free = true;
            for (int i = 0; i < duration; i++)
            {
                if (!isMinuteFree(period, start + i))
                {
                    free = false;
                    break;
                }
            }
            if (free) return start;
        }
        return -1;
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

        
    
// Emmanuel 
class Test {
    static void main() {
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        
    }
}
}