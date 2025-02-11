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


    public bool isMinuteFree(int period, int minute) 
    {

    }
    public bool reserveBlock(int period, int startMinute, int duration)
    {

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
}

class Test {
    static void main() {
        Console.WriteLine("Hello");

        
    }
}