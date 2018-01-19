using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
    public class CystClaymore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyst Claymore");
            Tooltip.SetDefault("You literally just ripped this right from a Face Monster, didn't you?!");
        }
        public override void SetDefaults()
        {
            item.damage = 29;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 70;
            item.useAnimation = 65;
            item.useStyle = 1;
            item.knockBack = 13;
            item.value = 8000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
