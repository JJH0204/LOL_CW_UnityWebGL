using Managers;
using UnityEngine;

public class InitGUI : MonoBehaviour
{
    [SerializeField] private GUIManagerData guiManagerData;
    [SerializeField] private ChampionListManagerData championListManagerData;
    
    public ChampionListManagerData ChampionListManagerData => championListManagerData;
    
    private void Start()
    {
        GUIManager.Instance.Initialize(guiManagerData);
        ChampionListManager.Instance.Initialize(championListManagerData);
    }
}
