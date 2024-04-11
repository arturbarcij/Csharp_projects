namespace Fundamentals 
{
    public class Fundamentals 
    {

       private string name;


        public Fundamentals(String theName)
        {
            name = theName;
        }

        public string getName {
            get {return name;}
            set {name = value;}
        }
        public void CountBackwards (Fundamentals fundamental)
        {
            
            for (var i = 10; i > 0; i--) 
            {
                Console.Write("{0}, ", i);
            }
            Console.Write("Finished!");
            Console.WriteLine("");
            
        }

        public string ReverseString (Fundamentals fundamental, string str) {
            
            string revstr = "";

            if (str.Length <= 1) {
                
                Console.Write(str);
                return str;
            }
            else 
            {
                revstr = str;

                Console.Write(revstr[revstr.Length-1]);
                ReverseString(fundamental, revstr.Substring(0,(revstr.Length-1)));

                return str;
            }
        }

         public double GCD (Fundamentals fundamental, double a, double b) {
                double GCD = 0;
                double r;
                double a1 = Math.Abs(a);
                double b1 = Math.Abs(b);

            if ((a1 == 0) && (b1 == 0)) {
                return 0;
            }
            else if (a1 == 0) {
                return b1;
            }
            else if (b1 == 0) {
                return a1;
            }
            else {
                while (b1 != 0) {
                    r = a1 % b1;
                    a1 = b1;
                    b1 = r;
                    
                }
                
                GCD = a1;
                Console.Write(a1);
                return GCD;

            }
            }
    
    
        
    
    
    
    




    
    }
}