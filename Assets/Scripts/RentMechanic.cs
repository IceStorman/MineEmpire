using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RentMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private PlantsData firstSpecialSectionData;

    [SerializeField] private GameObject firstSpecialPanel;

    [SerializeField] private Text rentFirstSpecialSectionText;

    [SerializeField] private Text firstSpecialSectionTimeLeftText;

    private void Start()
    {
        firstSpecialPanel.SetActive(false);
    }

    public void EnterFirstSpecialSection()
    {
        ClickMechanic(firstSpecialSectionData, firstSpecialPanel, firstSpecialSectionTimeLeftText);
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
                plantsData.isRented = true;
                rentFirstSpecialSectionText.text = "Enter";
                StartCoroutine(Timer(plantsData, plantSectionLeftTime));
            }
        }
    }

    private IEnumerator Timer(PlantsData plantsData, Text plantSectionLeftTime)
    {
        yield return new WaitForSeconds(1);

        if (plantsData.isRented)
        {
            plantsData.rentTime--;
            plantSectionLeftTime.text = plantsData.rentTime.ToString();
        }

        if(plantsData.rentTime == 0)
        {
            plantsData.isRented = false;
        }
    }
}