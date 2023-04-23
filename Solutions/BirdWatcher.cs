using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {

        int[] LastWeek = new int[]{0,2,5,3,7,8,4};
        
        return LastWeek;
        
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[6];

        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public int IncrementTodaysCount()
    {
        return birdsPerDay[6]++;

        
        throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(x => x == 0);
    
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay.Take(numberOfDays).Sum();
        
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(x => x >= 5);
            
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}