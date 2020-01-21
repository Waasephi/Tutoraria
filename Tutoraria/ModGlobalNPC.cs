using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tutoraria
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == 50)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostKingSlime"));
                }
            }
            if (npc.type == 4)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostEyeOfCthulhu"));
                }
            }
            if (npc.type == 13)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostEow"));
                }
            }
            if (npc.type == 266)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostBoc"));
                }
            }
            if (npc.type == 222)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostQueenBee"));
                }
            }
            if (npc.type == 35)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostSkeletron"));
                }
            }
            if (npc.type == 113)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostWof"));
                }
            }
            if (npc.type == 134)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostMech3"));
                }
            }
            if (npc.type == 127)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostMech2"));
                }
            }
            if (npc.type == 126)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostMech1"));
                }
            }
            if (npc.type == 262)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostPlantera"));
                }
            }
            if (npc.type == 370)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostDuke"));
                }
            }
            if (npc.type == 245)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostGolem"));
                }
            }
            if (npc.type == 439)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostCultist"));
                }
            }
            if (npc.type == 398)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PostMoonLord"));
                }
            }
        }
    }
}