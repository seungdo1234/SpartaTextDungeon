﻿
namespace TextRPG
{
    public class GameManager
    {
        public static GameManager instance = new GameManager();

        private Player player;
        public Player Player{ get => player;}

        private DungeonData dungeonData;
        public  DungeonData DungeonData { get => dungeonData; }

        // 로그인
        public void Login()
        {
            dungeonData = new DungeonData();

            LoginText();

            // 닉네임을 입력받고 해당 닉네임으로 게임 시작
            player = new Player(Console.ReadLine());

            ItemDataManager.instance.Init();
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
