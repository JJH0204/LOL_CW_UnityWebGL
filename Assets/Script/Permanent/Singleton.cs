using System;
using UnityEngine;

namespace Managers
{
    public abstract class Singleton<T, TData> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        protected bool IsInitialized { get; set; }
        
        public static T Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = FindAnyObjectByType<T>();
                if (_instance != null) return _instance;
                var singletonObject = new GameObject(typeof(T).Name);
                _instance = singletonObject.AddComponent<T>();
                return _instance;
            }
        }

        public abstract void Initialize(TData data);
    }
}
