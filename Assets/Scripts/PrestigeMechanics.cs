using UnityEngine;
using UnityEngine.UI;

public class PrestigeMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;
    [SerializeField] private GameObject upgradePanel;

    [SerializeField] private Text moneyText;

    [SerializeField] private Text expText;
    [SerializeField] private Text maxExpText;
    [SerializeField] private Text lvlText;

    [SerializeField] private Text phoneText;
    [SerializeField] private Text phoneCostText;
    [SerializeField] private Image phoneImage;
    [SerializeField] private Image buyPhoneButtonImage;

    [SerializeField] private Text pcText;
    [SerializeField] private Text pcCostText;
    [SerializeField] private Image pcImage;
    [SerializeField] private Image buyPcButtonImage;

    [SerializeField] private Text flatText;
    [SerializeField] private Text flatCostText;
    [SerializeField] private Image flatImage;
    [SerializeField] private Image buyFlatButtonImage;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        prestigePanel.SetActive(false);
        upgradePanel.SetActive(false);
        UpdateUI(mainData.phoneData, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpdateUI(mainData.PCData, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpdateUI(mainData.flatData, flatText, flatCostText, flatImage, buyFlatButtonImage);
    }

    public void OpenPanel()
    {
        prestigePanel.SetActive(true);
        UpdateUI(mainData.phoneData, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpdateUI(mainData.PCData, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpdateUI(mainData.flatData, flatText, flatCostText, flatImage, buyFlatButtonImage);
    }

    public void ClosePanel()
    {
        prestigePanel.SetActive(false);
    }

    private void UpdateUI(PrestigeData prestigeData, Text thingText, Text thingCost, Image thingImage, 
        Image buyThingButtonImage)
    {
        moneyText.text = mainData.otherData.money.ToString("F2");
        lvlText.text = mainData.otherData.lvl.ToString();
        expText.text = mainData.otherData.exp.ToString();
        maxExpText.text = mainData.otherData.maxExp.ToString();

        if (prestigeData.canUpgrade)
        {
            thingText.text = prestigeData.unlockThingText;
            thingCost.text = prestigeData.thingCost.ToString("F2");
            thingImage.sprite = prestigeData.unlockThingSprite;
            buyThingButtonImage.sprite = prestigeData.unlockButtonSprite;
        }
        else
        {
            thingText.text = prestigeData.lockThingText;
            thingCost.text = prestigeData.lockThingText;
            thingImage.sprite = prestigeData.lockThingSprite;
            buyThingButtonImage.sprite = prestigeData.lockButtonSprite;
        }     
    }

    private void UpgradeThing(PrestigeData prestigeData, Text thingCostText)
    {
        if(prestigeData.canUpgrade && mainData.otherData.money >= prestigeData.thingCost)
        {
            mainData.otherData.money -= prestigeData.thingCost;
            moneyText.text = mainData.otherData.money.ToString("F2");

            if (!prestigeData.wasBought)
            {
                mainData.otherData.lastIndex++;
                prestigeData.wasBought = true;
            }

            mainData.otherData.exp += prestigeData.giveExp;
            expText.text = mainData.otherData.exp.ToString();

            prestigeData.thingCost *= 0.3f;
            thingCostText.text = prestigeData.thingCost.ToString("F2");
        }
    }

    private void CanBuyLogic(PrestigeData prestigeData)
    {
        if(prestigeData.thingID <= mainData.otherData.lastIndex + 1) prestigeData.canUpgrade = true;
    }

    private void Update()
    {
        CanBuyLogic(mainData.phoneData);
        CanBuyLogic(mainData.PCData);
        CanBuyLogic(mainData.flatData);
    }

    public void UpgradePhone()
    {
        //CanBuyLogic(mainData.phoneData);
        UpgradeThing(mainData.phoneData, phoneCostText);
        UpdateUI(mainData.phoneData, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
    }

    public void UpgradePC()
    {
        CanBuyLogic(mainData.PCData);
        UpgradeThing(mainData.PCData, pcCostText);
        UpdateUI(mainData.PCData, pcText, pcCostText, pcImage, buyPcButtonImage);
    }

    public void UpgradeFlat()
    {
        CanBuyLogic(mainData.flatData);
        UpgradeThing(mainData.flatData, flatCostText);
        UpdateUI(mainData.flatData, flatText, flatCostText, flatImage, buyFlatButtonImage);
    }

    public void OpenUpgrdePanel()
    {
        upgradePanel.SetActive(true);
    }

    public void CloseUpgradePanel()
    {
        upgradePanel.SetActive(false);
    }
}