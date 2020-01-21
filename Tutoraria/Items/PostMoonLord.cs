using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostMoonLord : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Moon Lord");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating The Moon Lord! " +
                "\nYou did it! You have beaten all of Terraria's vanilla bosses!" +
                "\nThere is nothing left from the vanilla game left to fight!" +
                "\nNow you just need to download some more mods and explore those!" +
                "\nCongratulations, you are even closer to be a Terraria master!");
		}

        public override void SetDefaults()
        {
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 40;
            item.height = 40;
            item.value = 0;
            item.rare = 4;
            item.expert = true;
            item.autoReuse = true;
        }
    }
}