using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> allScores;
    public HighScores(List<int> list)
    {
        allScores = list ;
    }

    public List<int> Scores()
    {
        return allScores;
    }

    public int Latest()
    {
        return allScores.Last();
    }

    public int PersonalBest()
    {
       return allScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        var tempAllScores = new List<int>();   
        tempAllScores.AddRange(allScores); //to be able manipulate the allScores list without changing it, I have cloned allScores list 
        tempAllScores.Sort();
        tempAllScores.Reverse();
        if (tempAllScores.Count() >= 3)
        {
            var topThreeScores = new List<int> { tempAllScores[0], tempAllScores[1], tempAllScores[2] };
            return topThreeScores;
        }
        else if (tempAllScores.Count() == 2)
        {
            var topThreeScores = new List<int> { tempAllScores[0], tempAllScores[1]};
            return topThreeScores;
        }
        else
        {
            var topThreeScores = new List<int> { tempAllScores[0]};
            return topThreeScores;
        }
    }
}