using UnityEngine;
using UnityEngine.UI;

public class StandartPlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject standartPlantPanel;
    [SerializeField] private Text stoneText;
    [SerializeField] private Text stoneText2;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;
    [SerializeField] private Text recycleStoneText2;
    [SerializeField] private Text recycleIronText2;
    [SerializeField] private Text recycleGoldText2;

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
        recycleGoldText2.text = recycleGoldText.text;
        recycleIronText2.text = recycleIronText.text;
        recycleStoneText2.text = recycleStoneText.text;
        stoneText2.text = stoneText.text;

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
            recycleStoneText.text = recycleStone.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleStone", 0);
            recycleStone = PlayerPrefs.GetFloat("RecycleStone");
            recycleStoneText.text = recycleStone.ToString();
        }

        if (PlayerPrefs.HasKey("RecycleIron"))
        {
            recycleIron = PlayerPrefs.GetFloat("RecycleIron");
            recycleIronText.text = recycleIron.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleIron", 0);
            recycleIron = PlayerPrefs.GetFloat("RecycleIron");
            recycleIronText.text = recycleIron.ToString();
        }

        if (PlayerPrefs.HasKey("RecycleGold"))
        {
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("RecycleGold", 0);
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString();
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
        if (stone >= 10)
        {
            stone -= 10;
            stoneText.text = stone.ToString();
            recycleStone++;
            recycleStoneText.text = recycleStone.ToString("F2");

            PlayerPrefs.SetInt("Stone", stone);
            PlayerPrefs.SetFloat("RecycleStone", recycleStone);
        }
    }

    public void RecycleIron()
    {
        if (iron >= 10)
        {
            iron -= 10;
            ironText.text = iron.ToString();
            recycleIron++;
            recycleIronText.text = recycleIron.ToString("F2");

            PlayerPrefs.SetInt("Iron", iron);
            PlayerPrefs.SetFloat("RecycleIron", recycleIron);
        }
    }
    public void RecycleGold()
    {
        if (gold >= 10)
        {
            gold -= 10;
            goldText.text = gold.ToString();
            recycleGold++;
            recycleGoldText.text = recycleGold.ToString("F2");

            PlayerPrefs.SetInt("Gold", gold);
            PlayerPrefs.SetFloat("RecycleGold", recycleGold);
        }
    }
}