
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Placeable
{
    internal class AdvancedAlternator : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Advanced Alternator");
            // Tooltip.SetDefault("Reaches into parallel worlds to reverse ores’ essence");
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AdvancedAlternator>());
            Item.width = 24;
            Item.height = 16;
            Item.value = Item.sellPrice(gold: 2);
            Item.ResearchUnlockCount = 1;
            Item.rare = ModContent.RarityType<Rarities.AlternatingBlue>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BasicAlternator>())
                .AddIngredient(ItemID.SoulofNight, 5)
                .AddIngredient(ItemID.SoulofLight, 5)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
