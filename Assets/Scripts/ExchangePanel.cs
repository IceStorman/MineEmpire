using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private GameObject exchangePanel;
    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text moneyText;
    [SerializeField] private float speed;
    [SerializeField] private bool opening;
    [SerializeField] private bool closing;

    public float stone;
    public float iron;
    public float gold;
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
            moneyText.text = money.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("Money", 0);
            money = PlayerPrefs.GetFloat("Money");
            moneyText.text = money.ToString();
        }

        if (PlayerPrefs.HasKey("RecycleStone"))
        {
            stone = PlayerPrefs.GetFloat("RecycleStone");
            stoneText.text = stone.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleStone", 0);
            stone = PlayerPrefs.GetFloat("RecycleStone");
            stoneText.text = stone.ToString();
        }

        if (PlayerPrefs.HasKey("RecycleIron"))
        {
            iron = PlayerPrefs.GetFloat("RecycleIron");
            ironText.text = iron.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleIron", 0);
            iron = PlayerPrefs.GetFloat("RecycleIron");
            ironText.text = iron.ToString();
        }

        if (PlayerPrefs.HasKey("RecycleGold"))
        {
            gold = PlayerPrefs.GetFloat("RecycleGold");
            goldText.text = gold.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("RecycleGold", 0);
            gold = PlayerPrefs.GetFloat("RecycleGold");
            goldText.text = gold.ToString();
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

    public void TradeStone()
    {
        if(stone >= 10)
        {
            stone -= 10;
            stoneText.text = stone.ToString();
            money += 0.5f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleStone", stone);
            PlayerPrefs.SetFloat("Money", money);
        }
    }

    public void TradeIron()
    {
        if(iron >= 5)
        {
            iron -= 5;
            ironText.text = iron.ToString();
            money += 1.25f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleIron", iron);
            PlayerPrefs.SetFloat("Money", money);
        }
    }

    public void TradeGold()
    {
        if (gold >= 5)
        {
            gold -= 5;
            goldText.text = gold.ToString();
            money += 5f;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetFloat("RecycleGold", gold);
            PlayerPrefs.SetFloat("Money", money);
        }
    }
}