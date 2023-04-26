
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Alterra.Recipes
{
    internal class VanillaPlusRecipes : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.CobaltShield)
                .AddIngredient(ItemID.CobaltBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
