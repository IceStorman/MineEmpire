using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RentMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private PlantsData firstSpecialSectionData;

    [SerializeField] private GameObject firstSpecialPanel;

    [SerializeField] private Text rentFirstSpecialSectionText;

    private void Start()
    {
        firstSpecialPanel.SetActive(false);
    }

    public void EnterFirstSpecialSection()
    {
        ClickMechanic(firstSpecialSectionData, firstSpecialPanel);
    }

    private void ClickMechanic(PlantsData plantsData, GameObject plantPanel)
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
            }
        }
    }
}