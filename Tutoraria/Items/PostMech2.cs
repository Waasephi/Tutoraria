using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostMech2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Mech 2");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Just a part of a whole.");
		}

        public override void SetDefaults()
        {
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 30;
            item.height = 12;
            item.value = 0;
            item.rare = 4;
            item.expert = false;
            item.autoReuse = true;
        }
	}
}