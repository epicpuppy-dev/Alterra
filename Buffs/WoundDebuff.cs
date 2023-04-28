

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Buffs
{
    internal class WoundDebuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<WoundDebuffNPC>().hasWound = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.lifeRegen > 0) player.lifeRegen = 0;

            player.lifeRegenTime = 0;
            player.lifeRegen -= 100;
        }
    }

    public class WoundDebuffNPC : GlobalNPC
    {
        public bool hasWound;
        public override bool InstancePerEntity => true;

        public override void ResetEffects(NPC npc)
        {
            hasWound = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (hasWound)
            {
                damage = 25;

                if (npc.lifeRegen > 0) npc.lifeRegen = 0;

                npc.lifeRegen -= 100;
            }
        }

    }

    public class WoundDebuffPlayer : ModPlayer
    {
        public bool hasWound;

        public override void ResetEffects()
        {
            hasWound = false;
        }
    }
}
