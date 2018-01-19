using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class CopperClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Claymore");
			Tooltip.SetDefault("No one uses copper.");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 60;
			item.useAnimation = 55;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 1000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
