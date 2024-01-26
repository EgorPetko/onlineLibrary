namespace onlineLibrary.BookEntities
{
    public class BookEvaluation
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string? Text { get; set; }

        public int? Evaluation
        {
            get { return Evaluation; }
            set
            {
                Evaluation = null;
                if (value <= 5 && value >= 1) Evaluation = value;
                {
                    Console.WriteLine("Неправильная оценка");
                }
            }
        }
        public BookEvaluation(int id, int userId, string? text = null, int? evaluation = null)
        {
            Id = id;
            UserId = userId; 
            Text = text; 
            Evaluation = evaluation; //проверить set
            
        }
    }

}
