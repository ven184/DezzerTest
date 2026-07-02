namespace DezzerTest.Models
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public string Text { get; set; }
        public string Character { get; set; }
    }
}