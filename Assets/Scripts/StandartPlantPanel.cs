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
    }

    private void Update()
    {
        LoadProgress();
        WriteMaterials();
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