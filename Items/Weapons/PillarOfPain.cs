using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Weapons
{
    public class PillarOfPain : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("PillarOfPain"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("Warning: Keep away from small childrens' foreheads");
        }

        public override void SetDefaults()
        {
            Item.damage = 80;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.scale = 3f;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 100000;
            Item.ResearchUnlockCount = 1;
            Item.rare = 7;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.RedBrick, 100);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.Register();
        }

        public override void ModifyHitNPC(Player player, NPC target, ref NPC.HitModifiers modifiers)
        {
            target.AddBuff(ModContent.BuffType<Buffs.WoundDebuff>(), 180);
        }

        public override void ModifyHitPvp(Player player, Player target, ref Player.HurtModifiers modifiers)
        {
            target.AddBuff(ModContent.BuffType<Buffs.WoundDebuff>(), 180);
        }
    }
}