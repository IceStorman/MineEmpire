using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewMineData", menuName = "MineData", order = 54)]
public class MineData : ScriptableObject
{
    public int levelOfPrestige;
    public float cost;
    public bool isUnlocked;
    public bool isItOpenedNow;

    public float stonePercentage;
    public float ironPercentage;
    public float goldPercentage;
    public float copperPercentage;
    public float tinPercentage;
    public float benitoitePercentage;
    public float emeraldPercentage;
    public float onyxPercentage;
    public float rubyPercentage;
    public float sapphirePercentage;
    public float diamondPercentage;
    public float amethystPercentage;
}