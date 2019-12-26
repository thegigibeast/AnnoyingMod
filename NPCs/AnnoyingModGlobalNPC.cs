using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnnoyingMod.NPCs
{
    public class AnnoyingModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.BigCrimslime:
                case NPCID.Crimslime:
                case NPCID.LittleCrimslime:
                    if (ModContent.GetInstance<AnnoyingModConfig>().CrimslimeFix && Main.rand.Next(Main.expertMode ? 50 : 100) == 0)
                    {
                        Item.NewItem(npc.getRect(), ItemID.Blindfold);
                    }
                    break;
            }

        }

        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            switch (npc.type)
            {
                case NPCID.BigCrimslime:
                case NPCID.Crimslime:
                case NPCID.LittleCrimslime:
                    if (ModContent.GetInstance<AnnoyingModConfig>().CrimslimeFix && Main.rand.Next(4) == 0)
                    {
                        target.AddBuff(BuffID.Darkness, Main.expertMode ? 1800 : 900);
                    }
                    break;
            }
        }
    }
}
