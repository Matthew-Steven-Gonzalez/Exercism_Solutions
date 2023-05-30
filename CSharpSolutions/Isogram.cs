using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercismExercises
{
    public class Isogram
    {

        public static bool IsIsogram(string word)
        {
            HashSet<char> characters = new HashSet<char>();

            word.Replace(" ","");
            
            foreach (char c in word)
            {
                if (char.IsWhiteSpace(c) || c.Equals('-')){
                    continue;
                }
                    
                char lowercaseChar = char.ToLower(c);
        
                if (characters.Contains(lowercaseChar))
                {
                    return false;
                }
        
                characters.Add(lowercaseChar);
            }
        
            return true;
        }
    }
    
}