using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostDuke : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Duke Fishron");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating Duke Fishron! " +
                "\nDuke Fishron might just be the hardest boss in the game!" +
                "\nNext you need to fight the lunatic cultist! " +
                "\nThis boss can be summoned by killing the cultists at the entrance to the dungeon" +
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