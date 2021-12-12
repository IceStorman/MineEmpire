using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RentMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private AllPlantsData allPlantsData;

    [SerializeField] private GameObject firstSpecialPanel;
    [SerializeField] private GameObject secondSpecialPanel;
    [SerializeField] private GameObject thirdSpecialPanel;

    [SerializeField] private Text rentFirstSpecialSectionText;
    [SerializeField] private Text rentSecondSpecialSectionText;
    [SerializeField] private Text rentThirdSpecialSectionText;

    [SerializeField] private Text firstSpecialSectionTimeLeftText;
    [SerializeField] private Text secondSpecialSectionTimeLeftText;
    [SerializeField] private Text thirdSpecialSectionTimeLeftText;

    private void Start()
    {
        firstSpecialPanel.SetActive(false);
    }

    public void EnterFirstSpecialSection()
    {
        ClickMechanic(allPlantsData.firstSpecialSectionData, allPlantsData.defaultFirstSpecialSectionData, firstSpecialPanel, firstSpecialSectionTimeLeftText);
    }
    public void EnterSecondSpecialSection()
    {
        ClickMechanic(allPlantsData.secondSpecialSectionData, allPlantsData.defaulSecondSpecialSectionData, secondSpecialPanel, secondSpecialSectionTimeLeftText);
    }
    public void EnterThirdSpecialSection()
    {
        ClickMechanic(allPlantsData.thirdSpecialSectionData, allPlantsData.defaultThirdSpecialSectionData, thirdSpecialPanel, thirdSpecialSectionTimeLeftText);
    }

    private void ClickMechanic(PlantsData plantsData, DefaultPlantData defaultPlantData, GameObject plantPanel, Text plantSectionLeftTime)
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
                plantsData.rentTime = defaultPlantData.defaultRentTime;
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

        if(plantsData.rentTime <= 0)
        {
            plantsData.isRented = false;
            plantSectionLeftTime.text = "";
            rentFirstSpecialSectionText.text = "250$ / 5min";
        }

        DisplayTime(plantsData.rentTime, plantSectionLeftTime);
        Repeat(plantsData, plantSectionLeftTime);
    }

    private void DisplayTime(float timer, Text timerText)
    {
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Repeat(PlantsData plantsData, Text plantSectionLeftTime)
    {
        if(plantsData.isRented) StartCoroutine(Timer(plantsData, plantSectionLeftTime));
    }
}