using UnityEngine;
using UnityEngine.UI;

public class MinesMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;
    [SerializeField] private OtherData otherData;

    [SerializeField] private GameObject lockOfClassicMine;
    [SerializeField] private GameObject lockOfIronMine;
    [SerializeField] private GameObject lockOfGoldMine;
    [SerializeField] private GameObject lockOfBenitoiteMine;
    [SerializeField] private GameObject lockOfDiamondMine;

    private void Update()
    {
        if (mainData.ironMineData.isOpened) lockOfIronMine.SetActive(false);
        if (mainData.goldMineData.isOpened) lockOfGoldMine.SetActive(false);
        if (mainData.benitoiteMineData.isOpened) lockOfBenitoiteMine.SetActive(false);
        if (mainData.diamondMineData.isOpened) lockOfDiamondMine.SetActive(false);
    }

    public void TryToOpenClassicMine()
    {
        TryToOpenMine(mainData, mainData.classicMineData, otherData);
    }

    public void TryToOpenIronMine()
    {
        TryToOpenMine(mainData, mainData.ironMineData, otherData);
        if (mainData.ironMineData.isOpened) lockOfIronMine.SetActive(false);
    }

    public void TryToOpenGoldMine()
    {
        TryToOpenMine(mainData, mainData.goldMineData, otherData);
        if (mainData.goldMineData.isOpened) lockOfGoldMine.SetActive(false);
    }

    public void TryToOpenBenitoiteMine()
    {
        TryToOpenMine(mainData, mainData.benitoiteMineData, otherData);
        if (mainData.benitoiteMineData.isOpened) lockOfBenitoiteMine.SetActive(false);
    }

    public void TryToOpenDiamondMine()
    {
        TryToOpenMine(mainData, mainData.diamondMineData, otherData);
        if (mainData.diamondMineData.isOpened) lockOfDiamondMine.SetActive(false);
    }

    private void TryToOpenMine(MainData mainData, MineData mineData, OtherData otherData)
    {
        if (!mineData.isOpened && mainData.otherData.money >= mineData.cost && otherData.lvl >= mineData.levelOfPrestige)
        {
            mainData.otherData.money -= mineData.cost;
            mineData.isOpened = true;
        }
    }
}