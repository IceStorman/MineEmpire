using UnityEngine;
using UnityEngine.UI;

public class EarnResoursesMechanic : MonoBehaviour
{
    [SerializeField] private GameObject minePanel;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private int precentageOfIron;
    [SerializeField] private int precentageOfGold;

    public int stone;
    public int iron;
    public int gold;

    private void Start()
    {
        minePanel.SetActive(true);
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
            stone = 0;
            stoneText.text = stone.ToString();
        }

        if (PlayerPrefs.HasKey("Iron"))
        {
            iron = PlayerPrefs.GetInt("Iron");
            ironText.text = iron.ToString();
        }
        else
        {
            iron = 0;
            ironText.text = iron.ToString();
        }

        if (PlayerPrefs.HasKey("Gold"))
        {
            gold = PlayerPrefs.GetInt("Gold");
            goldText.text = gold.ToString();
        }
        else
        {
            gold = 0;
            goldText.text = gold.ToString();
        }
    }

    public void EarnMechanic()
    {
        int rnd = Random.Range(0, 101);
        if (precentageOfGold >= rnd) EarnGold();
        else if (precentageOfIron >= rnd) EarnIron();
        else EarnStone();
    }

    public void EarnStone()
    {
        stone = int.Parse(stoneText.text);
        stone++;
        stoneText.text = stone.ToString();
        PlayerPrefs.SetInt("Stone", stone);
    }

    public void EarnIron()
    {
        iron = int.Parse(ironText.text);
        iron++;
        ironText.text = iron.ToString();
        PlayerPrefs.SetInt("Iron", iron);
    }

    public void EarnGold()
    {
        gold = int.Parse(goldText.text);
        gold++;
        goldText.text = gold.ToString();
        PlayerPrefs.SetInt("Gold", gold);
    }
}
