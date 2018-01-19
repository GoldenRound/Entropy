using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items.Weapons
{
    public class HellstoneClaymore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellstone Claymore");
            Tooltip.SetDefault("Burns with the fury of hell - Right Click fires balls of fire.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 60;
            item.useAnimation = 55;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.ApprenticeStaffT3Shot;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 18);
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
                item.useTime = 14;
                item.useAnimation = 14;
                item.damage = 15;
                item.shoot = ProjectileID.ApprenticeStaffT3Shot;
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 60;
                item.useAnimation = 55;
                item.damage = 40;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (player.altFunctionUse == 2)
            {
                target.AddBuff(BuffID.OnFire, 7);
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
            damage = (int)(damage * 1f);
            speedX = speed.X;
            speedY = speed.Y;
            return true;
        }
    }
}