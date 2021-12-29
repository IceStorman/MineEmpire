using UnityEngine;

public class PickaxesMechanics : MonoBehaviour
{
    [SerializeField] private GameObject pickaxesPanel;
    private bool isOpen = false;

    private void Start()
    {
        pickaxesPanel.SetActive(false);
    }

    public void OpenOrClosePanel()
    {
        if (!isOpen)
        {
            pickaxesPanel.SetActive(true);
            isOpen = !isOpen;
        }
        else
        {
            pickaxesPanel.SetActive(false);
            isOpen = !isOpen;
        }
    }
}
