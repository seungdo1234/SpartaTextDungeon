namespace TextRPG
{
    public class Player
    {
        // 캐릭터 정보
        private string name;
        private int level;
        private float atk;
        private float def;
        private int health;
        private int maxHealth;
        private int gold;

        // 플레이어 경험치
        private int exp; // 현재 경험치
        private int[] levelExp; // 레벨 별 경험치 통

        // 플레이어가 장착한 장비
        private Item equipAtkItem; 
        private Item equipDefItem;

        public string Name { get => name; }
        public int Level { get => level; }
        public float Atk { get => atk + equipAtkItem.Value; }
        public float Def { get => def + equipDefItem.Value;}
        public int Health {  get => health; }
        public int MaxHealth { get => maxHealth; }
        public int Gold { get => gold; set { gold = value; } }
        public Item EquipAtkItem { get => equipAtkItem; set { equipAtkItem = value; } }
        public Item EquipDefItem { get => equipDefItem; set { equipDefItem = value; } }

        public Player(string name)
        {
            this.name = name;
            level = 1;
            atk = 10;
            def = 5;
            maxHealth = 100;
            health = maxHealth;
            gold = 10000;
            levelExp = new int[10] {1,2,3,4,5,6,7,8,9,10};
        }


        public void OnDamaged(int health) // 피격
        {
            this.health -= health; 
        }

        public void RecoveryHealth(int health)
        {
            if(this.health + health > maxHealth)
            {
                this.health = maxHealth;
            }
            else
            {
                this.health += health;
            }
        }
        public void ExpUp() // 경험치 상승
        {
            if (++exp == levelExp[level - 1])
            {
                LevelUp();
                level++;
                exp = 0;
            }
        }

        private void LevelUp() // 레벨업 
        {
            atk += 0.5f;
            def += 1;
        }
    }
}
