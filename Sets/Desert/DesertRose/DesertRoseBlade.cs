using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ProjectAlpha.Sets.Desert.DesertRose
{
    public class DesertRoseBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Rose Sword");
        }
        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 23;
            item.height = 25;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 7000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DesertRose"), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
