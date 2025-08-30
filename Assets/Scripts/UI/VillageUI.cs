using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VillageUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI VillageInfo;       //Village Info

    [SerializeField]
    GameVillage TargetVillage;

    private void Awake()
    {
        TargetVillage = GameObject.Find("TestObject").GetComponent<GameVillage>();
        VillageInfo = GameObject.Find("LevelUI").GetComponent<TextMeshProUGUI>();
        VillageInfo.text = "Village Level : " + TargetVillage.Level;
        OnVillageUpdate();
    }

    public void OnVillageUpdate()
    {
        VillageInfo.text = "Village Level : " + TargetVillage.Level;
    }
}
