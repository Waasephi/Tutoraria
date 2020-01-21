using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostCultist : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Lunatic Cultist");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating The Lunatic Cultist! " +
                "\nDepending on your preparation this could be a very tough boss." +
                "\nNext you need to fight the Moon Lord! " +
                "\nThis boss can be summoned by defeating all of the new celestial pillars that spawned into your world." +
                "\nIt can also be spawned by using a [i:3601], made with 20 [i:3458] + 20 [i:3456] + 20 [i:3457] + 20 [i:3459] at an [i:3549]" +
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