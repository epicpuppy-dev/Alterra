using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Tools
{
    internal class Pen : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.value = Item.buyPrice(silver: 50);
            Item.maxStack = 999;
            Item.ResearchUnlockCount = 25;
            Item.rare = ItemRarityID.Green;
        }
    }

    public class PenNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.Merchant)
            {
                shop.Add<Pen>();
            }
        }
    }
}
