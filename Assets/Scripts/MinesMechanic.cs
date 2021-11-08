using UnityEngine;
using UnityEngine.UI;

public class MinesMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private GameObject lockOfClassicMine;
    [SerializeField] private GameObject lockOfIronMine;
    [SerializeField] private GameObject lockOfGoldMine;

    private void Update()
    {
        if (mainData.ironMineData.isOpened) lockOfIronMine.SetActive(false);
        if (mainData.goldMineData.isOpened) lockOfGoldMine.SetActive(false);
    }

    public void TryToOpenClassicMine()
    {
        TryToOpenMine(mainData, mainData.classicMineData);
    }

    public void TryToOpenIronMine()
    {
        TryToOpenMine(mainData, mainData.ironMineData);
        if (mainData.ironMineData.isOpened) lockOfIronMine.SetActive(false);
    }

    public void TryToOpenGoldMine()
    {
        TryToOpenMine(mainData, mainData.goldMineData);
        if (mainData.goldMineData.isOpened) lockOfGoldMine.SetActive(false);
    }

    private void TryToOpenMine(MainData mainData, MineData mineData)
    {
        if (!mineData.isOpened && mainData.otherData.money >= mineData.cost)
        {
            mainData.otherData.money -= mineData.cost;
            mineData.isOpened = true;
        }
    }
}