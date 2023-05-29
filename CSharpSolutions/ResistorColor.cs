using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercismExercises
{
    public class ResistorColor
    {
        public static int ColorCode(string color)
    {
        int colorNum = 0;
        
        switch(color){
            case "black":
                colorNum = 0;
                break;
            case "brown":
                colorNum = 1;
                break;
            case "red":
                colorNum = 2;
                break;
            case "orange":
                colorNum = 3;
                break;
            case "yellow":
                colorNum = 4;
                break;
            case "green":
                colorNum = 5;
                break;
            case "blue":
                colorNum = 6;
                break;
            case "violet":
                colorNum = 7;
                break;
            case "grey":
                colorNum = 8;
                break;
            case "white":
                colorNum = 9;
                break;
        }
    return colorNum;
    }

    public static string[] Colors()
    {
        string[] colorList= new string[10]; 
        colorList[0] = "black";
        colorList[1] = "brown";
        colorList[2] = "red";
        colorList[3] = "orange";
        colorList[4] = "yellow";
        colorList[5] = "green";
        colorList[6] = "blue";
        colorList[7] = "violet";
        colorList[8] = "grey";
        colorList[9] = "white";

        return colorList;
    }
    }
}