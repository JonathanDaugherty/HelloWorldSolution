using System;

namespace HelloWorldProject {
   
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello World in C#!");
            Console.WriteLine("C# written by Jonathan Daugherty");
            var counter = 0;
            Console.WriteLine(counter);
            counter = counter + 13;
            Console.WriteLine(counter);
            counter = counter - 3;
            Console.WriteLine(counter);
            counter = counter * 5;
            Console.WriteLine(counter);
            counter = counter / 7;
            Console.WriteLine(counter);

            var numerator = 10.0;
            var denominator = 3.0;
            Console.WriteLine(numerator / denominator);
            var modulo = 10 % 3;
            Console.WriteLine(modulo);

            var firstname = "Jonathan";
            var lastname = "Daugherty";
            var fullname = firstname + " " + lastname;
            fullname = $"firstname is {firstname} and lastname is {lastname}";
            Console.WriteLine(fullname);
           // fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

           // var biggerScopeVariable = 77;

            {
                var scopeVariable = 1;
                Console.WriteLine(scopeVariable);
               
            }
            //biggerScopeVariable = biggerScopeVariable + 1;

            bool oneEqualsOne = (1 == 1);
            bool thisIsFalse = !oneEqualsOne;

            int[] assessmentScores = new int[2];
            assessmentScores[0] = 120;
            assessmentScores[1] = 95;
            Console.WriteLine($"index 0 is {assessmentScores[0]} and index 1 is {assessmentScores[1]}");

          

            var topics = new string[5];
            topics[0] = "Git/Github";
            topics[1] = "SQL";
            topics[2] = "C#";
            topics[3] = "Javascript";
            topics[4] = "Angular";
            Console.WriteLine(topics[0]);
            Console.WriteLine(topics[1]);
            Console.WriteLine(topics[2]);
            Console.WriteLine(topics[3]);
            Console.WriteLine(topics[4]);



            
          
           


            
        }   
       
    }
}
