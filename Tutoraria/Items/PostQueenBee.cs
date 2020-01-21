using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostQueenBee : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Queen Bee");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating the Queen Bee! " +
                "\nThat fight is pretty difficult regardless of skill!" +
                "\nNext you need to fight Skeletron! " +
                "\nThis boss can be summoned at night by talking to the old man at the dungeon. " +
                "\nYou can also summon them by killing a clothier while having a [i:1307] equipped" +
                "\nAs a little tip, the dungeon is always on the same side as the ice biome, and the opposite side of the jungle." +
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