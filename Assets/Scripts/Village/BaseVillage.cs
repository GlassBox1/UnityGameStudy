using UnityEngine;


public abstract class BaseVillage : MonoBehaviour ,IVillage
{

    //Values

    protected int village_level;
    protected Vector2Int map_size;
    protected DayNightCycle current_day_night;
    protected VillageType village_type;


    //Property
    public int Level { get { return village_level; } set { village_level = value; } }
    public Vector2Int GridSize { get { return map_size; } set { map_size = value; } }
    public DayNightCycle CurrentCycles { get { return current_day_night; } set { current_day_night = value; } }
    public VillageType VillageType { get { return village_type; } set { village_type = value; } }


    //Methods
    public void OnVillageTypeChange(VillageType changeType)
    {
        return;
    }

    public void LevelUp()
    {
        village_level += 1;
    }
    public void LevelDown()
    {
        if(village_level!=0)
            village_level -= 1;
    }
    public void OnDayNightChange()
    {
       
    }

    public void OnLevelChanged()
    {
        return;
    }

}
