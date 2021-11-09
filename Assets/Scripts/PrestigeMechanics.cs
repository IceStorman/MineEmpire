using UnityEngine;

public class PrestigeMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;
    [SerializeField] private GameObject upgradePanel;

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
