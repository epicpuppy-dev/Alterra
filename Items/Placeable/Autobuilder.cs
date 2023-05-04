using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Placeable
{
    internal class Autobuilder : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(gold: 25);
            Item.maxStack = 99;
            Item.ResearchUnlockCount = 5;
            Item.rare = ItemRarityID.Green;
        }
    }

    public class AutobuilderNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.Merchant)
            {
                shop.Add<Autobuilder>(new Condition("skeletronDefeated", () => NPC.downedBoss3));
            }
        }
    }
}
