namespace Course
{
    internal class GameLoop
    {

        public Player currentPlayer;
        private TriviaItem Trivia1;
        private TriviaItem Trivia2;
        private TriviaItem Trivia3;
        private String gameTitle;

        public GameLoop()
        {
            gameTitle = @"
  _______   _       _          ____                  _   
 |__   __| (_)     (_)        / __ \                | |  
    | |_ __ ___   ___  __ _  | |  | |_   _  ___  ___| |_ 
    | | '__| \ \ / / |/ _` | | |  | | | | |/ _ \/ __| __|
    | | |  | |\ V /| | (_| | | |__| | |_| |  __/\__ \ |_ 
    |_|_|  |_| \_/ |_|\__,_|  \___\_\\__,_|\___||___/\__|
                                                         
                                                         
";
            Trivia1 = new TriviaItem("De quem é a famosa frase “Penso, logo existo”?", "Descartes");
            Trivia2 = new TriviaItem("Qual o livro mais vendido no mundo a seguir à Bíblia?", "Dom Quixote");
            Trivia3 = new TriviaItem("De onde é a invenção do chuveiro elétrico?", "Brasil");
            currentPlayer = new Player(".", 0);
            currentPlayer.Name = "";
            currentPlayer.Score = 0;
        }

        public void Play()
        {

            Console.WriteLine(gameTitle);
            Console.Write("Qual o seu nome: ");
            currentPlayer.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(gameTitle);
            Trivia1.DisplayQuestion();
            Trivia2.DisplayQuestion();
            Trivia3.DisplayQuestion();
            Console.WriteLine($"Thank you for playing {currentPlayer.Name}, your final score is {currentPlayer.Score}");
        }
    }
}
