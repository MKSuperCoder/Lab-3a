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
    
    //Marcus
    public int findFreeBlock(int period, int duration)
    {
        int count = 0;
        for (int minute = 0; minute < 60; minute++)
        {
            if (IsMinuteFree(period, minute))
            {
                count++;
                if (count == duration)
                {
                    return minute - duration + 1;
                }
            }
            else
            {
                count = 0;
            }
        }
        return -1; 
    }

    
}
class Test {
    static void Main()
    {
        
        
    }
}