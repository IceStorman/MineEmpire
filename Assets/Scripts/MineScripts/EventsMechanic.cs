using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EventsMechanic : MonoBehaviour
{
    [SerializeField] private List<string> eventDialogs = new List<string>();
    [SerializeField] private Text eventText;
    [SerializeField] private MainData mainData;
    [SerializeField] private List<float> oldCosts = new List<float>(12);
    private bool isTimerEnd = false;

    private void Start()
    {
        ReWriteCosts();
        NothingText();
    }

    private void ReWriteCosts()
    {
        for(int i = 0; i < oldCosts.Count; i++)
        {
            oldCosts[i] = mainData.allOresDatas[i].recycleOreSellCost;
        }
    }

    void Update()
    {
        if (mainData.otherData.timer == 600 && !isTimerEnd) CheckAll();
        else if (mainData.otherData.timer == 570)
        {
            isTimerEnd = false;
            NothingText();
            ReWriteCosts();
        }
        else if (mainData.otherData.timer < 570) NothingText();
    }

    private void NothingText()
    {
        eventText.text = "Nothing happening";
    }

    private void CheckAll()
    {
        bool isChanged = false;
        int j = 0;
        for (int i = oldCosts.Count - 1; i >= 0; i--)
        {
            if (oldCosts[i] < mainData.allOresDatas[i].recycleOreSellCost)
            {
                eventText.text = $"{eventDialogs[i]} it costs now {mainData.allOresDatas[j].recycleOreSellCost}$";
                isChanged = true;
                break;
            }
            j++;
        }
        if (!isChanged) eventText.text = "Economic in whole world is crushing. Alll the ores sells pretty bad.";
    }
}
