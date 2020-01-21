using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class CrimsonHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Crimson Heart");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is just a place holder item since this item doesnt have an actual item. It can be found in the crimson.");
		}

        public override void SetDefaults()
        {
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 40;
            item.height = 40;
            item.value = 0;
            item.rare = 4;
            item.expert = false;
            item.autoReuse = true;
        }
	}
}