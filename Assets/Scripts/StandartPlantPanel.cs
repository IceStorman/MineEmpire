using UnityEngine;
using UnityEngine.UI;

public class StandartPlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject standartPlantPanel;
    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;

    public int stone;
    public int iron;
    public int gold;
    public float recycleStone;
    public float recycleIron;
    public float recycleGold;

    private void Start()
    {
        standartPlantPanel.SetActive(false);
    }

    private void Update()
    {
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
            PlayerPrefs.SetFloat("RecycleGold", 0);
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString("F2");
        }

    }

    public void Open()
    {
        standartPlantPanel.SetActive(true);
    }

    public void Close()
    {
        standartPlantPanel.SetActive(false);
    }

    public void RecycleStone()
    {
        if (stone >= 1)
        {
            stone -= 1;
            stoneText.text = stone.ToString();
            recycleStone += 0.9f;
            recycleStoneText.text = recycleStone.ToString("F2");

            PlayerPrefs.SetInt("Stone", stone);
            PlayerPrefs.SetFloat("RecycleStone", recycleStone);
        }
    }

    public void RecycleIron()
    {
        if (iron >= 1)
        {
            iron -= 1;
            ironText.text = iron.ToString();
            recycleIron += 0.8f;
            recycleIronText.text = recycleIron.ToString("F2");

            PlayerPrefs.SetInt("Iron", iron);
            PlayerPrefs.SetFloat("RecycleIron", recycleIron);
        }
    }
    public void RecycleGold()
    {
        if (gold >= 1)
        {
            gold -= 1;
            goldText.text = gold.ToString();
            recycleGold += 0.8f;
            recycleGoldText.text = recycleGold.ToString("F2");

            PlayerPrefs.SetInt("Gold", gold);
            PlayerPrefs.SetFloat("RecycleGold", recycleGold);
        }
    }
}