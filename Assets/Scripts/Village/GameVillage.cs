using UnityEngine;

public class GameVillage : BaseVillage
{

    [SerializeField]
    private int VillageLevel;

    private void Start()
    {
        Level += 1;        
    }

    public void OnLevelUp()
    {
        LevelUp();
        VillageLevel = Level;
    }

    public void OnLevelDown()
    {
        LevelDown();
        VillageLevel = Level;
    }

}
