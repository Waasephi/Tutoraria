using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostEyeOfCthulhu : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Eye of Cthulhu");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating the Eye of Cthulhu! " +
                "\nThat can be a tough fight!" +
                "\nNext you need to fight the Eater of Worlds or Brain of Cthulhu! " +
                $"\nThe Eater of Worlds can be summoned in the corruption using the [item:70], made from 15 [item:68] + 30 [item:67] at a [i:{ModContent.ItemType<Items.DemonAltar>()}]. " +
                $"\nIt can also be summoned by breaking 3 [i:{ModContent.ItemType<Items.ShadowOrb>()}]." +
                "\nThis is a corruption only boss, so if you don't have the corruption you cannot fight them" +
                $"\nThe Brain of Cthulhu can be summoned in the crimson using the [item:1331], made from 15 [item:1330] + 30 [item:2886] at a [i:{ModContent.ItemType<Items.CrimsonAltar>()}]." +
                $"\nIt can also be summoned by breaking 3 [i:{ ModContent.ItemType<Items.CrimsonHeart>()}]." +
                "\nThis is a crimson only boss, so if you don't have the crimson you cannot fight them" +
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