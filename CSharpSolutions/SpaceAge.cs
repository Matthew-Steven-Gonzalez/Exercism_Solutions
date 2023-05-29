using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercismExercises
{
    public class SpaceAge
    {
        private double seconds;

    private int earthYear = 31557600;
    
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return this.seconds / earthYear;
    }

    public double OnMercury()
    {
        return this.seconds / (0.2408467 * earthYear);
    }

    public double OnVenus()
    {
                return this.seconds / (0.61519726 * earthYear);
    }

    public double OnMars()
    {
                return this.seconds / (1.8808158 * earthYear);
    }

    public double OnJupiter()
    {
                return this.seconds / (11.862615 * earthYear);
    }

    public double OnSaturn()
    {
                return this.seconds / (29.447498 * earthYear);
    }

    public double OnUranus()
    {
                return this.seconds / (84.016846  * earthYear);
    }

    public double OnNeptune()
    {
                return this.seconds / (164.79132  * earthYear);
    }
    }
}