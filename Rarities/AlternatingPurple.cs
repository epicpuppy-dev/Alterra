using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Alterra.Rarities
{
    public class AlternatingPurple : ModRarity
    {
        public override Color RarityColor => new Color((byte)(Main.DiscoR / 6.711f + 142), (byte)(Main.DiscoR / 5.917f + 124), (byte)(Main.DiscoR / 13.333f + 195));

        public override int GetPrefixedRarity(int offset, float valueMult)
        {
            return Type;
        }
    }
}