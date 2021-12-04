using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private GameObject exchangePanel;

    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;

    [SerializeField] private Text recycleStoneCostText;
    [SerializeField] private Text recycleIronCostText;
    [SerializeField] private Text recycleGoldCostText;

    [SerializeField] private Text moneyText;

    [SerializeField] private Text timerText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        exchangePanel.SetActive(false);
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);

        mainData.otherData.timer--;
        timerText.text = mainData.otherData.timer.ToString();

        if (mainData.otherData.timer <= 0)
        {
            ChangeCourse(mainData.stoneData, recycleStoneCostText);
            ChangeCourse(mainData.ironData, recycleIronCostText);
            ChangeCourse(mainData.goldData, recycleGoldCostText);

            mainData.otherData.timer = 600;
            timerText.text = mainData.otherData.timer.ToString();
        }

        Repeat();
    }

    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay == 0)
        {
            Repeat();
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void ChangeCourse(OreData oreData, Text resourceText)
    {
        int rnd = 1;
        int rndWhere = Random.Range(0, 2);

        if (rndWhere == 0) rnd = Random.Range(3, 10);
        else rnd = Random.Range(11, 31);

        oreData.recycleOreCost = (oreData.recycleOreCost * rnd) / 10;
        resourceText.text = oreData.recycleOreCost.ToString("F2");
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
    }

    private void Update()
    {
        DisplayTime(mainData.otherData.timer);
        UpdateUI(recycleStoneText, recycleStoneCostText, mainData.stoneData);
        UpdateUI(recycleIronText, recycleIronCostText, mainData.ironData);
        UpdateUI(recycleGoldText, recycleGoldCostText, mainData.goldData);
    }

    public void UpdateUI(Text recycleResourceText, Text recycleResourceCostText, OreData oreData)
    {
        moneyText.text = mainData.otherData.money.ToString("F2");
        recycleResourceText.text = oreData.recycleOre.ToString("F2");
        recycleResourceCostText.text = oreData.recycleOreCost.ToString("F2");
    }

    public void TradeResources(OreData oreData)
    {
        if (oreData.recycleOre >= oreData.recycleOreGive)
        {
            oreData.recycleOre -= oreData.recycleOreGive;
            mainData.otherData.money += oreData.recycleOreCost;
        }
    }

    public void Open()
    {
        exchangePanel.SetActive(true);
    }

    public void Close()
    {
        exchangePanel.SetActive(false);
    }

    /*public void TradeRecycleStone()
    {
        TradeResources(mainData.stoneData, recycleStoneText);
    }

    public void TradeRecycleIron()
    {
        TradeResources(mainData.ironData, recycleIronText);
    }

    public void TradeRecycleGold()
    {
        TradeResources(mainData.goldData, recycleGoldText);
    }*/
}