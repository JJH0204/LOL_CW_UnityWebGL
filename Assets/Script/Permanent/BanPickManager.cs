using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace Managers
{
    [Serializable]
    public class BanPickManagerData
    {
        public List<int> blueBans = new();
        public List<int> redBans = new();
        public List<int> bluePicks = new();
        public List<int> redPicks = new();
        public bool isBlueTurn = true;
        public int currentPhase = 0;
    }
    
    public class BanPickManager : Singleton<BanPickManager, BanPickManagerData>
    {
        public BanPickManagerData data;
        
        public void ResetState()
        {
            data = new BanPickManagerData();
        }

        public override void Initialize(BanPickManagerData banPickData)
        {
            data = banPickData;
            IsInitialized = true;
        }
    }
}