using Managers;
using UnityEngine;

public class GUITitle : MonoBehaviour
{
    [SerializeField] private GameObject inputFieldRoomCode;
    
    public void OnClickMakeRoom()
    {
        Debug.Log("OnClickMakeRoom");
        
        // TODO: 방 생성 로직 추가
        GUIManager.Instance.EnterWaitRoom();
    }
    
    public void OnClickJoinRoom()
    {
        Debug.Log("OnClickJoinRoom");
        Debug.Log($"{inputFieldRoomCode.GetComponent<TMPro.TextMeshProUGUI>().text}>()");
        
        // TODO: 룸 코드로 방 참가 로직 추가
        GUIManager.Instance.EnterWaitRoom();
    }
}
