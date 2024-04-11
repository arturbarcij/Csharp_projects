// See https://aka.ms/new-console-template for more information
using System;


class Program {
    public static void Main() {

        //OBJECT INSTANCES
      DIKUperson person0 = new DIKUperson("person0", preparation.ReadingAll);
      DIKUperson person1 = new DIKUperson("person1", preparation.ReadingAll);
      DIKUperson person2 = new DIKUperson("person2", preparation.ReadingNone);
      DIKUperson person3 = new DIKUperson("person3", preparation.ReadingSome);

      DIKUstudent student0 = new DIKUstudent("student0", preparation.ReadingAll);
      DIKUstudent student1 = new DIKUstudent("student1", preparation.ReadingAll);
      DIKUstudent student2 = new DIKUstudent("student2", preparation.ReadingAll);
      DIKUstudent student3 = new DIKUstudent("student3", preparation.ReadingAll);

      DIKUprofessor professor0 = new DIKUprofessor("professor0", preparation.ReadingAll);
      DIKUprofessor professor1 = new DIKUprofessor("professor1", preparation.ReadingAll);
      DIKUprofessor professor2 = new DIKUprofessor("professor2", preparation.ReadingAll);
      DIKUprofessor professor3 = new DIKUprofessor("professor3", preparation.ReadingAll);

      Classroom classrom = new Classroom();

      //LIST

      List <DIKUperson> listOfDikuPersons = new List <DIKUperson>();
      listOfDikuPersons.Add(person0);
      listOfDikuPersons.Add(person1);
      listOfDikuPersons.Add(person2);
      listOfDikuPersons.Add(person3);
      
      //LIST TEST
      Console.WriteLine(listOfDikuPersons[0]);
      Console.WriteLine(listOfDikuPersons[1]);
      Console.WriteLine(listOfDikuPersons[2]);
      Console.WriteLine(listOfDikuPersons[3]);


      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("WELCOME TO DIKUdebate!");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("LOADING CODE...");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("MAKING NEW PERSONS");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine(person0);
      Console.WriteLine(person1);
      Console.WriteLine(person2);
      Console.WriteLine(person3);
      Console.WriteLine("----------------------------------------------");


      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("DRAINED");
      Console.WriteLine("----------------------------------------------");
      //DRAINED TEST
      person0.beDrained(5);
      person1.beDrained(5);
      person2.beDrained(5);
      person3.beDrained(5);

      Console.WriteLine(person0);
      Console.WriteLine(person1);
      Console.WriteLine(person2);
      Console.WriteLine(person3);

      
      
      //ARGUE TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("ARGUE");
      Console.WriteLine("----------------------------------------------");
      person0.Argue(person1);
      person1.Argue(person2);
      person2.Argue(person3);
      person3.Argue(person0);

      //GETEXPERIENCE TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("GET EXPERIENCE");
      Console.WriteLine("----------------------------------------------");
      person0.getExperience();
      person1.getExperience();
      person2.getExperience();
      person3.getExperience();
      Console.WriteLine(person0);
      Console.WriteLine(person1);
      Console.WriteLine(person2);
      Console.WriteLine(person3);

      Console.WriteLine("");
      Console.WriteLine("");

      //DISCUSSION TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("DISCUSSION");
      Console.WriteLine("----------------------------------------------");
      classrom.Discussion(person0, person1);
      classrom.Discussion(person1, person2);
      classrom.Discussion(person2, person3);
      classrom.Discussion(person3, person0);

      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("DEBATE WITH STUDENTS AND PROFESSORS");
      Console.WriteLine("----------------------------------------------");

      //MAKING STUDENTS
      Console.WriteLine("MAKING NEW STUDENTS");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine(student0);
      Console.WriteLine(student1);
      Console.WriteLine(student2);
      Console.WriteLine(student3);

      Console.WriteLine("MAKING NEW PROFESSORS");
      Console.WriteLine("----------------------------------------------"); 
      Console.WriteLine(professor0);
      Console.WriteLine(professor1);
      Console.WriteLine(professor2);
      Console.WriteLine(professor3);

      //BE DRAINED
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("BEDRAINED S TEST");
      Console.WriteLine("----------------------------------------------");
      student0.beDrained(10);
      student0.beDrained(10);
      student0.beDrained(10);
      student0.beDrained(10);

      Console.WriteLine(student0.Intellect);
      Console.WriteLine(student1.Intellect);
      Console.WriteLine(student2.Intellect);
      Console.WriteLine(student3.Intellect);

      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("ARGUE S TEST");
      Console.WriteLine("----------------------------------------------");
      student0.Argue(student1);
      student1.Argue(student2);
      student2.Argue(student3);
      student3.Argue(student0);

      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("GETEXPIERENCE S TEST");
      Console.WriteLine("----------------------------------------------");
      student0.getExperience();
      student1.getExperience();
      student2.getExperience();
      student3.getExperience();

      
      //HASLOST P TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("HASLOST P TEST");
      Console.WriteLine("----------------------------------------------");
      professor0.hasLost();
      professor1.hasLost();
      professor2.hasLost();
      professor3.hasLost();
      
      //BEDRAINED P TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("BEDRAINED P TEST");
      Console.WriteLine("----------------------------------------------");
      professor0.beDrained(10);
      professor1.beDrained(10);
      professor2.beDrained(10);
      professor3.beDrained(10);
      
      //GETEXPERIENCE P TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("GETEXPERIENCE P TEST");
      Console.WriteLine("----------------------------------------------");
      professor0.getExperience();
      professor1.getExperience();
      professor2.getExperience();
      professor3.getExperience();
      
      //ARGUE TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("ARGUE P AND S TEST");
      Console.WriteLine("----------------------------------------------");
      professor0.Argue(student1);
      professor1.Argue(student2);
      professor2.Argue(student3);
      professor3.Argue(student0);

      //DISCUSSION TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("DISCUSSION P AND S TEST");
      Console.WriteLine("----------------------------------------------");
      classrom.Discussion(student0, professor0);
      classrom.Discussion(student1, professor1);
      classrom.Discussion(student2, professor2);
      classrom.Discussion(student3, professor3);
      

      //RUN DEBATE TEST
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("RUN DEBATE TEST");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("WINNER OF DEBATE IS: ");
      
      Console.WriteLine(classrom.RunDebate(listOfDikuPersons));
      Console.WriteLine(classrom.RunDebate(listOfDikuPersons));
      
    }
    
    
}


