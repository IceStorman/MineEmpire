using UnityEngine;
using UnityEngine.UI;

public class AmountOfRecycleSpecialSecond : MonoBehaviour
{
    [SerializeField] private GameObject amountOfSpecialSecond;

    [SerializeField] private Text amountOfRecycleSapphireText;
    [SerializeField] private Text amountOfRecycleAmethystText;
    [SerializeField] private Text amountOfRecycleOnyxText;

    [SerializeField] private Slider sapphireSlider;
    [SerializeField] private Slider amethystSlider;
    [SerializeField] private Slider onyxSlider;

    [SerializeField] private Text amountOfRecycleReceiveSapphireText;
    [SerializeField] private Text amountOfRecycleReceiveAmethystText;
    [SerializeField] private Text amountOfRecycleReceiveOnyxText;

    [SerializeField] private MainData mainData;

    public int amountOfSapphire;
    public int amountOfAmethyst;
    public int amountOfOnyx;

    void Start()
    {
        amountOfSpecialSecond.SetActive(false);
        sapphireSlider.onValueChanged.AddListener(ChangeAmountOfSapphire);
        amethystSlider.onValueChanged.AddListener(ChangeAmountOfAmethyst);
        onyxSlider.onValueChanged.AddListener(ChangeAmountOfOnyx);

        sapphireSlider.onValueChanged.AddListener(SliderSapphireText);
        amethystSlider.onValueChanged.AddListener(SliderAmethystText);
        onyxSlider.onValueChanged.AddListener(SliderOnyxText);
    }

    private void SliderSapphireText(float value)
    {
        amountOfRecycleSapphireText.text = $"{value:0}";
    }
    private void SliderAmethystText(float value)
    {
        amountOfRecycleAmethystText.text = $"{value:0}";
    }
    private void SliderOnyxText(float value)
    {
        amountOfRecycleOnyxText.text = $"{value:0}";
    }
    private void ChangeAmountOfSapphire(float amount)
    {
        mainData.sapphireData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfAmethyst(float amount)
    {
        mainData.amethystData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfOnyx(float amount)
    {
        mainData.onyxData.amountOfRecycle = (int)amount;
    }
    public void OpenSapphire(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;

        amountOfSpecialSecond.SetActive(true);
    }
    public void OpenAmethyst(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void OpenOnyx(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void AmountOfRecycleSapphireRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveSapphireText.text = oreData.amountOfRecycleReceive.ToString();
        amountOfSpecialSecond.SetActive(false);
    }
    public void AmountOfRecycleAmethystRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveAmethystText.text = oreData.amountOfRecycleReceive.ToString();
    }
    public void AmountOfRecycleOnyxRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveOnyxText.text = oreData.amountOfRecycleReceive.ToString();
    }

    public void Close()
    {
        amountOfSpecialSecond.SetActive(false);
    }
}
