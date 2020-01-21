using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostSkeletron : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Skeletron");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating Skeletron! " +
                "\nThat fight is one of the hardest in the game!" +
                "\nNext you need to fight The Wall of Flesh! " +
                "\nThis boss can be summoned in the underworld by throwing a [i:267] (obtained by killing voodoo demons in the underworld) into lava. " +
                "\nYou must have a guide currently alive in your world to fight this boss." +
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