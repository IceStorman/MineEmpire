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

    public int stone;
    public int iron;
    public int gold;
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

        if (PlayerPrefs.HasKey("Stone"))
        {
            stone = PlayerPrefs.GetInt("Stone");
            stoneText.text = stone.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Stone", 0);
            stone = PlayerPrefs.GetInt("Stone");
            stoneText.text = stone.ToString();
        }

        if (PlayerPrefs.HasKey("Iron"))
        {
            iron = PlayerPrefs.GetInt("Iron");
            ironText.text = iron.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Iron", 0);
            iron = PlayerPrefs.GetInt("Iron");
            ironText.text = iron.ToString();
        }

        if (PlayerPrefs.HasKey("Gold"))
        {
            gold = PlayerPrefs.GetInt("Gold");
            goldText.text = gold.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Gold", 0);
            gold = PlayerPrefs.GetInt("Gold");
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
        if(stone >= 5)
        {
            stone -= 5;
            stoneText.text = stone.ToString();
            money++;
            moneyText.text = money.ToString("F2");

            PlayerPrefs.SetInt("Stone", stone);
            PlayerPrefs.SetFloat("Money", money);
        }
    }
}