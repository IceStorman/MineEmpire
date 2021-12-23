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

    [SerializeField] private Image image2_1;
    [SerializeField] private Image image2_2;
    [SerializeField] private Image image2_3;
    [SerializeField] private Image image2_4;
    [SerializeField] private Image image2_5;
    [SerializeField] private Image image2_6;
    [SerializeField] private Image image2_7;
    [SerializeField] private Image image2_8;
    [SerializeField] private Image image2_9;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        List<Image> images1 = new List<Image>(9) { image1, image2, image3, image4, image5, image6, image7, image8, image9 };
        List<Image> images2 = new List<Image>(9) { image2_1, image2_2, image2_3, image2_4, image2_5, image2_6, image2_7, image2_8, image2_9 };

        List<int> oresCount = new List<int>() { mainData.copperData.ore, mainData.tinData.ore, mainData.benitoiteData.ore, mainData.emeraldData.ore,
            mainData.onyxData.ore, mainData.rubyData.ore, mainData.sapphireData.ore, mainData.diamondData.ore, mainData.amethystData.ore };

        /*for (int i = 0; i < 8; i++)
        { if (mainData.otherData.money >= moneysList[i] || mainData.achivementData.haveYouDone[i]) AchivementOn(images1[i], i); }*/

        /*for (int i = 0; i < 8; i++)
        { if (oresCount[i] > 0 || mainData.achivementData.haveYouDone2[i]) AchivementOn2(images2[i], i); }*/

        /*if (mainData.otherData.money >= moneysList[0] || mainData.achivementData.moneysAchivementList[0]) AchivementOn(image1, 0);
        if (mainData.otherData.money >= moneysList[1] || mainData.achivementData.moneysAchivementList[1]) AchivementOn(image2, 1);
        if (mainData.otherData.money >= moneysList[2] || mainData.achivementData.moneysAchivementList[2]) AchivementOn(image3, 2);
        if (mainData.otherData.money >= moneysList[3] || mainData.achivementData.moneysAchivementList[3]) AchivementOn(image4, 3);
        if (mainData.otherData.money >= moneysList[4] || mainData.achivementData.moneysAchivementList[4]) AchivementOn(image5, 4);
        if (mainData.otherData.money >= moneysList[5] || mainData.achivementData.moneysAchivementList[5]) AchivementOn(image6, 5);
        if (mainData.otherData.money >= moneysList[6] || mainData.achivementData.moneysAchivementList[6]) AchivementOn(image7, 6);
        if (mainData.otherData.money >= moneysList[7] || mainData.achivementData.moneysAchivementList[7]) AchivementOn(image8, 7);
        if (mainData.otherData.money >= moneysList[8] || mainData.achivementData.moneysAchivementList[8]) AchivementOn(image9, 8);*/
    }

    private void AchivementOn(Image image, int i)
    {
        image.overrideSprite = checkerOn;
        mainData.achivementData.haveYouDone[i] = true;
    }

    private void AchivementOn2(Image image, int i)
    {
        image.overrideSprite = checkerOn;
        mainData.achivementData.haveYouDone2[i] = true;
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
        if (mainData.achivementData.haveYouDone[num] && !mainData.achivementData.haveYouEarned[num])
        {
            mainData.otherData.exp += 10 + (num * 5);
            mainData.achivementData.haveYouEarned[num] = true;
        }
    }

    public void Earn2(int num)
    {
        if (mainData.achivementData.haveYouDone2[num] && !mainData.achivementData.haveYouEarned2[num])
        {
            mainData.otherData.exp += 10 + (num * 5);
            mainData.achivementData.haveYouEarned2[num] = true;
        }
    }
}