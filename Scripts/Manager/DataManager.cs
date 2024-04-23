﻿namespace TextRPG
{
    public class DataManager
    {
        public static DataManager instance = new DataManager();

        // 플레이어, 상점 아이템 리스트
        private List<Item> playerItems;
        private List<Item> shopItems;

        // 플레이어, 상점 아이템 초기화
        public void Init()
        {
            playerItems = new List<Item>();
            shopItems = new List<Item>();

            shopItems.Add(new Item("수련자 갑옷", ItemTypes.Defence, 5, "수련에 도움을 주는 갑옷입니다.", 1000));
            shopItems.Add(new Item("무쇠 갑옷", ItemTypes.Defence, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500));
            shopItems.Add(new Item("스파르타의 갑옷", ItemTypes.Defence, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500));
            shopItems.Add(new Item("낡은 검", ItemTypes.Attack, 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600));
            shopItems.Add(new Item("청동 도끼", ItemTypes.Attack, 5, "쉽게 볼 수 있는 낡은 검 입니다.", 1500));
            shopItems.Add(new Item("스파르타의 창", ItemTypes.Attack, 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 3000));
        }

        public int PlayerItemsCount()
        {
            return playerItems.Count;
        }

        public int ShopItemsCount()
        {
            return shopItems.Count;
        }

        public Item GetPlayerItem(int i)
        {
            return playerItems[i];
        }

        public Item GetShopItem(int i)
        {
            return shopItems[i];
        }

        // 아이템을 구매했을 때 플레이어 아이템 리스트에 추가
        public void AddPlayerItem(Item item)
        {
            playerItems.Add(item);
            item.Buy();
        }
    }
}
