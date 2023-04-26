using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Weapons
{
    public class RepairedHeroSword : ModItem
    {

        public override void SetDefaults()
        {
            Item.damage = 400;
            Item.DamageType = DamageClass.Melee;
            Item.width = 60;
            Item.height = 60;
            Item.scale = 1.2f;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 1;
            Item.value = 200000;
            Item.ResearchUnlockCount = 1;
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(ModContent.TileType<Tiles.Furniture.Supercrafter>());
            recipe.Register();
        }
    }
}