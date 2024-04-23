

namespace TextRPG
{
    internal class EquipScreen
    {
        private GameManager gm;
        private DataManager dm;
        public EquipScreen()
        {
            gm = GameManager.instance;
            dm = DataManager.instance;
        }

        // 장비 장착
        public void EquipScreenOn()
        {
            Console.Clear();

            while (true)
            {
                EquipText ();
                gm.Text.MyActionText();

                // 0. 뒤로 가기  장비 번호 : 장착/ 장착 해제
                if (int.TryParse(Console.ReadLine(), out int input) && input >= 0 && input <= dm.PlayerItemsCount())
                {

                    if (input == 0) 
                    {
                        return;
                    }

                    Item item = dm.GetPlayerItem(input - 1);

                    item.Equip(); // 장비 장착 및 해제

                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다! 숫자를 제대로 입력하세요. \n");
               }
            }
        }


        // 장비 장착 텍스트 출력
        private void EquipText()
        {
            Console.WriteLine();

            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 장착할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < dm.PlayerItemsCount(); i++)
            {
                Console.Write($"- {i + 1} ");
                gm.Text.InventoryItemText(dm.GetPlayerItem(i));
            }

            Console.WriteLine();

            Console.WriteLine("0. 나가기");

            Console.WriteLine();

        }
    }
}
