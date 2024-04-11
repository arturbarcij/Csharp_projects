using System.Collections.Generic;
using System;
public class Classroom {

    public DIKUperson Discussion (DIKUperson d1, DIKUperson d2) {
        Console.WriteLine("");
        Console.WriteLine ("Debate til drained !");
        int round = 1;
        DIKUperson current = d1;
        DIKUperson inactive = d2;

        while (!(d1.hasLost()) && (!(d2.hasLost()))) {
            
            Console.WriteLine("ROUND: {0}", round );
            current.Argue(inactive);

            var temp = current;
            current = inactive;
            inactive = temp;
            round ++;
        }
        if (d1.hasLost()) {
            d2.getExperience();
            Console.WriteLine ("The winner is: {0} ", d2 );
            return d2;
        }
        else {
            d1.getExperience();
            Console.WriteLine ("The winner is: {0} ", d1 );
            return d1;
        }
        
    }

    public DIKUperson RunDebate(List <DIKUperson> listOfdikupersons) 
    {
        DIKUperson winner;
        List <DIKUperson> DIKUcontestants = listOfdikupersons;
        
        DIKUcontestants[0].Argue(DIKUcontestants[1]);

        if (DIKUcontestants[0].hasLost()) 
        {
            
            DIKUcontestants[1].Argue(DIKUcontestants[2]);
            
            if (DIKUcontestants[1].hasLost()) 
            {
                
                DIKUcontestants[2].Argue(DIKUcontestants[3]);

                if (DIKUcontestants[2].hasLost()) 
                {

                    winner = DIKUcontestants[3];
                    return winner;
                }
                else 
                {
                    winner = DIKUcontestants[2];
                    return winner;
                }
            }
            else 
            {
                DIKUcontestants[1].Argue(DIKUcontestants[3]);

                if (DIKUcontestants[3].hasLost()) 
                {
                    winner = DIKUcontestants[1];
                    return winner;
                }
                else 
                {
                    winner = DIKUcontestants[3];
                    return winner;
                }
            }
            
        }
        else 
        {
            DIKUcontestants[0].Argue(DIKUcontestants[2]);

            if (DIKUcontestants[2].hasLost()) 
            {
                
                DIKUcontestants[0].Argue(DIKUcontestants[3]);

                if (DIKUcontestants[3].hasLost()) 
                {
                    
                    winner = DIKUcontestants[0];
                    return winner;
                } 
                else 
                {
                    winner = DIKUcontestants[3];
                    return winner;
                }
            }
            else 
            {
                
                DIKUcontestants[2].Argue(DIKUcontestants[3]);

                if (DIKUcontestants[3].hasLost()) 
                {
                    winner = DIKUcontestants[2];
                    return winner;
                }
                 else 
                    {
                        winner = DIKUcontestants[3];
                        return winner;
                    }

                    
            }
                
        }
        
    }

}