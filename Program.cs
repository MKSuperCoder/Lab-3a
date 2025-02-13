using System;

class Appointment 
{
    // Emmanuel
    public bool makeAppointment(int startPeriod, int endPeriod, int duration)
    {
        bool isBooked = false;

        if (((startPeriod >= 1) && (startPeriod <= 8)) && ((endPeriod >= 1) && (endPeriod <= 8)) && ((duration >= 0) && (duration <= 59)))
        {
            int startMinute = -1;

            for (int period = startPeriod; i <= endPeriod; i++)
            {
                startMinute = findFreeBlock(period, duration);

                if ((startMinute >= 0) && (startMinute <= 59))
                {
                    reserveBlock(period, startMinute, duration);
                    isBooked = true;
                    break;
                }
            }

            if (startMinute == -1)
            {
                Console.WriteLine("Sorry! Unable to book appointment.")
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
class Test {
    static void main() {
        
        
    }
}