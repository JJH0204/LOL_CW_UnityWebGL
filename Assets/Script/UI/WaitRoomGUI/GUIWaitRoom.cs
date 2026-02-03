using Managers;
using UnityEngine;

public class GUIWaitRoom : MonoBehaviour
{
    public void OnClickStartGame()
    {
        Debug.Log("OnClickStartGame");

        GUIManager.Instance.EnterBanPick();
    }
    
    public void OnClickSettingPopUp()
    {
        Debug.Log("OnClickSettingPopUp");
    }
}
