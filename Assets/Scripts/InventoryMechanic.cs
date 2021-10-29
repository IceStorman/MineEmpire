using UnityEngine;
using UnityEngine.UI;

public class InventoryMechanic : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPanel;
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

    private bool isOpen = false;

    private void Start()
    {
        InventoryPanel.SetActive(false);
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
            PlayerPrefs.SetInt("RecycleGold", 0);
            recycleGold = PlayerPrefs.GetFloat("RecycleGold");
            recycleGoldText.text = recycleGold.ToString("F2");
        }
    }

    public void Click()
    {
        if (!isOpen)
        {
            InventoryPanel.SetActive(true);
            isOpen = true;
        }
        else if (isOpen)
        {
            InventoryPanel.SetActive(false);
            isOpen = false;
        }
    }
}