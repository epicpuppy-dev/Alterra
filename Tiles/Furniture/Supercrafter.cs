using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Alterra.Tiles.Furniture
{
    internal class Supercrafter : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileNoAttach[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 18 };
            TileObjectData.addTile(Type);

            AdjTiles = new int[] { TileID.WorkBenches, TileID.HeavyWorkBench, TileID.TinkerersWorkbench, TileID.MythrilAnvil, TileID.AdamantiteForge, TileID.LunarCraftingStation };

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Advanced Alternator");
            AddMapEntry(new Color(255, 200, 200), name);
        }
    }
}
