using UnityEngine;

public interface IVillage 
{
    //Property
    int Level { get; set; }
    Vector2Int GridSize { get; set; }
    DayNightCycle CurrentCycles { get; set; }


    //Methods

    //Village Manage
    void LevelUp();
    void LevelDown();
    void DayNightChange();
    void LevelChanged();
}
