using UnityEngine;

[CreateAssetMenu(fileName = "NewPrestigeData", menuName = "PrestigeData", order = 55)]
public class PrestigeData : ScriptableObject
{
    public string unlockThingText;
    public string lockThingText;

    public bool canUpgrade;
    public bool wasBought;
    public float thingCost;
    public int giveExp;
    public int thingID;
}
