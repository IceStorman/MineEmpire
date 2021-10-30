using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private GameObject exchangePanel;
    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;
    [SerializeField] private Text moneyText;

    public float recycleStone;
    public float recycleIron;
    public float recycleGold;

    [SerializeField] private float recycleStoneCount = 15;
    [SerializeField] private float recycleIronCount = 5;
    [SerializeField] private float recycleGoldCount = 5;

    [SerializeField] private float recycleStoneCost = 7.90f;
    [SerializeField] private float recycleIronCost = 23.70f;
    [SerializeField] private float recycleGoldCost = 42.30f;

    [SerializeField] private string recycleStoneKey = "RecycleStone";
    [SerializeField] private string recycleIronKey = "RecycleIron";
    [SerializeField] private string recycleGoldKey = "RecycleGold";
    [SerializeField] private string moneyKey = "Money";

    public float money;

    private void Start()
    {
        exchangePanel.SetActive(false);      
    }

    private void Update()
    {
        if (Check(moneyKey)) LoadResources(moneyKey, money, moneyText);
        else NewResources(moneyKey, money, moneyText);

        if (Check(recycleStoneKey)) LoadResources(recycleStoneKey, recycleStone, recycleStoneText);
        else NewResources(recycleStoneKey, recycleStone, recycleStoneText);

        if (Check(recycleIronKey)) LoadResources(recycleIronKey, recycleIron, recycleIronText);
        else NewResources(recycleIronKey, recycleIron, recycleIronText);

        if (Check(recycleGoldKey)) LoadResources(recycleGoldKey, recycleGold, recycleGoldText);
        else NewResources(recycleGoldKey, recycleGold, recycleGoldText);
    }

    private void TradeResources(string resourceKey, float resourceCount, float resource,
        float resourceCost, Text resourceText)
    {
        if (resource >= resourceCount)
        {
            resource -= resourceCount;
            resourceText.text = resource.ToString("F2");
            money += resourceCost;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat(resourceKey, resource);
            PlayerPrefs.SetFloat(moneyKey, money);
        }
    }

    private bool Check(string key)
    {
        if (PlayerPrefs.HasKey(key)) return true;
        else return false;
    }

    private void LoadResources(string key, float resource, Text resourceText)
    {
        resource = PlayerPrefs.GetFloat(key);
        resourceText.text = resource.ToString("F2");
    }

    private void NewResources(string key, float resource, Text resourceText)
    {
        PlayerPrefs.SetFloat(key, resource);
        resource = PlayerPrefs.GetFloat(key);
        resourceText.text = resource.ToString("F2");
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
        TradeResources(recycleStoneKey, recycleStoneCount, recycleStone, recycleStoneCost, 
            recycleStoneText);
    }

    public void TradeRecycleIron()
    {
        TradeResources(recycleIronKey, recycleIronCount, recycleIron, recycleIronCost,
            recycleIronText);
    }

    public void TradeRecycleGold()
    {
        TradeResources(recycleGoldKey, recycleGoldCount, recycleGold, recycleGoldCost,
            recycleGoldText);
    }
}