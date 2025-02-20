using System;

public class Appointment
{
    //Marcus
    public bool[,] schedule;
    
    public Appointment() 
    {
        schedule = new bool[8, 60];
    }
    
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

// Emmanuel
class Program
{
    static void Main()
    {
        Appointment appointment1 = new Appointment();

        bool appointmentMade = false;
        appointmentMade = appointment1.MakeAppointment(1, 4, 20);

        if (appointmentMade == true)
        {
            Console.WriteLine("Appointment #1 has been successfully booked.");
        }
        else
        {
            Console.WriteLine("Appointment #1 not booked.");
        }
    }
}
