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
    private bool IsMinuteFree(int period, int minute)
    {
        if (schedule[period - 1, minute] == false) 
            return true;
        else
            return false;
    }
    
    private void ReserveBlock(int period, int startMinute, int duration) 
    {
        for (int i = 0; i < duration; i++) 
        {
            schedule[period - 1, startMinute + i] = true;
        }
    }
    
    //Marcus
    public int FindFreeBlock(int period, int duration)
    {
        int freeMinuteCount = 0;
        int startingMinuteFree = 0;
        for (int minute = 0; minute < 60; minute++)
        {
            if (IsMinuteFree(period, minute) && freeMinuteCount == 0)
            {
                startingMinuteFree = minute;
                freeMinuteCount++;
            }
            else if (IsMinuteFree(period, minute) && freeMinuteCount > 0)
            {
                freeMinuteCount++;
            }
            if (freeMinuteCount == duration)
            {
                break;
            }
        }
        if (startingMinuteFree == -1) 
        {
            Console.WriteLine("No free block found.");
        }
        return startingMinuteFree;
    }
    
    // Emmanuel
    public bool MakeAppointment(int startPeriod, int endPeriod, int duration)
    {
        bool isBooked = false;
        
        if (((startPeriod >= 1) && (startPeriod <= 8)) && ((endPeriod >= 1) && (endPeriod <= 8)) && ((duration >= 0) && (duration <= 59)))
        {
            int startMinute = -1;
            
            for (int period = startPeriod; period <= endPeriod; period++)
            {
                startMinute = FindFreeBlock(period, duration);
                
                if ((startMinute >= 0) && (startMinute <= 59))
                {
                    ReserveBlock(period, startMinute, duration);
                    isBooked = true;
                    break;
                }
            }
        
            if (startMinute == -1)
            {
                Console.WriteLine("Sorry! Unable to book appointment.");
            }
        }
        else
        {
            Console.WriteLine("Error! Please make sure the periods are between 1-8, and the duration is between 0-59.");
        }
        
        return isBooked;
    }
}
