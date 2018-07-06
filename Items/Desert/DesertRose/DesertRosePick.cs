﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ProjectAlpha.Items.Desert.DesertRose
{
    public class DesertRosePick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Rose Pick");
        }
        public override void SetDefaults()
        {
            item.damage = 8;
            item.melee = true;
            item.width = 23;
            item.height = 25;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 2;
            item.pick = 45;
            item.value = 7000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
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
