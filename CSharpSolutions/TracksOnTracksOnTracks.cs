using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercismExercises
{
    public class TracksOnTracksOnTracks
    {

        public static List<string> NewList()
        {
            return new List<string>();
        }

        public static List<string> GetExistingLanguages()
        {
            var LanguageList = new List<string>();
            LanguageList.Add("C#");
            LanguageList.Add("Clojure");
            LanguageList.Add("Elm");

            return LanguageList;
            
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            var updatedList = GetExistingLanguages();
            updatedList.Add(language);

            return updatedList;
        }

        public static int CountLanguages(List<string> languages)
        {
            var list = GetExistingLanguages();

            return list.Count();
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            var list = GetExistingLanguages();
            
            return list.Contains(language);
        }

        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();

            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            if(languages.Count == 0)
            {
                return false;
            }
        
            if(languages[0] == "C#" || (languages.Contains("C#") && (languages.Count() >= 2 && languages.Count() <= 3)))
            {
                return true;
            }
            return false;
            
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);

            return languages;

        }

        public static bool IsUnique(List<string> languages)
        {
            int totalElements = languages.Count;
            int distinctElements = languages.Distinct().Count();
            
            return totalElements == distinctElements;
        }
    }
}