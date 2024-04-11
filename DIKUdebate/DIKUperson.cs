
using System;
public class DIKUperson {

    //all sets are set to private, bcuz i do not want other classes to access these fields
    //because they are individiual to the given instance of a DIKUperson, thus rewriting
    // them by other classes would be against the use of these fields
    //edit: bcuz of subclasses eveything is public
    public string name {get;  set;}
    public int MaxIntellect {get;  set;}
    public int Intellect {get;  set;}
    //cannot be larger than MaxIntellect
    public int StrengthOfArgument {get;  set;}
    public int Semester {get;  set;}
    public int CounterArgument {get;  set;}

    public int CriticalArgument {get;  set;}
    
    public preparation preparation {get;  set;}

    private Random rand = new Random();


    
    //Constructor
    public DIKUperson (string Name, preparation Preparation) {
        name = Name;
        preparation = Preparation;
        Semester = 1;
        MaxIntellect = 30;
        Intellect = 30;
        StrengthOfArgument = 3;
        CounterArgument = 10;
        CriticalArgument = 10;
    }

    //OVERRIDE
    public override string ToString() {
        return string.Format (
            "Name: {0}, Semester: {1}, Intellect: {2}",
            name,
            Semester,
            Intellect);
    }

    public virtual bool hasLost() {
        if (Intellect <= 0) {
            
            return true;
        }
        else {
            return false;
        }
    }

    public virtual bool beDrained(int amount) {
        int generator = rand.Next(101);
        if (CounterArgument > generator) {
            return false;
        }
        else {
            
            Intellect -= amount;
            return true;
        }
    }

    public void Argue(DIKUperson opponent) {
        int generator = rand.Next(101);
        if (CriticalArgument > generator)  {
            opponent.beDrained(2*StrengthOfArgument);
            Console.WriteLine("");
            Console.WriteLine("{0} does {1} dmg to {2}",  name, 2*StrengthOfArgument, 
            opponent.name);
        }  
        else {
            opponent.beDrained(StrengthOfArgument);
            Console.WriteLine("");
            Console.WriteLine("{0} does {1} dmg to {2}",  name, StrengthOfArgument,
             opponent.name);
        }
    }

    public virtual void getExperience() {
        Semester += 1;
        StrengthOfArgument += 2;

        if (preparation == preparation.ReadingNone) {
            MaxIntellect += 10;
        }
        else {
            MaxIntellect += 20;
        }
        //hvis studenten ved None så skal den få mere end hvis den ved Some ifl. opgaven, 
        // derfor har jeg lavet om på if statement

        if ((preparation == preparation.ReadingSome) && (preparation == preparation.ReadingAll))
        {
            CounterArgument += 6;
        }
        else {
            CounterArgument += 3;
        }

        if (preparation == preparation.ReadingAll) {
            CriticalArgument += 6;
        }
        else {
            CriticalArgument += 3;
        }
        
        Intellect = MaxIntellect;

    }

}