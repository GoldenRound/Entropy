using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
    public class DuskClaymore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dusk Claymore");
            Tooltip.SetDefault("Smells like vile spit.");
        }
        public override void SetDefaults()
        {
            item.damage = 22;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 60;
            item.useAnimation = 55;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 8000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
