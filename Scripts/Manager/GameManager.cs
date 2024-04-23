
namespace TextRPG
{
    public class GameManager
    {
        public static GameManager instance = new GameManager();


        private PrintText text;
        public PrintText Text { get => text; }

        private Player player;
        public Player Player{ get => player;}


        // GameManger 초기화
        public void Init()
        {
            text = new PrintText();
        }

        // 로그인
        public void Login()
        {
            text.LoginText();
            
            // 닉네임을 입력받고 해당 닉네임으로 게임 시작
            player = new Player(Console.ReadLine());

            DataManager.instance.Init();
        }




    }
}
