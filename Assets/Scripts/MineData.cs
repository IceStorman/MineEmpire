using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewMineData", menuName = "MineData", order = 54)]
public class MineData : ScriptableObject
{
    public float stoneDropPrecentage;
    public float ironDropPrecentage;
    public float goldDropPrecentage;
    public float benitoiteDropPrecentage;
    public float cost;
    public bool isOpened;
}