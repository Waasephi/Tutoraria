using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria.Items
{
	public class PostMech : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Post Mechanical Bosses");
            // DisplayName.SetDefault("Start"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Great job beating the Mechanical Bosses! " +
                "\nThose fights are just refights but they are still way different!" +
                "\nNext you need to fight Plantera! " +
                $"\nThis boss can be summoned in the underground jungle by breaking a [i:{ModContent.ItemType<Items.PlanteraBulb>()}]. " +
                "\nAs a little tip, if you go outside of the underground jungle, this boss enrages making it much harder." +
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
            recipe.AddIngredient(mod, "PostMech1");
            recipe.AddIngredient(mod, "PostMech2");
            recipe.AddIngredient(mod, "PostMech3");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}