using System;
using UnityEngine;

namespace Managers
{
    [Serializable]
    public class GUIManagerData
    {
        [SerializeField] private GameObject titleUI;
        [SerializeField] private GameObject banPickUI;
        [SerializeField] private GameObject playWaitGUI;
        
        public GameObject TitleUI { get => titleUI; private set => titleUI = value; }
        public GameObject BanPickUI { get => banPickUI; private set => banPickUI = value; }
        public GameObject PlayWaitGUI { get => playWaitGUI; private set => playWaitGUI = value; }
        
        public GUIManagerData(GameObject titleUI, GameObject banPickUI, GameObject playWaitGUI)
        {
            TitleUI = titleUI;
            BanPickUI = banPickUI;
            PlayWaitGUI = playWaitGUI;
        }
    }
    
    public class GUIManager: Singleton<GUIManager, GUIManagerData>
    { 
        // public GameObject TitleUI { get; private set; }
        // public GameObject BanPickUI { get; private set; }
        // public GameObject PlayWaitGUI { get; private set; }
        [SerializeField] private GUIManagerData data;

        public override void Initialize(GUIManagerData guiData)
        {
            // TitleUI = data.TitleUI;
            // BanPickUI = data.BanPickUI;
            // PlayWaitGUI = data.PlayWaitGUI;
            data = guiData;
            
            data.TitleUI.SetActive(true);
            data.BanPickUI.SetActive(false);
            data.PlayWaitGUI.SetActive(false);
            
            IsInitialized = true;
        }
    }
}