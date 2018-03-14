using System;
using System.Collections.Generic;
using System.Text;

namespace FrameForAList.Model
{
    public class ShopItemPair : Tuple<ShopItem, ShopItem>

    {
        public ShopItemPair(ShopItem item1, ShopItem item2) : base(item1, item2??CreateEmptyModel())
        {
        }

        private static ShopItem CreateEmptyModel()
        {
            return new ShopItem { IsVisible = false };

        }
    }
}
