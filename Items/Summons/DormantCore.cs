using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Summons
{
    internal class DormantCore : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 999;
            Item.ResearchUnlockCount = 25;
            Item.rare = ItemRarityID.Green;
        }
    }
}
