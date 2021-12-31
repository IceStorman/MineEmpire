using UnityEngine;

[CreateAssetMenu(fileName = "NewOtherData", menuName = "OtherData", order = 52)]
public class OtherData : ScriptableObject
{
    public float money;
    public float timer;
    public int lvl;
    public int exp;
    public int maxExp;
    public int lastIndex;
    public int amountProductionPerClick;
}
