using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartPlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject standartPlantPanel;

    private void Start()
    {
        standartPlantPanel.SetActive(false);
    }
    public void Open()
    {
        standartPlantPanel.SetActive(true);
    }

    public void Close()
    {
        standartPlantPanel.SetActive(false);
    }
}
