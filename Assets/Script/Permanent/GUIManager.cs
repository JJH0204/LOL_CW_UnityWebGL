using System;
using UnityEngine;

namespace Managers
{
    [Serializable]
    public class GUIManagerData
    {
        [SerializeField] private GameObject titleUI;
        [SerializeField] private GameObject waitRoomUI;
        [SerializeField] private GameObject banPickUI;
        [SerializeField] private GameObject playWaitGUI;
        
        public GameObject TitleUI { get => titleUI; private set => titleUI = value; }
        public GameObject WaitRoomUI { get => waitRoomUI; private set => waitRoomUI = value; }
        public GameObject BanPickUI { get => banPickUI; private set => banPickUI = value; }
        public GameObject PlayWaitGUI { get => playWaitGUI; private set => playWaitGUI = value; }
        
        public GUIManagerData(GameObject titleUI, GameObject waitRoomUI, GameObject banPickUI, GameObject playWaitGUI)
        {
            TitleUI = titleUI;
            WaitRoomUI = waitRoomUI;
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

        public void EnterWaitRoom()
        {
            data.WaitRoomUI.SetActive(true);
            data.TitleUI.SetActive(false);
        }

        public void EnterBanPick()
        {
            data.BanPickUI.SetActive(true);
            data.WaitRoomUI.SetActive(false);
        }
    }
}