using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewMineData", menuName = "MineData", order = 54)]
public class MineData : ScriptableObject
{
    public float stoneDropPrecentage;
    public float ironDropPrecentage;
    public float goldDropPrecentage;
    public float benitoiteDropPrecentage;
    public float rubyDropPrecentage;
    public float emeraldDropPrecentage;
    public float diamondDropPrecentage;
    public float onyxDropPrecentage;
    public float sapphireDropPrecentage;
    public float tinDropPrecentage;
    public float copperDropPrecentage;
    public float amethystDropPrecentage;

    public int levelOfPrestige;
    public float cost;
    public bool isOpened;
    public bool isItOpenedNow;
}