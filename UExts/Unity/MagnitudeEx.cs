using UnityEngine;

namespace UExts.Unity
{
    public static class MagnitudeEx
    {
        public static bool IsInRange(this Vector3 source, Vector3 target, float sqrValue)
        {
            return (source - target).sqrMagnitude <= sqrValue;
        }
    }
}
