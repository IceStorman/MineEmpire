using UnityEngine;
using UnityEngine.UI;

public class EarnResoursesMechanic : MonoBehaviour
{
    [SerializeField] private Text stoneText;

    public int stone;

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
    }

    public void EarnStoneMechanic()
    {
        stone = int.Parse(stoneText.text);
        stone++;
        stoneText.text = stone.ToString();
        PlayerPrefs.SetInt("Stone", stone);
    }
}
