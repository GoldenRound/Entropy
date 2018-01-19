using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
    public class Bloodmorne : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloodmorne");
            Tooltip.SetDefault("Tainted with blood - Right Click fires ichor shots.");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 60;
            item.useAnimation = 55;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = ProjectileID.IchorSplash;
            item.shootSpeed = 2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CystClaymore");
            recipe.AddIngredient(null, "HellstoneClaymore");
            recipe.AddIngredient(null, "BoneClaymore");
            recipe.AddIngredient(null, "OvergrowthFiberglassClaymore");
            recipe.AddIngredient(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CystClaymore");
            recipe.AddIngredient(null, "HellstoneClaymore");
            recipe.AddIngredient(null, "BoneClaymore");
            recipe.AddIngredient(null, "FiberglassClaymore");
            recipe.AddIngredient(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 3;
                item.useTime = 75;
                item.useAnimation = 38;
                item.damage = 45;
                item.shoot = ProjectileID.IchorSplash;
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 60;
                item.useAnimation = 55;
                item.damage = 45;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (player.altFunctionUse == 2)
            {
                target.AddBuff(BuffID.Ichor, 5);
            }
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                if (player.altFunctionUse == 2)
                {
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169, 0f, 0f, 100, default(Color), 2f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity.X += player.direction * 2f;
                    Main.dust[dust].velocity.Y += 0.2f;
                }
                else
                {
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
                    Main.dust[dust].noGravity = true;
                }
            }
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Fix the speedX and Y to point them horizontally.
            speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
            speedY = 0;
            // Add random Rotation
            Vector2 speed = new Vector2(speedX, speedY);
            speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
            // Change the damage since it is based off the weapons damage and is too high
            damage = (int)(damage * .7f);
            speedX = speed.X;
            speedY = speed.Y;
            return true;
        }
    }
}