using UnityEngine;
using UnityEngine.UI;

public class InventoryMechanic : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPanel;
    private bool isOpen = false;

    public void Click()
    {
        if (!isOpen)
        {
            InventoryPanel.SetActive(true);
            isOpen = true;
        }
        else if (isOpen)
        {
            InventoryPanel.SetActive(false);
            isOpen = false;
        }
    }
}