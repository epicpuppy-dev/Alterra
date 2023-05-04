using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Weapons
{
    public class Sledgehammer : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 150;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.scale = 3f;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = 1;
            Item.knockBack = 12;
            Item.value = Item.sellPrice(gold: 10);
            Item.ResearchUnlockCount = 1;
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddIngredient(ModContent.ItemType<SoulOfSpite>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}