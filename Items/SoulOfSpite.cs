using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items
{
    internal class SoulOfSpite : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.sellPrice(silver: 5);
            Item.maxStack = 9999;
            Item.ResearchUnlockCount = 25;
            Item.rare = ItemRarityID.Lime;
        }
    }
}
