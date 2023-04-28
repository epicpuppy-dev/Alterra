
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items
{
    internal class AsteriumFragment : ModItem
    {
        public override void SetDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 12));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            ItemID.Sets.ItemNoGravity[Item.type] = true;

            Item.width = 20;
            Item.height = 20;
            Item.value = 10000;
            Item.maxStack = 9999;
            Item.ResearchUnlockCount = 25;
            Item.rare = ModContent.RarityType<Rarities.AlternatingPurple>();
        }
    }

    public class AsteriumFragmentNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AsteriumFragment>(), 1, 8, 10));
            }
            if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
            {
                LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
                leadingConditionRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<AsteriumFragment>(), 1, 8, 10));
                npcLoot.Add(leadingConditionRule);
            }
        }
    }
}
