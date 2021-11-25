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
    [SerializeField] private GameObject lockOfAmethystMine;
    [SerializeField] private GameObject lockOfRubyMine;
    [SerializeField] private GameObject lockOfCopperMine;
    [SerializeField] private GameObject lockOfTinMine;
    [SerializeField] private GameObject lockOfSapphireMine;
    [SerializeField] private GameObject lockOfOnyxMine;
    [SerializeField] private GameObject lockOfEmeraldMine;

    private void Update()
    {
        if (mainData.ironMineData.isOpened) lockOfIronMine.SetActive(false);
        if (mainData.goldMineData.isOpened) lockOfGoldMine.SetActive(false);
        if (mainData.benitoiteMineData.isOpened) lockOfBenitoiteMine.SetActive(false);
        if (mainData.diamondMineData.isOpened) lockOfDiamondMine.SetActive(false);
        if (mainData.amethystMineData.isOpened) lockOfAmethystMine.SetActive(false);
        if (mainData.amethystMineData.isOpened) lockOfRubyMine.SetActive(false);
        if (mainData.copperMineData.isOpened) lockOfCopperMine.SetActive(false);
        if (mainData.copperMineData.isOpened) lockOfTinMine.SetActive(false);
        if (mainData.sapphireMineData.isOpened) lockOfSapphireMine.SetActive(false);
        if (mainData.sapphireMineData.isOpened) lockOfOnyxMine.SetActive(false);
        if (mainData.sapphireMineData.isOpened) lockOfEmeraldMine.SetActive(false);
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

    public void TryToOpenAmethystMine()
    {
        TryToOpenMine(mainData, mainData.amethystMineData, otherData);
        if (mainData.amethystMineData.isOpened) lockOfAmethystMine.SetActive(false);
    }

    public void TryToOpenRubyMine()
    {
        TryToOpenMine(mainData, mainData.rubyMineData, otherData);
        if (mainData.rubyMineData.isOpened) lockOfRubyMine.SetActive(false);
    }

    public void TryToOpenCopperMine()
    {
        TryToOpenMine(mainData, mainData.copperMineData, otherData);
        if (mainData.copperMineData.isOpened) lockOfCopperMine.SetActive(false);
    }

    public void TryToOpenTinMine()
    {
        TryToOpenMine(mainData, mainData.tinMineData, otherData);
        if (mainData.tinMineData.isOpened) lockOfTinMine.SetActive(false);
    }

    public void TryToOpenSapphireMine()
    {
        TryToOpenMine(mainData, mainData.sapphireMineData, otherData);
        if (mainData.sapphireMineData.isOpened) lockOfSapphireMine.SetActive(false);
    }

    public void TryToOpenOnyxMine()
    {
        TryToOpenMine(mainData, mainData.onyxMineData, otherData);
        if (mainData.onyxMineData.isOpened) lockOfOnyxMine.SetActive(false);
    }

    public void TryToOpenEmeraldMine()
    {
        TryToOpenMine(mainData, mainData.emeraldMineData, otherData);
        if (mainData.emeraldMineData.isOpened) lockOfEmeraldMine.SetActive(false);
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