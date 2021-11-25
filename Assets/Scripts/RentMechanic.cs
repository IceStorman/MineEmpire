using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RentMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private AllPlantsData allPlantsData;

    [SerializeField] private GameObject firstSpecialPanel;

    [SerializeField] private Text rentFirstSpecialSectionText;

    [SerializeField] private Text firstSpecialSectionTimeLeftText;

    private void Start()
    {
        firstSpecialPanel.SetActive(false);
    }

    public void EnterFirstSpecialSection()
    {
        ClickMechanic(allPlantsData.firstSpecialSectionData, firstSpecialPanel, firstSpecialSectionTimeLeftText);
    }

    private void ClickMechanic(PlantsData plantsData, GameObject plantPanel, Text plantSectionLeftTime)
    {
        if (plantsData.isRented)
        {
            plantPanel.SetActive(true);
        }
        else
        {
            if(mainData.otherData.money >= plantsData.rentCost)
            {
                mainData.otherData.money -= plantsData.rentCost;
                StopAllCoroutines();
                StartCoroutine(Timer(plantsData, plantSectionLeftTime));
                plantsData.isRented = true;
                rentFirstSpecialSectionText.text = "Enter";
                plantPanel.SetActive(true);
            }
        }
    }

    private IEnumerator Timer(PlantsData plantsData, Text plantSectionLeftTime)
    {
        yield return new WaitForSeconds(1);

        plantsData.rentTime--;
        plantSectionLeftTime.text = plantsData.rentTime.ToString();
        Repeat(plantsData, plantSectionLeftTime);

        if(plantsData.rentTime == 0)
        {
            plantsData.isRented = false;
            plantSectionLeftTime.text = "";
        }
    }

    private void Repeat(PlantsData plantsData, Text plantSectionLeftTime)
    {
        StartCoroutine(Timer(plantsData, plantSectionLeftTime));
    }
}