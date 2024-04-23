
namespace TextRPG
{
    public enum ItemTypes { Attack, Defence }
    public class Item // 아이템 정보가 담긴 클래스
    {
        private bool isSell; // 아이템이 팔렸는 지
        private bool isEquip; // 장착 중인지
        private string itemName; //
        private ItemTypes itemtype; // 무기인지, 방어구인지
        private int value; // 아이템의 능력치
        private string desc;
        private int gold;


        public bool IsSell { get => isSell; set { isSell = value; } }
        public bool IsEquip { get => isEquip; set { isEquip = value; } }
        public string ItemName { get => itemName; }
        public ItemTypes Itemtype { get => itemtype; }
        public int Value { get => value; }
        public string Desc { get => desc; }
        public int Gold { get => gold; }


        // 아이템 초기화
        public Item(string itemName, ItemTypes itemType,int value ,string desc, int gold)
        {
            isEquip = false;
            this.itemName = itemName;
            this.itemtype = itemType;
            this.value = value;
            this.desc = desc;
            this.gold = gold;
        }
    }
}