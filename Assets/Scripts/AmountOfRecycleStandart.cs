using UnityEngine;
using UnityEngine.UI;

public class AmountOfRecycleStandart : MonoBehaviour
{
    [SerializeField] private GameObject amountOfRecyclePanel;

    [SerializeField] private Text amountOfRecycleStoneText;
    [SerializeField] private Text amountOfRecycleIronText;
    [SerializeField] private Text amountOfRecycleGoldText;

    [SerializeField] private Slider stoneSlider;
    [SerializeField] private Slider ironSlider;
    [SerializeField] private Slider goldSlider;

    [SerializeField] private MainData mainData;

    public int amountOfStone;
    public int amountOfIron;
    public int amountOfGold;

    void Start()
    {
        amountOfRecyclePanel.SetActive(false);
        stoneSlider.onValueChanged.AddListener(ChangeAmountOfStone);
        ironSlider.onValueChanged.AddListener(ChangeAmountOfIron);
        goldSlider.onValueChanged.AddListener(ChangeAmountOfGold);

        stoneSlider.onValueChanged.AddListener(SliderStoneText);
        ironSlider.onValueChanged.AddListener(SliderIronText);
        goldSlider.onValueChanged.AddListener(SliderGoldText);
    }

    private void SliderStoneText(float value)
    {
        amountOfRecycleStoneText.text = $"{value:0}";
    }
    private void SliderIronText(float value)
    {
        amountOfRecycleIronText.text = $"{value:0}";
    }
    private void SliderGoldText(float value)
    {
        amountOfRecycleGoldText.text = $"{value:0}";
    }
    private void ChangeAmountOfStone(float amount)
    {
        mainData.stoneData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfIron(float amount)
    {
        mainData.ironData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfGold(float amount)
    {
        mainData.goldData.amountOfRecycle = (int)amount;
    }

    public void Open()
    {
        amountOfRecyclePanel.SetActive(true);
    }

    public void Close()
    {
        amountOfRecyclePanel.SetActive(false);
    }
}
