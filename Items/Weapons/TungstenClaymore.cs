using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
	public class TungstenClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Tungsten Claymore");
            Tooltip.SetDefault("Still smells like souring bat corpses.");
		}
		public override void SetDefaults()
		{
            item.damage = 16;
			item.melee = true;
			item.width = 80;
			item.height = 80;
            item.useTime = 60;
			item.useAnimation = 55;
			item.useStyle = 1;
            item.knockBack = 10;
            item.value = 1500;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
