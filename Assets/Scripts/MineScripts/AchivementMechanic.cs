using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementMechanic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
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

    [SerializeField] private GameObject checkerImage1;
    [SerializeField] private GameObject checkerImage2;
    [SerializeField] private GameObject checkerImage3;
    [SerializeField] private GameObject checkerImage4;
    [SerializeField] private GameObject checkerImage5;
    [SerializeField] private GameObject checkerImage6;
    [SerializeField] private GameObject checkerImage7;
    [SerializeField] private GameObject checkerImage8;
    [SerializeField] private GameObject checkerImage9;

    private void Start()
    {
        panel.SetActive(false);
        checkerImage1.SetActive(false);
        checkerImage2.SetActive(false);
        checkerImage3.SetActive(false);
        checkerImage4.SetActive(false);
        checkerImage5.SetActive(false);
        checkerImage6.SetActive(false);
        checkerImage7.SetActive(false);
        checkerImage8.SetActive(false);
        checkerImage9.SetActive(false);
    }

    private void Update()
    {
        if (mainData.otherData.money >= moneysList[0] || mainData.achivementData.haveYouDone[0]) AchivementOn(image1, 0);
        if (mainData.otherData.money >= moneysList[1] || mainData.achivementData.haveYouDone[1]) AchivementOn(image2, 1);
        if (mainData.otherData.money >= moneysList[2] || mainData.achivementData.haveYouDone[2]) AchivementOn(image3, 2);
        if (mainData.otherData.money >= moneysList[3] || mainData.achivementData.haveYouDone[3]) AchivementOn(image4, 3);
        if (mainData.otherData.money >= moneysList[4] || mainData.achivementData.haveYouDone[4]) AchivementOn(image5, 4);
        if (mainData.otherData.money >= moneysList[5] || mainData.achivementData.haveYouDone[5]) AchivementOn(image6, 5);
        if (mainData.otherData.money >= moneysList[6] || mainData.achivementData.haveYouDone[6]) AchivementOn(image7, 6);
        if (mainData.otherData.money >= moneysList[7] || mainData.achivementData.haveYouDone[7]) AchivementOn(image8, 7);
        if (mainData.otherData.money >= moneysList[8] || mainData.achivementData.haveYouDone[8]) AchivementOn(image9, 8);

        if (mainData.achivementData.haveYouEarned[0]) checkerImage1.SetActive(true);
        if (mainData.achivementData.haveYouEarned[1]) checkerImage2.SetActive(true);
        if (mainData.achivementData.haveYouEarned[2]) checkerImage3.SetActive(true);
        if (mainData.achivementData.haveYouEarned[3]) checkerImage4.SetActive(true);
        if (mainData.achivementData.haveYouEarned[4]) checkerImage5.SetActive(true);
        if (mainData.achivementData.haveYouEarned[5]) checkerImage6.SetActive(true);
        if (mainData.achivementData.haveYouEarned[6]) checkerImage7.SetActive(true);
        if (mainData.achivementData.haveYouEarned[7]) checkerImage8.SetActive(true);
        if (mainData.achivementData.haveYouEarned[8]) checkerImage9.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Escape)) Close();
    }

    private void AchivementOn(Image image, int i)
    {
        image.overrideSprite = checkerOn;
        mainData.achivementData.haveYouDone[i] = true;
    }

    public void Close()
    {
        panel.SetActive(false);
    }

    public void Open()
    {
        panel.SetActive(true);
    }

    public void Earn(int num)
    {
        if (moneysList[num] <= mainData.otherData.money && !mainData.achivementData.haveYouEarned[num])
        {
            mainData.otherData.exp += 10 + (num * 5);
            mainData.achivementData.haveYouEarned[num] = true;
        }
    }

    public void Cheat()
    {
        mainData.otherData.money += 100000;
        mainData.otherData.exp += 100;
    }
}