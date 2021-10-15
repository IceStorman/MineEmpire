using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private RectTransform panel;
    [SerializeField] private Text stoneText;
    [SerializeField] private Text moneyText;

    public int stone;
    public float money;

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
    }

    public void Open()
    {
        panel.localPosition = new Vector2(0, 0);
    }
    public void Close()
    {
        panel.localPosition = new Vector2(800, 0);
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