namespace QuizWeek3.Domain.Entity
{
    public class HelperClass
    {
        public string GoodAnswer { get; set; }
        public string Question { get; set; }
        public int IdQuestion { get; set; }
        public char Choice { get; set; }
        public double TimeToAnswer { get; set; }

        public HelperClass(string goodAnswer, string question, int idQuestion)
        {
            GoodAnswer = goodAnswer;
            Question = question;
            IdQuestion = idQuestion;
        }
        public HelperClass(char choice, double timeToAnswer)
        {
            Choice = choice;
            TimeToAnswer = timeToAnswer;
        }
    }
}
