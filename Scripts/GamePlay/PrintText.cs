

namespace TextRPG
{
    public enum TextType { Login, MyAction, Lobby, Status, Inventory, Equip, Shop , Item }
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
     
       
        // 인벤토리 아이템 텍스트 출력
        public void InventoryItemText(Item item)
        {
            string equip = item.IsEquip ? "[E]" : "";
            string itemType = item.Itemtype == ItemTypes.Attack ? "공격력" : "방어력";
            Console.WriteLine($"{equip}{item.ItemName}\t| {itemType} {item.Value} |\t{item.Desc}");
        }


        // 플레이어의 행동 텍스트 출력
        public void MyActionText()
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
        }


    }
}
