using SDG.Unturned;

namespace UExts.SDG.Unturned.Players
{
    public enum Skills
    {
        Overkill,
        Sharpshooter,
        Dexterity,
        Cardio,
        Exercise,
        Diving,
        Parkour,
        Sneakybeaky,
        Vitality,
        Immunity,
        Toughness,
        Strength,
        Warmblooded,
        Survival,
        Healing,
        Crafting,
        Outdoors,
        Cooking,
        Fishing,
        Agriculture,
        Mechanic,
        Engineer,
        Hardened,
        Olympic,
        Flight,
        Splatterific
    }

    public interface ISkillable
    {
        Skills Name { get; }
    }

    public interface IRandomSkill : ISkillable
    {
    }

    public interface ISkill : ISkillable
    {
        byte SpecialityIndex { get; }

        byte Index { get; }
    }

    public class RandomSkill : IRandomSkill
    {
        public Skills Name { get; }



        public RandomSkill(Skills name)
        {
            Name = name;
        }
    }

    public static class AllSkills
    {
        public static class Offense
        {
            public static readonly Overkill OverkillSkill = new();
            public static readonly Sharpshooter SharpshooterSkill = new();
            public static readonly Dexterity DexteritySkill = new();
            public static readonly Cardio CardioSkill = new();
            public static readonly Exercise ExerciseSkill = new();
            public static readonly Diving DivingSkill = new();
            public static readonly Parkour ParkourSkill = new();



            public class Overkill : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;
                public const uint Level6ExperienceRequired = 60;
                public const uint Level7ExperienceRequired = 70;



                public byte SpecialityIndex => 0;

                public byte Index => 0;

                public Skills Name => Skills.Overkill;
            }

            public class Sharpshooter : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;
                public const uint Level6ExperienceRequired = 60;
                public const uint Level7ExperienceRequired = 70;



                public byte SpecialityIndex => 0;

                public byte Index => 1;

                public Skills Name => Skills.Sharpshooter;
            }

            public class Dexterity : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 0;

                public byte Index => 2;

