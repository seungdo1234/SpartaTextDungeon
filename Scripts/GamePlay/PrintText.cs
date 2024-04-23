

namespace TextRPG
{
    public class PrintText
    {
        private GameManager gm;
        private DataManager dm;
        public PrintText()
        {
            gm = GameManager.instance;
            dm = DataManager.instance;
        }

        public void LoginText()
        {
            Console.WriteLine();

            Console.WriteLine("┌-----------------------------------------------┐");
            Console.WriteLine("│                 스파르타 던전                 │");
            Console.WriteLine("└-----------------------------------------------┘");

            Console.WriteLine("\n");

            Console.Write("닉네임을 입력하세요 >> ");

        }

    }
}
