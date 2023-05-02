using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterra.Items.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
    internal class PalladiumShield : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 28;
            Item.value = Item.sellPrice(gold: 1, silver: 75);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;

            Item.defense = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.PalladiumBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
