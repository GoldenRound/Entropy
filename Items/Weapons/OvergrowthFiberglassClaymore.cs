using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class OvergrowthFiberglassClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Fiberglass Claymore");
            Tooltip.SetDefault("Stronger then most forms of steel.");
		}
		public override void SetDefaults()
		{
            item.damage = 30;
			item.melee = true;
			item.width = 80;
			item.height = 60;
            item.useTime = 55;
			item.useAnimation = 45;
			item.useStyle = 1;
            item.knockBack = 8;
            item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FiberglassFishingPole, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
