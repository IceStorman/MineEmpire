using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achivement data", menuName = "AchivementData", order = 55)]
public class AchivementData : ScriptableObject
{
    /*static bool firstmoneyAchivement;
    static bool secondmoneyAchivement;
    static bool thirdmoneyAchivement;
    static bool fourthmoneyAchivement;
    static bool fifthmoneyAchivement;
    static bool sixthmoneyAchivement;
    static bool sevnthmoneyAchivement;
    static bool eighthmoneyAchivement;
    static bool ninethmoneyAchivement;*/
    public List<bool> moneysAchivementList = new List<bool>
    {
        /*firstmoneyAchivement,
        secondmoneyAchivement,
        thirdmoneyAchivement,
        fourthmoneyAchivement,
        fifthmoneyAchivement,
        sixthmoneyAchivement,
        sevnthmoneyAchivement,
        eighthmoneyAchivement,
        ninethmoneyAchivement*/
    };
}