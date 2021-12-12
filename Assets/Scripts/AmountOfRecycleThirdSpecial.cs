using UnityEngine;
using UnityEngine.UI;

public class AmountOfRecycleThirdSpecial : MonoBehaviour
{
    [SerializeField] private GameObject amountOfSpecialThird;

    [SerializeField] private Text amountOfRecycleEmeraldText;
    [SerializeField] private Text amountOfRecycleRubyText;
    [SerializeField] private Text amountOfRecycleTinText;

    [SerializeField] private Slider emeraldSlider;
    [SerializeField] private Slider rubySlider;
    [SerializeField] private Slider tinSlider;

    [SerializeField] private Text amountOfRecycleReceiveEmeraldText;
    [SerializeField] private Text amountOfRecycleReceiveRubyText;
    [SerializeField] private Text amountOfRecycleReceiveTinText;

    [SerializeField] private MainData mainData;

    public int amountOfEmerald;
    public int amountOfRuby;
    public int amountOfTin;

    void Start()
    {
        amountOfSpecialThird.SetActive(false);
        emeraldSlider.onValueChanged.AddListener(ChangeAmountOfEmerald);
        rubySlider.onValueChanged.AddListener(ChangeAmountOfRuby);
        tinSlider.onValueChanged.AddListener(ChangeAmountOfTin);

        emeraldSlider.onValueChanged.AddListener(SliderEmeraldText);
        rubySlider.onValueChanged.AddListener(SliderRubyText);
        tinSlider.onValueChanged.AddListener(SliderTinText);
    }

    private void SliderEmeraldText(float value)
    {
        amountOfRecycleEmeraldText.text = $"{value:0}";
    }
    private void SliderRubyText(float value)
    {
        amountOfRecycleRubyText.text = $"{value:0}";
    }
    private void SliderTinText(float value)
    {
        amountOfRecycleTinText.text = $"{value:0}";
    }
    private void ChangeAmountOfEmerald(float amount)
    {
        mainData.emeraldData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfRuby(float amount)
    {
        mainData.rubyData.amountOfRecycle = (int)amount;
    }
    private void ChangeAmountOfTin(float amount)
    {
        mainData.tinData.amountOfRecycle = (int)amount;
    }
    public void OpenEmerald(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;

        amountOfSpecialThird.SetActive(true);
    }
    public void OpenRuby(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void OpenTin(OreData oreData)
    {
        oreData.amountOfRecycleReceive = 0;
    }
    public void AmountOfRecycleEmeraldRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveEmeraldText.text = oreData.amountOfRecycleReceive.ToString();
        amountOfSpecialThird.SetActive(false);
    }
    public void AmountOfRecycleRubyRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveRubyText.text = oreData.amountOfRecycleReceive.ToString();
    }
    public void AmountOfRecycleTinRecive(OreData oreData)
    {
        oreData.amountOfRecycleReceive += (oreData.amountOfRecycle * oreData.recycleCount);
        amountOfRecycleReceiveTinText.text = oreData.amountOfRecycleReceive.ToString();
    }

    public void Close()
    {
        amountOfSpecialThird.SetActive(false);
    }
}
