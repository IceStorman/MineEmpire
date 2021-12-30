using UnityEngine;
using UnityEngine.UI;

public class AmountOfRecycleSpecialFirst : MonoBehaviour
{
    [SerializeField] private GameObject amountOfSpecialFirst;

    [SerializeField] private Text amountOfRecycleBenitoiteText;
    [SerializeField] private Text amountOfRecycleCopperText;
    [SerializeField] private Text amountOfRecycleDiamondText;

    [SerializeField] private Slider benitoiteSlider;
    [SerializeField] private Slider copperSlider;
    [SerializeField] private Slider diamondSlider;

    [SerializeField] private Text amountOfRecycleReceiveBenitoiteText;
    [SerializeField] private Text amountOfRecycleReceiveCopperText;
    [SerializeField] private Text amountOfRecycleReceiveDiamondText;

    [SerializeField] private MainData mainData;

    public int amountOfBenitoite;
    public int amountOfCopper;
    public int amountOfDiamond;

    void Start()
    {
        amountOfSpecialFirst.SetActive(false);
        benitoiteSlider.onValueChanged.AddListener(ChangeAmountOfBenitoite);
        copperSlider.onValueChanged.AddListener(ChangeAmountOfCopper);
        diamondSlider.onValueChanged.AddListener(ChangeAmountOfDiamond);

        benitoiteSlider.onValueChanged.AddListener(SliderBenitoiteText);
        copperSlider.onValueChanged.AddListener(SliderCopperText);
        diamondSlider.onValueChanged.AddListener(SliderDiamondText);
    }

    private void SliderBenitoiteText(float value)
    {
        amountOfRecycleBenitoiteText.text = $"{value:0}";
    }
    private void SliderCopperText(float value)
    {
        amountOfRecycleCopperText.text = $"{value:0}";
    }
    private void SliderDiamondText(float value)
    {
        amountOfRecycleDiamondText.text = $"{value:0}";
    }
    private void ChangeAmountOfBenitoite(float amount)
    {
        mainData.benitoiteData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfCopper(float amount)
    {
        mainData.copperData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfDiamond(float amount)
    {
        mainData.diamondData.amountOfRecycle = (int)amount;
    }
    public void OpenBenitoite(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;

        amountOfSpecialFirst.SetActive(true);
    }
    public void OpenCopper(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void OpenDiamond(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void AmountOfRecycleBenitoiteRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveBenitoiteText.text = oreData.amountOfRecycleReceive.ToString();
        amountOfSpecialFirst.SetActive(false);
    }
    public void AmountOfRecycleCopperRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveCopperText.text = oreData.amountOfRecycleReceive.ToString();
    }
    public void AmountOfRecycleDiamondRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveDiamondText.text = oreData.amountOfRecycleReceive.ToString();
    }

    public void Close()
    {
        amountOfSpecialFirst.SetActive(false);
    }
}
