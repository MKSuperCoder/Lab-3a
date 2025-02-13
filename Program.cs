using System;

class Appointment 
{
    //Marcus
    public bool[,] schedule;

    public Appointment() 
    {
        schedule = new bool[8, 60];
    }

    //Marcus
    private bool isMinuteFree(int period, int minute)
    {
        if (schedule[period - 1, minute] == false) 
            return true;
        else
            return false;
    }
    private void reserveBlock(int period, int startMinute, int duration) {
        for (int i = 0; i < duration; i++) {
            schedule[period - 1, startMinute + i] = true;
        }
    }
    //Marcus
    public int findFreeBlock(int period, int duration)
    {
        int minuteCount = 0;
        int startingMinuteFree = 0;
        for (int minute = 0; minute < 60; minute++)
        {
            if (isMinuteFree(period, minute))
            {
                startingMinuteFree = minute;
                minuteCount++;
                if (minuteCount == duration)
                {
                    return startingMinuteFree;
                }
                
            }
            else
            {
                Console.WriteLine("There is no available block in the specified period.");
            }
        }
        return -1; 
    }

    
}
//Emmanuel
class Test {
    static void Main(string[] args)
    {
        
        
    }
}