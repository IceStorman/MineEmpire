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

    public int timer = 600;

    private int rnd1;
    private int rnd2;
    private int rnd3;

    public float recycleStone;
    public float recycleIron;
    public float recycleGold;

    private float up = 1.4f;
    private float down = 0.6f;

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

    private string recycleStoneKey = "RecycleStone";
    private string recycleIronKey = "RecycleIron";
    private string recycleGoldKey = "RecycleGold";

    private string recycleStoneCostKey = "RecycleStoneCost";
    private string recycleIronCostKey = "RecycleIronCost";
    private string recycleGoldCostKey = "RecycleGoldCost";

    [SerializeField] private string moneyKey = "Money";

    public float money;

    private void Start()
    {
        exchangePanel.SetActive(false);
        StartCoroutine(Timer());
    }
 
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);

        timer--;
        timerText.text = timer.ToString();

        if(timer == 0)
        {
            ChangeCourse(rnd1, recycleStoneCostKey, recycleStoneCost, recycleStoneCostText);
            ChangeCourse(rnd2, recycleIronCostKey, recycleIronCost, recycleIronCostText);
            ChangeCourse(rnd3, recycleGoldCostKey, recycleGoldCost, recycleGoldCostText);

            timer = 600;
            timerText.text = timer.ToString();
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

    private void ChangeCourse(int rnd, string resourceKey ,float resourceCost, Text resourceText)
    {
        rnd = Random.Range(1, 3);

        if (rnd == 1)
        {
            resourceCost *= up;
            resourceText.text = resourceCost.ToString("F2");
            PlayerPrefs.SetFloat(resourceKey, resourceCost);
        }
        else if (rnd == 2)
        {
            resourceCost *= down;
            resourceText.text = resourceCost.ToString("F2");
            PlayerPrefs.SetFloat(resourceKey, resourceCost);
        }
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
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

        if (Check(recycleStoneCostKey)) LoadResources(recycleStoneCostKey, recycleStoneCost,
             recycleStoneCostText);
        else NewResources(recycleStoneCostKey, recycleStoneCost, recycleStoneCostText);

        if (Check(recycleIronCostKey)) LoadResources(recycleIronCostKey, recycleIronCost,
             recycleIronCostText);
        else NewResources(recycleIronCostKey, recycleIronCost, recycleIronCostText);

        if (Check(recycleGoldCostKey)) LoadResources(recycleGoldCostKey, recycleGoldCost,
             recycleGoldCostText);
        else NewResources(recycleGoldCostKey, recycleGoldCost, recycleGoldCostText);

        DisplayTime(timer);
    }

    private void TradeResources(string resourceKey, float resourceCount, float resource,
        float resourceCost, string resourceCostKey, Text resourceText)
    {
        resource = PlayerPrefs.GetFloat(resourceKey);
        resourceCost = PlayerPrefs.GetFloat(resourceCostKey);

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
        TradeResources(recycleStoneKey, recycleStoneCount, recycleStone, recycleStoneCost, recycleStoneCostKey,
            recycleStoneText);
    }

    public void TradeRecycleIron()
    {
        TradeResources(recycleIronKey, recycleIronCount, recycleIron, recycleIronCost, recycleIronCostKey,
            recycleIronText);
    }

    public void TradeRecycleGold()
    {
        TradeResources(recycleGoldKey, recycleGoldCount, recycleGold, recycleGoldCost, recycleGoldCostKey,
            recycleGoldText);
    }
}