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

    [SerializeField] private Text phoneCostText;
    [SerializeField] private Text phoneText;
    [SerializeField] private Image phoneImage;
    [SerializeField] private Image buyPhoneButtonImage;

    [SerializeField] private Text pcCostText;
    [SerializeField] private Text pcText;
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
    }

    public void OpenPanel()
    {
        prestigePanel.SetActive(true);
    }

    public void ClosePanel()
    {
        prestigePanel.SetActive(false);
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

    private void CanBuyLogic(PrestigeData prestigeData, 
        Text thingText, Text thingCostText, Image thingImage, Image buyButtonImage)
    {
        if(prestigeData.thingID <= mainData.otherData.lastIndex + 1)
        {
            buyButtonImage.sprite = prestigeData.unlockButtonSprite;
            thingImage.sprite = prestigeData.unlockThingSprite;
            thingText.text = prestigeData.thingText;
            thingCostText.text = prestigeData.thingCost.ToString("F2");
            prestigeData.canUpgrade = true;
        }
    }

    public void UpgradePhone()
    {
        CanBuyLogic(mainData.phoneData, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpgradeThing(mainData.phoneData, phoneCostText);
    }

    public void UpgradePC()
    {
        CanBuyLogic(mainData.PCData, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpgradeThing(mainData.PCData, pcCostText);
    }

    public void UpgradeFlat()
    {
        CanBuyLogic(mainData.flatData, flatText, flatCostText, flatImage, buyFlatButtonImage);
        UpgradeThing(mainData.flatData, flatCostText);
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