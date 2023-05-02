
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items
{
    internal class Screwdriver : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = Item.buyPrice(gold: 10);
            Item.maxStack = 999;
            Item.ResearchUnlockCount = 25;
            Item.rare = ItemRarityID.Green;
        }
    }

    public class ScrewdriverNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.Merchant)
            {
                shop.Add<Screwdriver>(new Condition("skeletronDefeated", () => NPC.downedBoss3));
            }
        }
    }
}
