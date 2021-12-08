using UnityEngine;

[CreateAssetMenu(fileName = "NewMineData", menuName = "MineData", order = 54)]
public class MineData : ScriptableObject
{
    public int levelOfPrestige;
    public float cost;
    public bool isUnlocked;
    public bool isItOpenedNow;
}