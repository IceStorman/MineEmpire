using UnityEngine;

[CreateAssetMenu(fileName = "NewPrestigeData", menuName = "PrestigeData", order = 55)]
public class PrestigeData : ScriptableObject
{
    public string thingText;
    public string lockPrizeThingText;
    public Sprite lockThingSprite;
    public Sprite unlockThingSprite;
    public Sprite lockButtonSprite;
    public Sprite unlockButtonSprite;
    public bool canUpgrade;
    public bool wasBought;
    public float thingCost;
    public int giveExp;
    public int thingID;
}
