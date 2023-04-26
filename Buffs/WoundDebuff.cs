

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
            player.GetModPlayer<WoundDebuffPlayer>().hasWound = true;
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
                damage = 20;

                if (npc.lifeRegen > 0) npc.lifeRegen = 0;

                npc.lifeRegen -= 150;
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

        public override void UpdateLifeRegen()
        {
            if (hasWound)
            {
                if (Player.lifeRegen > 0) Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;
                Player.lifeRegen -= 150;
            }
        }
    }
}
