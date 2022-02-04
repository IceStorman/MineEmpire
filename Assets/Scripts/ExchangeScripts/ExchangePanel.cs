using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private GameObject exchangePanel;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject buyPanel;
    [SerializeField] private GameObject sellPanel;
    [SerializeField] private GameObject lockSprite;
    [SerializeField] private GameObject lockText;

    private bool isOpenedExchangePanel;
    private bool isOpenBuyPanel = true;

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

    [SerializeField] private Text recycleStoneBuyCostText;
    [SerializeField] private Text recycleIronBuyCostText;
    [SerializeField] private Text recycleGoldBuyCostText;
    [SerializeField] private Text recycleTinBuyCostText;
    [SerializeField] private Text recycleCopperBuyCostText;
    [SerializeField] private Text recycleBenitoiteBuyCostText;
    [SerializeField] private Text recycleOnyxBuyCostText;
    [SerializeField] private Text recycleEmeraldBuyCostText;
    [SerializeField] private Text recycleRubyBuyCostText;
    [SerializeField] private Text recycleDiamondBuyCostText;
    [SerializeField] private Text recycleSapphireBuyCostText;
    [SerializeField] private Text recycleAmethystBuyCostText;

    [SerializeField] private Text moneyText;

    [SerializeField] private Text timerText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        exchangePanel.SetActive(false);
        inventoryPanel.SetActive(false);
        buyPanel.SetActive(false);
        StartCoroutine(Timer());

        ChangeOreBuyCost(mainData.stoneData);
        ChangeOreBuyCost(mainData.ironData);
        ChangeOreBuyCost(mainData.goldData);
        ChangeOreBuyCost(mainData.tinData);
        ChangeOreBuyCost(mainData.copperData);
        ChangeOreBuyCost(mainData.benitoiteData);
        ChangeOreBuyCost(mainData.onyxData);
        ChangeOreBuyCost(mainData.emeraldData);
        ChangeOreBuyCost(mainData.rubyData);
        ChangeOreBuyCost(mainData.diamondData);
        ChangeOreBuyCost(mainData.sapphireData);
        ChangeOreBuyCost(mainData.amethystData);
    }

    public void OpenInventory()
    {
        if (isOpenedExchangePanel)
        {
            inventoryPanel.SetActive(false);
            isOpenedExchangePanel = !isOpenedExchangePanel;
        }
        else
        {
            inventoryPanel.SetActive(true);
            isOpenedExchangePanel = !isOpenedExchangePanel;
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

        ChangeOreBuyCost(oreData);
    }

    private void Increase(OreData oreData)
    {
        oreData.recycleOreSellCost += (oreData.recycleOreSellCost * 5) / 100;
    }

    private void Decrease(OreData oreData)
    {
        oreData.recycleOreSellCost = (oreData.recycleOreSellCost * 95) / 100;
    }

    private void ChangeOreBuyCost(OreData oreData)
    {
        oreData.recycleOreBuyCost = (oreData.recycleOreSellCost * 107) / 100;
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
    }

    private void Update()
    {
        DisplayTime(mainData.otherData.timer);
        UpdateAllUI();
        if (Input.GetKeyDown(KeyCode.Escape)) Close();
    }

    private void UpdateAllUI()
    {
        UpdateUI(recycleStoneText, recycleStoneCostText, recycleStoneBuyCostText, mainData.stoneData);
        UpdateUI(recycleIronText, recycleIronCostText, recycleIronBuyCostText, mainData.ironData);
        UpdateUI(recycleGoldText, recycleGoldCostText, recycleGoldBuyCostText, mainData.goldData);
        UpdateUI(recycleTinText, recycleTinCostText, recycleTinBuyCostText, mainData.tinData);
        UpdateUI(recycleCopperText, recycleCopperCostText, recycleCopperBuyCostText, mainData.copperData);
        UpdateUI(recycleBenitoiteText, recycleBenitoiteCostText, recycleBenitoiteBuyCostText, mainData.benitoiteData);
        UpdateUI(recycleOnyxText, recycleOnyxCostText, recycleOnyxBuyCostText, mainData.onyxData);
        UpdateUI(recycleEmeraldText, recycleEmeraldCostText, recycleEmeraldBuyCostText, mainData.emeraldData);
        UpdateUI(recycleRubyText, recycleRubyCostText, recycleRubyBuyCostText, mainData.rubyData);
        UpdateUI(recycleDiamondText, recycleDiamondCostText, recycleDiamondBuyCostText, mainData.diamondData);
        UpdateUI(recycleSapphireText, recycleSapphireCostText, recycleSapphireBuyCostText, mainData.sapphireData);
        UpdateUI(recycleAmethystText, recycleAmethystCostText, recycleAmethystBuyCostText, mainData.amethystData);
    }

    public void UpdateUI(Text recycleResourceText, Text recycleResourceCostText, Text recycleRecourceBuyCost, OreData oreData)
    {
        moneyText.text = mainData.otherData.money.ToString("F2");
        recycleResourceText.text = oreData.recycleOre.ToString("F2");
        recycleResourceCostText.text = oreData.recycleOreSellCost.ToString("F2");
        recycleRecourceBuyCost.text = oreData.recycleOreBuyCost.ToString("F2");
        if (mainData.otherData.lvl >= 6)
        {
            lockSprite.SetActive(false);
            lockText.SetActive(false);
        }
        else
        {
            lockSprite.SetActive(true);
            buyPanel.SetActive(false);
            sellPanel.SetActive(true);
            lockText.SetActive(true);
        } 
    }

    public void SellResources(OreData oreData)
    {
        if (oreData.recycleOre >= oreData.recycleOreGive)
        {
            oreData.recycleOre -= oreData.recycleOreGive;
            mainData.otherData.money += oreData.recycleOreSellCost;
        }
    }

    public void BuyRecources(OreData oreData)
    {
        if(mainData.otherData.money >= oreData.recycleOreBuyCost)
        {
            mainData.otherData.money -= oreData.recycleOreBuyCost;
            oreData.recycleOre += oreData.recycleOreGive;
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

    public void OpenBuyPanel()
    {
        if(mainData.otherData.lvl >= 6)
        {
            buyPanel.SetActive(isOpenBuyPanel);
            sellPanel.SetActive(!isOpenBuyPanel);
            isOpenBuyPanel = !isOpenBuyPanel;
        }
    }
}