                public Skills Name => Skills.Dexterity;
            }

            public class Cardio : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 0;

                public byte Index => 3;

                public Skills Name => Skills.Cardio;
            }

            public class Exercise : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;


                public byte SpecialityIndex => 0;

                public byte Index => 4;

                public Skills Name => Skills.Exercise;
            }

            public class Diving : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 0;

                public byte Index => 5;

                public Skills Name => Skills.Diving;
            }

            public class Parkour : ISkill
            {
                public const uint Level1ExperienceRequired = 20;
                public const uint Level2ExperienceRequired = 30;
                public const uint Level3ExperienceRequired = 40;
                public const uint Level4ExperienceRequired = 50;
                public const uint Level5ExperienceRequired = 60;



                public byte SpecialityIndex => 0;

                public byte Index => 6;

                public Skills Name => Skills.Parkour;
            }
        }

        public static class Defense
        {
            public static readonly Sneakybeaky SneakybeakySkill = new();
            public static readonly Vitality VitalitySkill = new();
            public static readonly Immunity ImmunitySkill = new();
            public static readonly Toughness ToughnessSkill = new();
            public static readonly Strength StrengthSkill = new();
            public static readonly Warmblooded WarmbloodedSkill = new();
            public static readonly Survival SurvivalSkill = new();



            public class Sneakybeaky : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;
                public const uint Level6ExperienceRequired = 60;
                public const uint Level7ExperienceRequired = 70;



                public byte SpecialityIndex => 1;

                public byte Index => 0;

                public Skills Name => Skills.Sneakybeaky;
            }

            public class Vitality : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 1;

                public Skills Name => Skills.Sneakybeaky;
            }

            public class Immunity : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 2;

                public Skills Name => Skills.Immunity;
            }

            public class Toughness : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 3;

                public Skills Name => Skills.Toughness;
            }

            public class Strength : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 4;

                public Skills Name => Skills.Strength;
            }

            public class Warmblooded : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 5;

                public Skills Name => Skills.Warmblooded;
            }

            public class Survival : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 1;

                public byte Index => 6;

                public Skills Name => Skills.Survival;
            }
        }

        public static class Support
        {
            public static readonly Healing HealingSkill = new();
            public static readonly Crafting CraftingSkill = new();
            public static readonly Outdoors OutdoorsSkill = new();
            public static readonly Cooking CookingSkill = new();
            public static readonly Fishing FishingSkill = new();
            public static readonly Agriculture AgricultureSkill = new();
            public static readonly Mechanic MechanicSkill = new();
            public static readonly Engineer EngineerSkill = new();



            public class Healing : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;
                public const uint Level6ExperienceRequired = 60;
                public const uint Level7ExperienceRequired = 70;



                public byte SpecialityIndex => 2;

                public byte Index => 0;

                public Skills Name => Skills.Healing;
            }

            public class Crafting : ISkill
            {
                public const uint Level1ExperienceRequired = 20;
                public const uint Level2ExperienceRequired = 50;
                public const uint Level3ExperienceRequired = 80;



                public byte SpecialityIndex => 2;

                public byte Index => 1;

                public Skills Name => Skills.Healing;
            }

            public class Outdoors : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 2;

                public byte Index => 2;

                public Skills Name => Skills.Outdoors;
            }

            public class Cooking : ISkill
            {
                public const uint Level1ExperienceRequired = 20;
                public const uint Level2ExperienceRequired = 50;
                public const uint Level3ExperienceRequired = 80;



                public byte SpecialityIndex => 2;

                public byte Index => 3;

                public Skills Name => Skills.Cooking;
            }

            public class Fishing : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 2;

                public byte Index => 4;

                public Skills Name => Skills.Fishing;
            }

            public class Agriculture : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;
                public const uint Level6ExperienceRequired = 60;
                public const uint Level7ExperienceRequired = 70;



                public byte SpecialityIndex => 2;

                public byte Index => 5;

                public Skills Name => Skills.Agriculture;
            }

            public class Mechanic : ISkill
            {
                public const uint Level1ExperienceRequired = 10;
                public const uint Level2ExperienceRequired = 20;
                public const uint Level3ExperienceRequired = 30;
                public const uint Level4ExperienceRequired = 40;
                public const uint Level5ExperienceRequired = 50;



                public byte SpecialityIndex => 2;

                public byte Index => 6;

                public Skills Name => Skills.Mechanic;
            }

            public class Engineer : ISkill
            {
                public const uint Level1ExperienceRequired = 20;
                public const uint Level2ExperienceRequired = 50;
                public const uint Level3ExperienceRequired = 80;



                public byte SpecialityIndex => 2;

                public byte Index => 7;

                public Skills Name => Skills.Engineer;
            }
        }

        public static class RandomBoost
        {
            public static readonly Hardened HardenedSkill = new();
            public static readonly Olympic OlympicSkill = new();
            public static readonly Flight FlightSkill = new();
            public static readonly Splatterific SplatterificSkill = new();

            public const uint ExperienceRequired = 25;



            public class Hardened : IRandomSkill
            {
                public Skills Name => Skills.Hardened;
            }

            public class Olympic : IRandomSkill
            {
                public Skills Name => Skills.Olympic;
            }

            public class Flight : IRandomSkill
            {
                public Skills Name => Skills.Flight;
            }

            public class Splatterific : IRandomSkill
            {
                public Skills Name => Skills.Splatterific;
            }
        }
    }

    public static class PlayerSkillsEx
    {
        public static PlayerSkills Set(this PlayerSkills source, ISkill skill, int level)
        {
            source.ServerSetSkillLevel(skill.SpecialityIndex, skill.Index, level);
            return source;
        }
    }
}
