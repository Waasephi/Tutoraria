using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostWof : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Welcome To Hardmode");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating The Wall of Flesh! " +
                "\nThat fight is another one of the hardest in the game!" +
                "\nNext you need to fight The Mechanical Bosses! " +
                "\nThese bosses can be summoned at night by using a [i:544], [i:557], and [i:556]. " +
                "\n[i:544] is made with 3 [i:38] + 5 [i:22] or [i:704] + 6 [i:520] at a [i:525] or [i:1220]" +
                "\n[i:557] is made with 30 [i:154] + 5 [i:22] or [i:704] + 3 [i:520] + 3 [i:521] at a [i:525] or [i:1220]" +
                "\n[i:556] is made with 6 [i:68] or [i:1330] + 5 [i:22] or [i:704] + 6 [i:521] at a [i:525] or [i:1220]" +
                $"\nThese can also spawn naturally after you have broken a [i:{ModContent.ItemType<Items.DemonAltar>()}] or [i:{ModContent.ItemType<Items.CrimsonAltar>()}]." +
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