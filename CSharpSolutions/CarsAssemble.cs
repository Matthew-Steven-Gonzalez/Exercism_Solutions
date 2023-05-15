using System;

static class AssemblyLine
{
      const double baseCarRate = 221.0;
    
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
        {
            return 0.00;
        }
        else if(speed >= 1 && speed <= 4)
        {
            return 1.00;
        }
        else if(speed >= 5 && speed <= 8)
        {
            return 0.90;
        }
        else if(speed == 9)
        {
            return 0.80;
        }
        else if(speed == 10)
        {
            return 0.77;
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {

        return SuccessRate( speed) * baseCarRate * speed;
            
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed) / 60;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
