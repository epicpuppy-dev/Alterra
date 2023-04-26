using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Alterra.Rarities
{
    public class AlternatingBlue : ModRarity
    {
        public override Color RarityColor => new Color((byte)(Main.DiscoR / 5.208f + 60), (byte)(Main.DiscoR / 6.711f + 120), (byte)(Main.DiscoR / 13.333f + 216));

        public override int GetPrefixedRarity(int offset, float valueMult)
        {
            return Type;
        }
    }
}