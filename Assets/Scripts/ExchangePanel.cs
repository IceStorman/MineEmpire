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

    [SerializeField] private static int howMuchMaterials = 3;
    public int timer = 5;
    public float recycleStone;
    public float recycleIron;
    public float recycleGold;

    [SerializeField] private float recycleStoneCount = 15;
    [SerializeField] private float recycleIronCount = 5;
    [SerializeField] private float recycleGoldCount = 5;

    /*float[] recycleMaterialCount = new float[3]
    {
        recycleStoneCount,
        recycleIronCount,
        recycleGoldCount
    };*/

    [SerializeField] private float recycleStoneCost = 7.90f;
    [SerializeField] private float recycleIronCost = 23.70f;
    [SerializeField] private float recycleGoldCost = 42.30f;

    [SerializeField] private string recycleStoneKey = "RecycleStone";
    [SerializeField] private string recycleIronKey = "RecycleIron";
    [SerializeField] private string recycleGoldKey = "RecycleGold";
    [SerializeField] private string recycleStoneCostKey = "RecycleStoneCost";
    [SerializeField] private string recycleIronCostKey = "RecycleIronCost";
    [SerializeField] private string recycleGoldCostKey = "RecycleGoldCost";
    [SerializeField] private string moneyKey = "Money";

    public float money;

    private void Start()
    {
        exchangePanel.SetActive(false);
        InvokeRepeating("ChangeCost", timer, timer);
        InvokeRepeating("TimerCount", 1, 1);
    }

    private void ChangeCost()
    {
        float up = 1.4f;
        float down = 0.6f;
        int rnd = Random.Range(0, 3);

        if (rnd == 1) recycleStoneCost *= up;
        if (rnd == 2) recycleStoneCost *= down;

        if (rnd == 1) recycleIronCost *= up;
        if (rnd == 2) recycleIronCost *= down;

        if (rnd == 1) recycleGoldCost *= up;
        if (rnd == 2) recycleGoldCost *= down;
        /*for (int i = 0; i < howMuchMaterials; i++)
        {

        }*/
    }

    private void TimerCount()
    {
        if (timer > 1) timer--;
        else timer = 5;
    }

    public void WriteMaterials()
    {
        recycleStoneText.text = recycleStone.ToString("F2");
        recycleIronText.text = recycleIron.ToString("F2");
        recycleGoldText.text = recycleGold.ToString("F2");

        recycleStoneCostText.text = $"X15 = {recycleStoneCost.ToString("F2")}";
        recycleIronCostText.text = $"X5 = {recycleIronCost.ToString("F2")}";
        recycleGoldCostText.text = $"X5 = {recycleGoldCost.ToString("F2")}";

        timerText.text = timer.ToString();
    }

    private void Update()
    {
        WriteMaterials();

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
        resource = PlayerPrefs.GetFloat(resourceKey);

        if (resource >= resourceCount)
        {
            resource -= resourceCount;
            money += resourceCost;

            resourceText.text = resource.ToString("F2");
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
        PlayerPrefs.SetFloat(key, 0);
        resource += PlayerPrefs.GetFloat(key);
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