using UnityEngine;
using UnityEngine.UI;

public class PlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject plantPanel;

    private void Start()
    {
        plantPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Close();
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