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

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        /*Image[] imagesMass =
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
        };*/

        //if (mainData.otherData.money <= moneysList[0])

        /*for (int i = 0; i < 9; i++)
        {
            if (mainData.otherData.money <= moneysList[i] || mainData.achivementData.moneysAchivementList[i])
            {
                imagesMass[i] = checkerOn;
            }
        }*/
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