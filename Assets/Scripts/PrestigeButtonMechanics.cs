using UnityEngine;

public class PrestigeButtonMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;

    private void Start()
    {
        prestigePanel.SetActive(false);
    }

    public void OpenPanel()
    {
        prestigePanel.SetActive(true);
    }

    public void ClosePanel()
    {
        prestigePanel.SetActive(false);
    }
}
