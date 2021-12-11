using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private GameObject exchangePanel;
    [SerializeField] private GameObject inventoryPanel;

    private bool isOpened;

    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;
    [SerializeField] private Text recycleTinText;
    [SerializeField] private Text recycleCopperText;
    [SerializeField] private Text recycleBenitoiteText;
    [SerializeField] private Text recycleOnyxText;
    [SerializeField] private Text recycleEmeraldText;
    [SerializeField] private Text recycleRubyText;
    [SerializeField] private Text recycleDiamondText;
    [SerializeField] private Text recycleSapphireText;
    [SerializeField] private Text recycleAmethystText;

    [SerializeField] private Text recycleStoneCostText;
    [SerializeField] private Text recycleIronCostText;
    [SerializeField] private Text recycleGoldCostText;
    [SerializeField] private Text recycleTinCostText;
    [SerializeField] private Text recycleCopperCostText;
    [SerializeField] private Text recycleBenitoiteCostText;
    [SerializeField] private Text recycleOnyxCostText;
    [SerializeField] private Text recycleEmeraldCostText;
    [SerializeField] private Text recycleRubyCostText;
    [SerializeField] private Text recycleDiamondCostText;
    [SerializeField] private Text recycleSapphireCostText;
    [SerializeField] private Text recycleAmethystCostText;

    [SerializeField] private Text moneyText;

    [SerializeField] private Text timerText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        exchangePanel.SetActive(false);
        inventoryPanel.SetActive(false);
        StartCoroutine(Timer());
    }

    public void OpenInventory()
    {
        if (isOpened)
        {
            inventoryPanel.SetActive(false);
            isOpened = !isOpened;
        }
        else
        {
            inventoryPanel.SetActive(true);
            isOpened = !isOpened;
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);

        mainData.otherData.timer--;
        timerText.text = mainData.otherData.timer.ToString();

        if (mainData.otherData.timer <= 0)
        {
            ChangeCourse(mainData.stoneData);
            ChangeCourse(mainData.ironData);
            ChangeCourse(mainData.goldData);
            ChangeCourse(mainData.tinData);
            ChangeCourse(mainData.copperData);
            ChangeCourse(mainData.benitoiteData);
            ChangeCourse(mainData.onyxData);
            ChangeCourse(mainData.emeraldData);
            ChangeCourse(mainData.rubyData);
            ChangeCourse(mainData.diamondData);
            ChangeCourse(mainData.sapphireData);
            ChangeCourse(mainData.amethystData);

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

    private void ChangeCourse(OreData oreData)
    {
        int rndWhere = Random.Range(1, 101);

        if (rndWhere <= oreData.numberNeededToDecrease)
        {       
            if (oreData.numberNeededToDecrease > 5) oreData.numberNeededToDecrease -= 5;
            Decrease(oreData);
        }
        else
        {
            if (oreData.numberNeededToDecrease < 95) oreData.numberNeededToDecrease += 5;
            Increase(oreData);
        }
    }

    private void Increase(OreData oreData)
    {
        oreData.recycleOreCost += (oreData.recycleOreCost * 5) / 100;
    }

    private void Decrease(OreData oreData)
    {
        oreData.recycleOreCost = (oreData.recycleOreCost * 95) / 100;
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
    }

    private void Update()
    {
        DisplayTime(mainData.otherData.timer);
        UpdateAllUI();     
    }

    private void UpdateAllUI()
    {
        UpdateUI(recycleStoneText, recycleStoneCostText, mainData.stoneData);
        UpdateUI(recycleIronText, recycleIronCostText, mainData.ironData);
        UpdateUI(recycleGoldText, recycleGoldCostText, mainData.goldData);
        UpdateUI(recycleTinText, recycleTinCostText, mainData.tinData);
        UpdateUI(recycleCopperText, recycleCopperCostText, mainData.copperData);
        UpdateUI(recycleBenitoiteText, recycleBenitoiteCostText, mainData.benitoiteData);
        UpdateUI(recycleOnyxText, recycleOnyxCostText, mainData.onyxData);
        UpdateUI(recycleEmeraldText, recycleEmeraldCostText, mainData.emeraldData);
        UpdateUI(recycleRubyText, recycleRubyCostText, mainData.rubyData);
        UpdateUI(recycleDiamondCostText, recycleDiamondCostText, mainData.diamondData);
        UpdateUI(recycleSapphireText, recycleSapphireCostText, mainData.sapphireData);
        UpdateUI(recycleAmethystText, recycleAmethystCostText, mainData.amethystData);
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
}