using UnityEngine;

[CreateAssetMenu(fileName = "NewOreData", menuName = "OreData", order = 51)]
public class OreData : ScriptableObject
{
    public int ore;
    public float recycleOre;
    public float recycleCount;
    public int recycleOreGive;
    public float recycleOreCost;
    public int amountOfRecycle;
}
