using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achivement data", menuName = "AchivementData", order = 55)]
public class AchivementData : ScriptableObject
{
    public List<bool> moneysAchivementList = new List<bool> { };
    public List<bool> haveYouEarned = new List<bool> { };
}