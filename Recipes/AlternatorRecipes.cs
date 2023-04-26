using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Recipes
{
    internal class AlternatorRecipes : ModSystem
    {
        //A bunch of utility functions to register all alternator recipes
        public static RecipeGroup BasicAlternatorGroup;
        public static RecipeGroup AdvancedAlternatorGroup;

        private void BasicAlternatorRecipe(int item1, int item2)
        {
            Recipe recipe1 = Recipe.Create(item1);
            recipe1.AddIngredient(item2);
            recipe1.AddTile(ModContent.TileType<Tiles.Furniture.BasicAlternator>());
            recipe1.Register();

            Recipe recipe2 = Recipe.Create(item2);
            recipe2.AddIngredient(item1);
            recipe2.AddTile(ModContent.TileType<Tiles.Furniture.BasicAlternator>());
            recipe2.Register();
        }

        private void AdvancedAlternatorRecipe(int item1, int item2)
        {
            Recipe recipe1 = Recipe.Create(item1);
            recipe1.AddIngredient(item2);
            recipe1.AddTile(ModContent.TileType<Tiles.Furniture.AdvancedAlternator>());
            recipe1.Register();

            Recipe recipe2 = Recipe.Create(item2);
            recipe2.AddIngredient(item1);
            recipe2.AddTile(ModContent.TileType<Tiles.Furniture.AdvancedAlternator>());
            recipe2.Register();
        }

        public override void AddRecipes()
        {
            //Basic Alternator Recipes
            BasicAlternatorRecipe(ItemID.CopperOre, ItemID.TinOre);
            BasicAlternatorRecipe(ItemID.IronOre, ItemID.LeadOre);
            BasicAlternatorRecipe(ItemID.SilverOre, ItemID.TungstenOre);
            BasicAlternatorRecipe(ItemID.GoldOre, ItemID.PlatinumOre);
            BasicAlternatorRecipe(ItemID.DemoniteOre, ItemID.CrimtaneOre);

            //Advanced Alternator Recipes
            AdvancedAlternatorRecipe(ItemID.CopperBar, ItemID.TinBar);
            AdvancedAlternatorRecipe(ItemID.IronBar, ItemID.LeadBar);
            AdvancedAlternatorRecipe(ItemID.SilverBar, ItemID.TungstenBar);
            AdvancedAlternatorRecipe(ItemID.GoldBar, ItemID.PlatinumBar);
            AdvancedAlternatorRecipe(ItemID.DemoniteBar, ItemID.CrimtaneBar);
            AdvancedAlternatorRecipe(ItemID.CobaltBar, ItemID.PalladiumBar);
            AdvancedAlternatorRecipe(ItemID.MythrilBar, ItemID.OrichalcumBar);
            AdvancedAlternatorRecipe(ItemID.AdamantiteBar, ItemID.TitaniumBar);
            AdvancedAlternatorRecipe(ItemID.CobaltOre, ItemID.PalladiumOre);
            AdvancedAlternatorRecipe(ItemID.MythrilOre, ItemID.OrichalcumOre);
            AdvancedAlternatorRecipe(ItemID.AdamantiteOre, ItemID.TitaniumOre);
            AdvancedAlternatorRecipe(ItemID.SoulofNight, ItemID.SoulofLight);
            AdvancedAlternatorRecipe(ModContent.ItemType<Items.OverclockFragment>(), ModContent.ItemType<Items.AsteriumFragment>());
            AdvancedAlternatorRecipe(ItemID.CobaltShield, ModContent.ItemType<Items.Accessories.PalladiumShield>());

            //Corruption - Crimson Items
            AdvancedAlternatorRecipe(ItemID.ShadowScale, ItemID.TissueSample);
            AdvancedAlternatorRecipe(ItemID.CursedFlame, ItemID.Ichor);
            AdvancedAlternatorRecipe(ItemID.EbonstoneBlock, ItemID.CrimstoneBlock);
            AdvancedAlternatorRecipe(ItemID.LesionBlock, ItemID.FleshBlock);
            AdvancedAlternatorRecipe(ItemID.EbonsandBlock, ItemID.CrimsandBlock);
            AdvancedAlternatorRecipe(ItemID.CorruptHardenedSand, ItemID.CrimsonHardenedSand);
            AdvancedAlternatorRecipe(ItemID.CorruptSandstone, ItemID.CrimsonSandstone);
            AdvancedAlternatorRecipe(ItemID.CorruptSeeds, ItemID.CrimsonSeeds);
            AdvancedAlternatorRecipe(ItemID.PurpleSolution, ItemID.RedSolution);
            AdvancedAlternatorRecipe(ItemID.Musket, ItemID.TheUndertaker);
            AdvancedAlternatorRecipe(ItemID.BallOHurt, ItemID.TheRottedFork);
            AdvancedAlternatorRecipe(ItemID.Vilethorn, ItemID.CrimsonRod);
            AdvancedAlternatorRecipe(ItemID.ShadowOrb, ItemID.CrimsonHeart);
            AdvancedAlternatorRecipe(ItemID.BandofStarpower, ItemID.PanicNecklace);
            AdvancedAlternatorRecipe(ItemID.RottenChunk, ItemID.Vertebrae);
            AdvancedAlternatorRecipe(ItemID.CorruptionKey, ItemID.CrimsonKey);
            AdvancedAlternatorRecipe(ItemID.PurpleIceBlock, ItemID.RedIceBlock);
        }
    }
}
