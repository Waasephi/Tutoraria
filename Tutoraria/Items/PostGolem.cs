using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostGolem : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Golem");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating Golem! " +
                "\nGolem suprisingly the most underwhelming boss in the game..." +
                "\nNext you need to fight Duke Fishron! " +
                "\nThis boss can be summoned in the ocean by fishing using a [i:2673], which can be found in the underground glowing mushroom biome and is caught with a [i:1991]. " +
                "\nAs a little tip, if you go outside of the ocean, this boss enrages making it much harder." +
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