using UnityEngine;

[CreateAssetMenu(fileName = "NewPrestigeData", menuName = "PrestigeData", order = 55)]
public class PrestigeData : ScriptableObject
{
    public string thingText;
    public Sprite lockThingSprite;
    public Sprite unlockThingSprite;
    //public Image thingImage;
    public bool canUnlock;
    public int thingCost;

    public void DoSomeThingOnStart()
    {

    }
}
