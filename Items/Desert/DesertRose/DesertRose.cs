using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAlpha.Items.Desert.DesertRose
{
	public class DesertRose : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Rose");
		}
		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 8;
			item.value = 1400;
			item.rare = 2;
            item.UseSound = SoundID.Item1;
		}

	}
}
