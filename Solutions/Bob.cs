using System;

public static class Bob
{
        private static bool IsEmpty(string statement) => string.IsNullOrWhiteSpace(statement);

        private static bool IsQuestion(string statement) => statement.TrimEnd().EndsWith("?");

        private static bool IsYelling(string statement) => statement.ToUpper() == statement && statement.ToLower() !=statement;

    
    public static string Response(string statement)
    {

        if(IsEmpty(statement))
            return "Fine. Be that way!";
        else if(IsQuestion(statement) && IsYelling(statement))
            return "Calm down, I know what I'm doing!";
        else if(IsYelling(statement))
            return "Whoa, chill out!";
        else if(IsQuestion(statement))
            return "Sure.";
        else
            return "Whatever.";

       
        throw new NotImplementedException("You need to implement this function.");
    }
}