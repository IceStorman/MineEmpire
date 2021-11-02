using UnityEngine;

public class PrestigeMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;
    [SerializeField] private GameObject upgradePanel;

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

    public void OpenUpgrdePanel()
    {
        upgradePanel.SetActive(true);
    }

    public void CloseUpgradePanel()
    {
        upgradePanel.SetActive(false);
    }
}
