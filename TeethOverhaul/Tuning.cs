using Sims3.SimIFace;

namespace Sims3.Gameplay.SimsVerse
{
    public class TeethOverhaul
    {
        [Tunable, TunableComment("The delay (in minutes) before a Sim's teeth is randomized automatically")]
        public static float kAutoRandomizeTeethDelay = 5;

        [Tunable, TunableComment("Whether to randomize a Sim's teeth upon aging them up between baby and toddler, toddler and child, and child and teen")]
        public static bool kAutoRandomizeTeethOnSimAgeTransition = true;

        [Tunable, TunableComment("Whether to randomize a newly generated Sim's teeth")]
        public static bool kAutoRandomizeTeethOnSimInstantiated = true;

        [Tunable, TunableComment("Whether to put the interactions for applying, resetting, and randomizing teeth in the testing cheats pie menu (only if NRaas Selector is installed; otherwise, they'll just show up in the normal pie menu if testing cheats are enabled)")]
        public static bool kInteractionsAreCheats;

        [Tunable, TunableComment("Whether the interactions for applying, resetting, and randomizing teeth are enabled")]
        public static bool kShowInteractions = true;
    }
}
