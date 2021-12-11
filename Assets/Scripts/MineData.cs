using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewMineData", menuName = "MineData", order = 54)]
public class MineData : ScriptableObject
{
    public int levelOfPrestige;
    public float cost;
    public bool isUnlocked;
    public bool isItOpenedNow;
    public List<float> listOfPrecentages = new List<float>();
    listOfPrecentages.Add();

    public float stoneProcentInOre;
    public float ironProcentInOre;
}