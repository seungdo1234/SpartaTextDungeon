
namespace TextRPG
{
    public class GameProgram
    {
        private GameManager gm;
        private LobbyScreen lobby;

        public GameProgram()
        {
            gm = GameManager.instance;
            lobby = new LobbyScreen();
        }

        // 게임 시작
        public void GameStart()
        {
            gm.Init();

            gm.Login();

            lobby.LobbyScreenOn();
        }


        static void Main(string[] args)
        {
            GameProgram program = new GameProgram();

            program.GameStart();
        }
    }

}
