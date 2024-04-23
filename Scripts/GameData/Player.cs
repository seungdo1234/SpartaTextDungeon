namespace TextRPG
{
    public class Player
    {
        // 캐릭터 정보
        private string name;
        private int level;
        private int atk;
        private int def;
        private int health;
        private int gold;
        private int equipAtk;
        private int equipDef;

        public string Name { get => name; }
        public int Level { get => level; }
        public int Atk { get => atk; }
        public int Def { get => def; }
        public int Health { get => health; }
        public int Gold { get => gold; }
        public int EquipAtk { get => equipAtk; }
        public int EquipDef { get => equipDef; }

        public Player(string name)
        {
            this.name = name;
            level = 1;
            atk = 10;
            def = 5;
            health = 100;
            gold = 1500;
        }


        public void Equip(ItemTypes type, int value)
        {
            if (type == ItemTypes.Attack)
            {
                equipAtk += value;
                atk += value;
            }
            else
            {
                equipDef += value;
                atk -= value;
            }
        }

        public void UnEquip(ItemTypes type, int value)
        {
            if (type == ItemTypes.Attack)
            {
                equipAtk -= value;
            }
            else
            {
                equipDef -= value;
            }
        }

        public void BuyItem(int gold)
        {
            this.gold -= gold;
        }
    }
}
