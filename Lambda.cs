using System;

namespace Test
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }
    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;

    }
    class Lambda
    {
        static List<Item> _items = new List<Item>();
        // delegate Return MyFunc<T, Return>(T item); // 제네릭 델리게이트

        static Item FindItem(unc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                {
                    return item;
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            _items.Add(new Item() {ItemType = ItemType.Weapon, Rarity = Rarity.Normal});
            _items.Add(new Item() {ItemType = ItemType.Armor, Rarity = Rarity.Uncommon});
            _items.Add(new Item() {ItemType = ItemType.Ring, Rarity = Rarity.Rare});

            //delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재함
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action

            // (Anonymous Function) 무명 함수 / 익명 함수
            Item item = FindItem(delegate (Item item)
            {
                return item.ItemType == ItemType.Weapon;
            });

            // Lambda : 일회용 함수를 만드는데 사용하는 문법이다. (델리게이트를 활용해 재사용도 가능하긴 함)
            Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });
        }
    }
}