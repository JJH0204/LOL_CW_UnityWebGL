using System;
using UnityEngine;

namespace Managers
{
    [Serializable]
    public class GameManagerData
    {
        
    }

    public class GameManager : Singleton<GameManager, GameManagerData>
    {
        [SerializeField] private GameManagerData data;
        
        public override void Initialize(GameManagerData gameData)
        {
            data = gameData;
            IsInitialized = true;
        }
    }
}