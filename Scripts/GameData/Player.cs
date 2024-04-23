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
        public int Atk { get => atk + equipAtk; }
        public int Def { get => def + equipDef; }
        public int Health { get => health; }
        public int Gold { get => gold; set { gold = value; } }
        public int EquipAtk { get => equipAtk; set { equipAtk = value; } }
        public int EquipDef { get => equipDef; set { equipDef = value; } }

        public Player(string name)
        {
            this.name = name;
            level = 1;
            atk = 10;
            def = 5;
            health = 100;
            gold = 1500;
        }
    }
}
