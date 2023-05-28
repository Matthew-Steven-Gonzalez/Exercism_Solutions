using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollTheDie
{
    public class RollTheDie
    {
        Random rd = new Random();
    public int RollDie()
    {
        return rd.Next(1,18);
    }

    public double GenerateSpellStrength()
    {
        return (float) rd.Next(0,100);
    }
    }
}