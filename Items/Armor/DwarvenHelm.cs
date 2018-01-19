using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DwarvenHelm : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dwarven Helm");
            Tooltip.SetDefault("Usually made by Dwarves.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "trollface.jpg";
			player.meleeDamage *= 0.8f;
			player.thrownDamage *= 0.8f;
			player.rangedDamage *= 0.8f;
			player.magicDamage *= 0.8f;
			player.minionDamage *= 0.8f;
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