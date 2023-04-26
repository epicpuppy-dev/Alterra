
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Placeable
{
    internal class Supercrafter : ModItem
    {

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Supercrafter>());
            Item.width = 32;
            Item.height = 24;
            Item.value = 250000;
            Item.ResearchUnlockCount = 1;
            Item.rare = ItemRarityID.Red;
        }
    }

    public class SupercrafterNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Supercrafter>(), 3));
            }
        }
    }
}
