using System;

class RemoteControlCar
{
    public int Distance = 0;

    public int BatteryLife = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        
        return string.Format("Driven {0} meters", Distance);
        
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {

        return BatteryLife > 0 ? string.Format("Battery at {0}%",BatteryLife) : "Battery empty"; 
        
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

     public void Drive()
    {
        if (BatteryLife == 0) return;
        
        BatteryLife--;
        Distance += 20;
    }
}