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

    public static int stone;
    public static int iron;
    public static int gold;

    public static float recycleStone;
    public static float recycleIron;
    public static float recycleGold;

    public int[] materials = new int[3]
    {
        stone,
        iron,
        gold
    };

    public float[] recycledMaterials = new float[3]
    {
        recycleStone,
        recycleIron,
        recycleGold
    };

    private void Start()
    {
        standartPlantPanel.SetActive(false);
        LoadProgress();
    }

    private void Update()
    {
        WriteMaterials();
        /*if (PlayerPrefs.HasKey("Stone"))
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
        }*/
    }

    public void WriteMaterials()
    {
        stoneText.text = stone.ToString();
        ironText.text = iron.ToString();
        goldText.text = gold.ToString();

        recycleStoneText.text = recycleStone.ToString("F2");
        recycleIronText.text = recycleIron.ToString("F2");
        recycleGoldText.text = recycleGold.ToString("F2");
    }

    public void LoadProgress()
    {
        stone = PlayerPrefs.GetInt("Stone");
        iron = PlayerPrefs.GetInt("Iron");
        gold = PlayerPrefs.GetInt("Gold");

        recycleStone = PlayerPrefs.GetFloat("RecycleStone");
        recycleIron = PlayerPrefs.GetFloat("RecycleIron");
        recycleGold = PlayerPrefs.GetFloat("RecycleGold");
    }

    public void SaveProgress()
    {
        PlayerPrefs.SetInt("Stone", stone);
        PlayerPrefs.SetInt("Iron", iron);
        PlayerPrefs.SetInt("Gold", gold);

        PlayerPrefs.SetFloat("RecycleStone", recycleStone);
        PlayerPrefs.SetFloat("RecycleIron", recycleIron);
        PlayerPrefs.SetFloat("RecycleGold", recycleGold);
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