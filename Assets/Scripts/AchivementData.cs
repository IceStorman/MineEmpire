using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achivement data", menuName = "AchivementData", order = 55)]
public class AchivementData : ScriptableObject
{
    static bool firstmoneyAchivement;
    public bool secondmoneyAchivement;
    public bool thirdmoneyAchivement;
    public bool fourthmoneyAchivement;
    public bool fifthmoneyAchivement;
    public bool sixthmoneyAchivement;
    public bool sevnthmoneyAchivement;
    public bool eighthmoneyAchivement;
    public bool ninethmoneyAchivement;
    public List<bool> moneysAchivementList = new List<bool>
    {
        firstmoneyAchivement
    };
}