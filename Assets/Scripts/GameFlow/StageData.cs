using System;
using UnityEngine;

namespace GameFlow
{
    [Serializable]
    public struct StageData
    {
        public string name;
        public float minY;

        public GameObject basePlatformPrefab;
        public PlatformData[] platforms;
        public PickupData[] pickups;
    }
}