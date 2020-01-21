using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostPlantera : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Plantera");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating Plantera! " +
                "\nPlantera is probably the biggest difficulty spikes in the game!" +
                "\nNext you need to fight The Golem! " +
                "\nThis boss can be summoned in the underground jungle temple by using a [i:1293] at a [i:1292] " +
                "\nGood Luck!");
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