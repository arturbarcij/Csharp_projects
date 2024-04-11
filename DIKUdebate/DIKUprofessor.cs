using System;

public class DIKUprofessor : DIKUperson {    
    public DIKUprofessor (string Name, preparation Preparation) : base (Name, Preparation) {
        name = Name;
        preparation = Preparation;
        MaxIntellect = 10000;
        Intellect = 10000;
        StrengthOfArgument = 3;
        CounterArgument = 10;
        CriticalArgument = 10;
    }

    public override bool hasLost()
    {
        Console.WriteLine("I can not lose!");
        return false;
        // return base.hasLost();
    }

    public override bool beDrained(int amount) {
        Console.WriteLine("Professors can not take dmg.");
        return false;
    }

    public override void getExperience() {
        Console.WriteLine("I have finished my degree, I cannot be greater");
        Console.WriteLine("Professor called name: {0} increased: preparation: {1} , MaxIntellect: {2}, Intellect: {3}, StrengthOfArgument: {4}, CounterArgument: {5}, CriticalArgument: {6}", name, preparation, Semester, MaxIntellect, Intellect, StrengthOfArgument, CounterArgument,CriticalArgument);
    }
}