using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class RaiBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Rai Blade");
            Tooltip.SetDefault("The knife of a strong general.");
		}
		public override void SetDefaults()
		{
            item.damage = 22;
			item.melee = true;
			item.width = 40;
			item.height = 30;
            item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 3;
            item.knockBack = 7;
            item.value = 4000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
