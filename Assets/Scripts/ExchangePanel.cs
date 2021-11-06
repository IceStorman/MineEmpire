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

    private int rnd1;
    private int rnd2;
    private int rnd3;

    private float up = 1.4f;
    private float down = 0.6f;

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

        if(mainData.otherData.timer == 0)
        {
            ChangeCourse(rnd1, mainData.stoneData, recycleStoneCostText);
            ChangeCourse(rnd2, mainData.ironData, recycleIronCostText);
            ChangeCourse(rnd3, mainData.goldData, recycleGoldCostText);

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

    private void ChangeCourse(int rnd, OreData oreData, Text resourceText)
    {
        rnd = Random.Range(1, 3);

        if (rnd == 1)
        {
            oreData.recycleOreCost *= up;
            resourceText.text = oreData.recycleOreCost.ToString("F2");
        }
        else if (rnd == 2)
        {
            oreData.recycleOreCost *= down;
            resourceText.text = oreData.recycleOreCost.ToString("F2");
        }
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
    }

    private void Update()
    {
        DisplayTime(mainData.otherData.timer);
        UpdateUI();
    }

    private void UpdateUI()
    {
        moneyText.text = mainData.otherData.money.ToString("F2");
        recycleStoneText.text = mainData.stoneData.recycleOre.ToString("F2");
        recycleIronText.text = mainData.ironData.recycleOre.ToString("F2");
        recycleGoldText.text = mainData.goldData.recycleOre.ToString("F2");
        recycleStoneCostText.text = mainData.stoneData.recycleOreCost.ToString("F2");
        recycleIronCostText.text = mainData.ironData.recycleOreCost.ToString("F2");
        recycleGoldCostText.text = mainData.goldData.recycleOreCost.ToString("F2");
    }

    private void TradeResources(OreData oreData, Text resourceText)
    {
        if (oreData.recycleOre >= oreData.recycleOreGive)
        {
            oreData.recycleOre -= oreData.recycleOreGive;
            mainData.otherData.money += oreData.recycleOreCost;

            resourceText.text = oreData.recycleOre.ToString("F2");
            moneyText.text = mainData.otherData.money.ToString("F2");
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

    public void TradeRecycleStone()
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
    }
}