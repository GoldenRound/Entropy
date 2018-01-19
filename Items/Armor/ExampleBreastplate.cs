using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ExampleBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Example Breastplate");
			Tooltip.SetDefault("Some Random Body Armor."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
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