using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PickaxesMechanics : MonoBehaviour
{
    [SerializeField] private GameObject pickaxesPanel;
    private bool isOpen = false;

    [SerializeField] private List<Text> pickaxesTextsList = new List<Text>(6);
    [SerializeField] private List<GameObject> pickaxesLocksList = new List<GameObject>(6);
    [SerializeField] private List<GameObject> pickaxesFramesList = new List<GameObject>(6);

    public MainData mainData;

    private void Start()
    {
        pickaxesPanel.SetActive(false);
    }

    private void Update()
    {
        UpdateLvlUI(mainData.pickaxesList);
    }

    private void UpdateLvlUI(List<PickaxeData> pickaxesList)
    {
        for(int i = 1; i < 6; i++)
        {
            if(mainData.otherData.lvl >= pickaxesList[i].prestigeLvl && !pickaxesList[i].isBought)
            {
                pickaxesTextsList[i].text = pickaxesList[i].prize.ToString();
                pickaxesTextsList[i].color = Color.green;
                pickaxesList[i].canBuy = true;
            }
        }
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
