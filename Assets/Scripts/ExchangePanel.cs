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
    public float money;

    private void Start()
    {
        exchangePanel.SetActive(false);
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetFloat("Money");
            moneyText.text = money.ToString("F2");
        }
        else
        {
            PlayerPrefs.SetFloat("Money", 0);
            money = PlayerPrefs.GetFloat("Money");
            moneyText.text = money.ToString("F2");
        }

        if (PlayerPrefs.HasKey("RecycleStone"))
        {
            recycleStone = PlayerPrefs.GetFloat("RecycleStone");
            recycleStoneText.text = recycleStone.ToString("F2");
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleStone", 0);
            recycleStone = PlayerPrefs.GetFloat("RecycleStone");
            recycleStoneText.text = recycleStone.ToString("F2");
        }

        if (PlayerPrefs.HasKey("RecycleIron"))
        {
            recycleIron = PlayerPrefs.GetFloat("RecycleIron");
            recycleIronText.text = recycleIron.ToString("F2");
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleIron", 0);
            recycleIron = PlayerPrefs.GetFloat("RecycleIron");
            recycleIronText.text = recycleIron.ToString("F2");
        }

        if (PlayerPrefs.HasKey("RecycleGold"))
        {
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString("F2");
        }
        else
        {
            PlayerPrefs.SetInt("RecycleGold", 0);
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString("F2");
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
        if(recycleStone >= 15)
        {
            recycleStone -= 15;
            recycleStoneText.text = recycleStone.ToString();
            money += 7.90f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleStone", recycleStone);
            PlayerPrefs.SetFloat("Money", money);
        }
    }

    public void TradeRecycleIron()
    {
        if(recycleIron >= 5)
        {
            recycleIron -= 5;
            recycleIronText.text = recycleIron.ToString();
            money += 23.70f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleIron", recycleIron);
            PlayerPrefs.SetFloat("Money", money);
        }
    }

    public void TradeRecycleGold()
    {
        if (recycleGold >= 5)
        {
            recycleGold -= 5;
            recycleGoldText.text = recycleGold.ToString();
            money += 42.30f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleGold", recycleGold);
            PlayerPrefs.SetFloat("Money", money);
        }
    }
}