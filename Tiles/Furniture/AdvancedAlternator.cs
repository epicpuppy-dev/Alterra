using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Alterra.Tiles.Furniture
{
    internal class AdvancedAlternator : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };;
            TileObjectData.addTile(Type);

            AdjTiles = new int[] { ModContent.TileType<BasicAlternator>() };

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Advanced Alternator");
            AddMapEntry(new Color(200, 200, 255), name);

            AnimationFrameHeight = 38;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            if (++frameCounter >= 6)
            {
                frameCounter = 0;
                frame = ++frame % 28;
            }
        }
    }
}
