using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ExampleLeggings : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Example Leggings");
            Tooltip.SetDefault("Random Leg Armor."
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}