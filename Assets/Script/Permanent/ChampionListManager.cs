using System;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    [Serializable]
    public class ChampionListManagerData
    {
        public GameObject championPrefab;
        public Transform championParent;
        public Sprite[] championSprites;
        
        public void SetChampionSprites(Sprite[] sprites)
        {
            championSprites = sprites;
        }
    }
    
    public class ChampionListManager : Singleton<ChampionListManager, ChampionListManagerData>
    {
        [SerializeField] private bool isRunOnce;
        [SerializeField] private ChampionListManagerData data;
        
        private void Update()
        {
            if (!IsInitialized || isRunOnce) return;
            foreach (var root in data.championSprites)
            {
                var championObj = Instantiate(data.championPrefab, data.championParent);
                championObj.GetComponent<Image>().sprite = root;
                
                championObj.GetComponent<Button>().onClick.AddListener(() => OnChampionClick(root.name));
            }
                
            isRunOnce = true;
        }
        
        private static void OnChampionClick(string championName)
        {
            Debug.Log("Champion Clicked: " + championName);
            // Implement further logic for when a champion is clicked
        }

        public override void Initialize(ChampionListManagerData championData)
        {
            data = championData;
            IsInitialized = true;
        }
    }
}
