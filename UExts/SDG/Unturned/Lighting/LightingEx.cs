using SDG.Unturned;
using System;
using UExts.Reflections;

namespace UExts.SDG.Unturned.Lighting
{
    public enum TimesOfDay
    {
        Night,
        FullMoon,
        Day,
    }

    public static class LightingEx
    {
        public static float LastWindTime()
        {
            return ReflectionFieldAccessor<LightingManager>.GetValue<float>("lastWind");
        }

        public static bool IsCycled()
        {
            return ReflectionFieldAccessor<LightingManager>.GetValue<bool>("isCycled");
        }

        public static float WindDelay()
        {
            return ReflectionFieldAccessor<LightingManager>.GetValue<float>("windDelay");
        }

        public static TimesOfDay GetTimeOfDay()
        {
            if (LightingManager.isDaytime)
            {
                return TimesOfDay.Day;
            }

            if (LightingManager.isNighttime)
            {
                return TimesOfDay.Night;
            }

            if (LightingManager.isFullMoon)
            {
                return TimesOfDay.FullMoon;
            }

            throw new IndexOutOfRangeException();
        }
    }
}
