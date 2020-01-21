using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class Start : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Welcome To Terraria!");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Hi! Thanks for downloading the mod! " +
                "\nThis mod is for helping people who are new to the game go through the game... " +
                "\nWhat you need to do at the start is prepare for the first boss, the King Slime! " +
                $"\nThis boss can be summoned using the [item:560], made from 20 [item:23] and a [item:264] or [item:715](1 [item:178] + 5 [item:19] or [item:706] at an [item:35] or [item:716]) at a [i:{ModContent.ItemType<Items.DemonAltar>()}] or [i:{ModContent.ItemType<Items.CrimsonAltar>()}]. " +
                "\nOr you can get it summoned naturally rarely at the edges of the world, as well as at the end of the slime rain event. " +
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

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}