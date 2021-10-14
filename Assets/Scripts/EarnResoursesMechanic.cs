using UnityEngine;
using UnityEngine.UI;

public class EarnResoursesMechanic : MonoBehaviour
{
    [SerializeField] private Text stoneText;

    private int stone;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Stone"))
        {
            stone = PlayerPrefs.GetInt("Stone");
            stoneText.text = stone.ToString();
        }
    }

    public void EarnStoneMechanic()
    {
        stone = int.Parse(stoneText.text);
        stone++;
        stoneText.text = stone.ToString();
    }
}
