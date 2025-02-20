using Terraria;
using Terraria.ModLoader;

namespace HiveTumorFix
{
	public class HiveTumorFix : Mod {}

    public class GlobalNPCChanges : GlobalNPC
    {
        public override bool AppliesToEntity(NPC npc, bool lateInstantiation)
        {
            ModNPC hiveTumor;
            if (ModContent.TryFind("CalamityMod", "HiveTumor", out hiveTumor))
                return npc.type == hiveTumor.Type;
            return false;
        }

        public override void SetDefaults(NPC entity)
        {
            base.SetDefaults(entity);
            if (Main.zenithWorld)
                entity.lifeMax = 2000;
        }
    }
}