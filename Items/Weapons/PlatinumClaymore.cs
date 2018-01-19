using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class PlatinumClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Platinum Claymore");
            Tooltip.SetDefault("Ooh, shiny!");
		}
		public override void SetDefaults()
		{
            item.damage = 20;
			item.melee = true;
			item.width = 80;
			item.height = 80;
            item.useTime = 60;
			item.useAnimation = 65;
			item.useStyle = 1;
            item.knockBack = 10;
            item.value = 7000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
