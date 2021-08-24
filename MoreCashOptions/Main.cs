using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using SimCasino.Modding;

namespace MoreCashOptions
{
    [HarmonyPatch(typeof(MainMenuProfile), "Awake")]
    public class MainMenuProfileAwakePatch
    {
        public static bool Prefix(ref List<int> ___CashAmounts)
        {
            ___CashAmounts = new List<int> {
                125_000,
                250_000,
                375_000,
                500_000,
                625_000,
                750_000,
                875_000,
                1_000_000,
                1_250_000,
                1_500_000,
                1_750_000,
                2_000_000,
                2_250_000,
                2_500_000,
                3_000_000,
                3_500_000,
                4_000_000,
                4_500_000,
                5_000_000,
                6_000_000,
                7_000_000,
                8_000_000,
                9_000_000,
                10_000_000
            };

            return true;
        }
    }

    public class Main : BaseMod
    {
        // Properties
        public override string InternalName => "root.MoreCashOptions";

        // Fields
        private Harmony _harmony;

        // Methods
        public override void OnLoad(GameEnvironment gameState)
        {
            _harmony = new Harmony(InternalName);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
