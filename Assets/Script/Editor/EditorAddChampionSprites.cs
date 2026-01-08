using UnityEngine;
using UnityEditor;

namespace Script.Editor
{
    public static class EditorAddChampionSprites
    {
        [MenuItem("Tools/Add Champion Sprites")]
        public static void AddSpritesToChampionListManager()
        {
            var mgr = Object.FindAnyObjectByType<InitGUI>();
            if (mgr == null)
            {
                Debug.LogError("하이라키에서 ChampionListManager 오브젝트를 찾을 수 없습니다.");
                return;
            }

            var sprites = Resources.LoadAll<Sprite>("ChampionImages");
            if (sprites == null || sprites.Length == 0)
            {
                Debug.LogWarning("`Assets/Resources/ChampionImages` 폴더에서 스프라이트를 찾지 못했습니다.");
                return;
            }

            Undo.RecordObject(mgr, "Assign Champion Sprites");
            mgr.ChampionListManagerData.SetChampionSprites(sprites);
            EditorUtility.SetDirty(mgr);

            Debug.Log($"ChampionListManager의 championSprites 배열에 {sprites.Length}개의 스프라이트를 추가했습니다.");
        }
    }
}
