using static System.Net.Mime.MediaTypeNames;

namespace TextRPG
{
    public class LobbyScreen
    {
        private GameManager gm;
        private StatusScreen statusScreen;
        private InventoryScreen inventoryScreen;
        private ShopScreen shopScreen;
        public LobbyScreen()
        {
            gm = GameManager.instance;
            statusScreen = new StatusScreen();
            inventoryScreen = new InventoryScreen();
            shopScreen = new ShopScreen();
        }

        // 로비 화면
        public void LobbyScreenOn()
        {
            Console.Clear();

            while (true)
            {
                LobbyText();
                gm.Text.MyActionText();

                // 1, 2, 3만 입력 받을 수 있게 함 
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input < 4)
                {
                    switch (input)
                    {
                        case 1:
                            statusScreen.StatusScreenOn();
                            break;
                        case 2:
                            inventoryScreen.InventoryScreenOn();
                            break;
                        case 3:
                            shopScreen.ShopScreenOn();
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다! 1부터 3까지의 숫자를 다시 입력하세요.\n");
                }

            }
        }

        // 로비화면 텍스트 출력
        private void LobbyText()
        {
            Console.WriteLine();

            Console.WriteLine($"스파르타 마을에 오신 {gm.Player.Name}님 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다. \n");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점\n");
        }

    }
}
