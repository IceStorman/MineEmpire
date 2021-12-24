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
    [SerializeField] MainData mainData;
    [SerializeField] private Sprite checkerOn;

    [SerializeField] private Image image1;
    [SerializeField] private Image image2;
    [SerializeField] private Image image3;
    [SerializeField] private Image image4;
    [SerializeField] private Image image5;
    [SerializeField] private Image image6;
    [SerializeField] private Image image7;
    [SerializeField] private Image image8;
    [SerializeField] private Image image9;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (mainData.otherData.money >= moneysList[0] || mainData.achivementData.moneysAchivementList[0]) AchivementOn(image1, 0);
        if (mainData.otherData.money >= moneysList[1] || mainData.achivementData.moneysAchivementList[1]) AchivementOn(image2, 1);
        if (mainData.otherData.money >= moneysList[2] || mainData.achivementData.moneysAchivementList[2]) AchivementOn(image3, 2);
        if (mainData.otherData.money >= moneysList[3] || mainData.achivementData.moneysAchivementList[3]) AchivementOn(image4, 3);
        if (mainData.otherData.money >= moneysList[4] || mainData.achivementData.moneysAchivementList[4]) AchivementOn(image5, 4);
        if (mainData.otherData.money >= moneysList[5] || mainData.achivementData.moneysAchivementList[5]) AchivementOn(image6, 5);
        if (mainData.otherData.money >= moneysList[6] || mainData.achivementData.moneysAchivementList[6]) AchivementOn(image7, 6);
        if (mainData.otherData.money >= moneysList[7] || mainData.achivementData.moneysAchivementList[7]) AchivementOn(image8, 7);
        if (mainData.otherData.money >= moneysList[8] || mainData.achivementData.moneysAchivementList[8]) AchivementOn(image9, 8);
    }

    private void AchivementOn(Image image, int i)
    {
        image.overrideSprite = checkerOn;
        mainData.achivementData.moneysAchivementList[i] = true;
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

    public void Earn(int num)
    {
        if (moneysList[num] <= mainData.otherData.money && !mainData.achivementData.haveYouEarned[num])
        {
            mainData.otherData.exp += 10 + (num * 5);
            mainData.achivementData.haveYouEarned[num] = true;
        }
    }
}