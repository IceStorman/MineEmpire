using UnityEngine;
using UnityEngine.UI;

public class PlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject plantPanel;

    private void Start()
    {
        plantPanel.SetActive(false);
    }
    public void Open()
    {
        plantPanel.SetActive(true);
    }

    public void Close()
    {
        plantPanel.SetActive(false);
    }
}
