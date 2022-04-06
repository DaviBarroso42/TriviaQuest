using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class TriviaItem
    {
       
        private String Question;
        private String Answer;
        string playerAnswer;
        public TriviaItem(String question, String answer)
        {
            Question = question;
            Answer = answer;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Question);
            Console.Write("Digite a sua resposta: ");
            playerAnswer = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine(Answer);
            Console.ReadKey();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); 
        }


        public void CheckPlayerAnswer()
        {
            //make the method
        }
    }
}
