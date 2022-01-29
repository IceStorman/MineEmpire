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
        UpdateLvl(mainData.pickaxesList);
        UpdateTextUI();
        UpdateLocksAndFramesUI();
    }

    private void UpdateLvl(List<PickaxeData> pickaxesList)
    {
        for(int i = 1; i < 6; i++)
        {
            if(mainData.otherData.lvl >= pickaxesList[i].prestigeLvl && !pickaxesList[i].isBought)
            {
                pickaxesList[i].canBuy = true;
            }
        }
    }

    public void HPLogic()
    {
        for(int i = 1; i < 6; i++)
        {
            if (mainData.pickaxesList[i].isPicked)
            {
                mainData.pickaxesList[i].hp--;

                if(mainData.pickaxesList[i].hp <= 0)
                {
                    mainData.pickaxesList[i].isBought = false;
                    mainData.pickaxesList[i].isPicked = false;
                    mainData.pickaxesList[0].isPicked = true;
                    mainData.otherData.amountProductionPerClick = 1;
                }
            }
        }
    }

    public void PickLogic(PickaxeData pickaxeData)
    {
        if (pickaxeData.isBought)
        {
            TurnOffAllFrames();
            pickaxeData.isPicked = true;
            UpdateLocksAndFramesUI();
        }

        if (pickaxeData.isPicked)
        {
            mainData.otherData.amountProductionPerClick = pickaxeData.amountProductionPerClick;
        }
    }

    public void BuyLogic(PickaxeData pickaxeData)
    {
        if(pickaxeData.canBuy && !pickaxeData.isBought && mainData.otherData.money >= pickaxeData.prize)
        {
            mainData.otherData.money -= pickaxeData.prize;
            pickaxeData.hp = pickaxeData.defaultHP;
            pickaxeData.isBought = true;
            UpdateTextUI();
        }
    }

    private void UpdateTextUI()
    {
        for (int i = 1; i < 6; i++)
        {
            if (mainData.pickaxesList[i].isBought)
            {
                pickaxesTextsList[i].text = $"HP: {mainData.pickaxesList[i].hp}";
                pickaxesTextsList[i].color = Color.red;
            }

            if (mainData.otherData.lvl >= mainData.pickaxesList[i].prestigeLvl 
                && !mainData.pickaxesList[i].isBought)
            {
                pickaxesTextsList[i].text = $"{mainData.pickaxesList[i].prize}$";
                pickaxesTextsList[i].color = Color.green;
            }
        }

    }

    private void UpdateLocksAndFramesUI()
    {
        for(int i = 0; i < 6; i++)
        {
            if (mainData.pickaxesList[i].isBought)
            {
                pickaxesLocksList[i].SetActive(false);
            }
            else
            {
                pickaxesLocksList[i].SetActive(true);
            }

            if (mainData.pickaxesList[i].isPicked)
            {
                pickaxesFramesList[i].SetActive(true);
            }
            else
            {
                pickaxesFramesList[i].SetActive(false);
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

    private void TurnOffAllFrames()
    {
        for(int i = 0; i < 6; i++)
        {
            mainData.pickaxesList[i].isPicked = false;
        }
    }
}
