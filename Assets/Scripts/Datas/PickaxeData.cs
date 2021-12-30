using UnityEngine;

[CreateAssetMenu(fileName = "NewPickaxeData", menuName = "PickaxeData", order = 58)]
public class PickaxeData : ScriptableObject
{
    public int prestigeLvl;
    public float prize;
    public bool isBought;
    public bool isPicked;
    public bool canBuy;
    public int hp;
    public int defaultHP;
    public int amountProductionPerClick;
}
