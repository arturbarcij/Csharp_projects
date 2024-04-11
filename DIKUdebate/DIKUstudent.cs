using System;

public class DIKUstudent : DIKUperson {
    public DIKUstudent (string Name, preparation Preparation) : base (Name, Preparation) {
        name = Name;
        preparation = Preparation;
        Semester = 1;
        MaxIntellect = 30;
        Intellect = 30;
        StrengthOfArgument = 3;
        CounterArgument = 10;
        CriticalArgument = 10;
    }

    public override bool hasLost()
    {
        Console.WriteLine("I lost!");
        return true;
        // return base.hasLost();
    }

    public override bool beDrained(int amount) {
        Console.WriteLine("I lose {0} amount of Intellect.", amount);
        return true;
    }

    public override void getExperience() {
        Console.WriteLine("");
        Console.WriteLine("STUDENT ATTRIBUTES UPGRADE");
        Console.WriteLine("Student called name: {0} increased: preparation: {1} , Semester: {2}, MaxIntellect: {3}, Intellect: {4}, StrengthOfArgument: {5}, CounterArgument: {6}, CriticalArgument: {7}", name, preparation, Semester, MaxIntellect, Intellect, StrengthOfArgument, CounterArgument,CriticalArgument);
    }
}