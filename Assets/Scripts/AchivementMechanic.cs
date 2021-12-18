using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementMechanic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool isOpened = false;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Text textPrefab;
    public List<int> moneysList = new List<int>(9);
    [SerializeField] Image checkerOn;
    [SerializeField] MainData mainData;

    [SerializeField] static Image image1;
    [SerializeField] static Image image2;
    [SerializeField] static Image image3;
    [SerializeField] static Image image4;
    [SerializeField] static Image image5;
    [SerializeField] static Image image6;
    [SerializeField] static Image image7;
    [SerializeField] static Image image8;
    [SerializeField] static Image image9;
    [SerializeField] Image[] imagesMass = 
    {
        image1,
        image2,
        image3,
        image4,
        image5,
        image6,
        image7,
        image8,
        image9,
    };

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            if (mainData.otherData.money <= moneysList[i] || mainData.achivementData.moneysAchivementList[i])
            {
                imagesMass[i] = checkerOn;
            }
        }
    }

    public void Click(Button button)
    {
        button.image = checkerOn;
    }

    public void OpenClose()
    {
        if (!isOpened)
        {
            panel.SetActive(true);
            isOpened = !isOpened;
        }
        else if (isOpened)
        {
            panel.SetActive(false);
            isOpened = !isOpened;
        }
    }
}