using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class TinClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tin Claymore");
			Tooltip.SetDefault("Still worthless.");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 60;
			item.useAnimation = 55;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 900;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
