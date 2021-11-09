using UnityEngine;
using UnityEngine.UI;

public class PrestigeMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;
    [SerializeField] private GameObject upgradePanel;

    [SerializeField] private Text flatText;
    [SerializeField] private Text flatCostText;

    [SerializeField] private Image thingImage;
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

    private void UpgradeThing(OtherData otherData, PrestigeData prestigeData)
    {
        if(prestigeData.canUpgrade && otherData.money >= prestigeData.thingCost)
        {
            otherData.money -= prestigeData.thingCost;

            if (!prestigeData.wasBought)
            {
                otherData.lastIndex++;
                prestigeData.wasBought = true;
            }

            otherData.exp += prestigeData.giveExp;
            prestigeData.thingCost *= 0.3f;
        }
    }

    private void CanBuyLogic(OtherData otherData, PrestigeData prestigeData, 
        Text thingText, Text thingCostText, Image thingImage, Image buyButtonImage)
    {
        if(prestigeData.thingID == otherData.lastIndex + 1)
        {
            buyButtonImage.sprite = prestigeData.unlockButtonSprite;
            thingText.text = prestigeData.thingText;
            thingCostText.text = prestigeData.thingCost.ToString("F2");
            prestigeData.canUpgrade = true;
        }
    }

    public void UpgradePhone()
    {

    }

    public void UpgradePC()
    {

    }

    public void UpgradeFlat()
    {

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
