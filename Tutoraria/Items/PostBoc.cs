using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostBoc : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Brain of Cthulhu");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating the Brain of Cthulhu! " +
                "\nThat fight is as tough as you make it through preparation!" +
                "\nNext you need to fight the Queen Bee! " +
                "\nThis boss can be summoned in the jungle using the [item:1133], made from 5 [item:1125] + 1 [item:209] + 5 [item:1124] + 1 [item:1134] anywhere. " +
                $"\nYou can also summon them using a [i:{ModContent.ItemType<Items.QueenBeeLarva>()}] in a hive in the underground jungle" +
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