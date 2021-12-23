using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achivement data", menuName = "AchivementData", order = 55)]
public class AchivementData : ScriptableObject
{
    public List<bool> haveYouDone = new List<bool>(9) { };
    public List<bool> haveYouEarned = new List<bool>(9) { };
    public List<bool> haveYouDone2 = new List<bool>(9) { };
    public List<bool> haveYouEarned2 = new List<bool>(9) { };
}