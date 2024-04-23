
namespace TextRPG
{
    public enum ItemTypes { Attack, Defence }
    public class Item
    {
        private bool isEquip;
        private string itemName;
        private ItemTypes itemtype;
        private int value;
        private string desc;
        private int gold;


        public bool IsEquip { get => isEquip; }
        public string ItemName { get => itemName; }
        public ItemTypes Itemtype { get => itemtype; }
        public int Value { get => value; }
        public string Desc { get => desc; }
        public int Gold { get => gold; }

        public Item(string itemName, ItemTypes itemType,int value ,string desc, int gold)
        {
            isEquip = false;
            this.itemName = itemName;
            this.itemtype = itemType;
            this.value = value;
            this.desc = desc;
            this.gold = gold;
        }

        // 장비 장착 및 해제
        public void Equip()
        {
            isEquip = !isEquip;

            if(isEquip)
            {
                GameManager.instance.Player.Equip(itemtype, value);
            }
            else
            {
                GameManager.instance.Player.UnEquip(itemtype, value);
            }
        }

        // 아이템 구매
        public void Buy()
        {
            GameManager.instance.Player.BuyItem(gold);
            gold = 0;
        }
    }
}