using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    [SerializeField] private RectTransform panel;
    [SerializeField] private Text stoneText;
    [SerializeField] private Text moneyText;

    public int stone;
    public float money;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }
        else
        {
            PlayerPrefs.SetInt("Money", 0);
            money = PlayerPrefs.GetInt("Money");
        }

        if (PlayerPrefs.HasKey("Stone"))
        {
            stone = PlayerPrefs.GetInt("Stone");
        }
        else
        {
            PlayerPrefs.SetInt("Stone", 0);
            stone = PlayerPrefs.GetInt("Stone");
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
            money++;
            PlayerPrefs.SetInt("Stone", stone);
            PlayerPrefs.SetFloat("Money", money);
        }
    }
}