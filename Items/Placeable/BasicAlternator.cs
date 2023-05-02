using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Placeable
{
    internal class BasicAlternator : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Tooltip.SetDefault("Reaches into parallel worlds to reverse ores’ essence");
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.BasicAlternator>());
            Item.width = 24;
            Item.height = 16;
            Item.value = Item.sellPrice(silver: 70);
            Item.ResearchUnlockCount = 1;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.IronBar, 15)
                .AddIngredient(ItemID.FallenStar, 5)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}
