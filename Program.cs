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

         public bool makeAppointment(int startPeriod, int endPeriod, int duration)
    {
        for (int period = startPeriod; period <= endPeriod; period++)
        {
            int startMinute = findFreeBlock(period, duration);
            if (startMinute != -1)
            {
                reserveBlock(period, startMinute, duration);
                return true;
            }
        }
        return false;
    }
}

        
    
// Emmanuel 
class Test {
    static void main() {
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        
    }
}
}