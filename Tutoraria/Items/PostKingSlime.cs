using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostKingSlime : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post King Slime");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating the King Slime! " +
                "\nYou are well on your way to becoming a terraria master!" +
                "\nNext you need to fight the Eye of Cthulhu! " +
                $"\nThis boss can be summoned at night using the [item:43], made from 6 [item:38] at a [i:{ModContent.ItemType<Items.DemonAltar>()}] or [i:{ModContent.ItemType<Items.CrimsonAltar>()}]. " +
                "\nOr you can get it summoned naturally after having at least 200 max life, this can be done using [item:29] atleast 5 times. " +
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