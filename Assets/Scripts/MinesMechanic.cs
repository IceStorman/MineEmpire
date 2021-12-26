using UnityEngine;

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
        if (mainData.ironMineData.isUnlocked) lockOfIronMine.SetActive(false);
        if (mainData.goldMineData.isUnlocked) lockOfGoldMine.SetActive(false);
        if (mainData.benitoiteMineData.isUnlocked) lockOfBenitoiteMine.SetActive(false);
        if (mainData.diamondMineData.isUnlocked) lockOfDiamondMine.SetActive(false);
        if (mainData.amethystMineData.isUnlocked) lockOfAmethystMine.SetActive(false);
        if (mainData.rubyMineData.isUnlocked) lockOfRubyMine.SetActive(false);
        if (mainData.copperMineData.isUnlocked) lockOfCopperMine.SetActive(false);
        if (mainData.tinMineData.isUnlocked) lockOfTinMine.SetActive(false);
        if (mainData.sapphireMineData.isUnlocked) lockOfSapphireMine.SetActive(false);
        if (mainData.onyxMineData.isUnlocked) lockOfOnyxMine.SetActive(false);
        if (mainData.emeraldMineData.isUnlocked) lockOfEmeraldMine.SetActive(false);
    }

    public void TryToOpenClassicMine()
    {
        TryToOpenMine(mainData, mainData.classicMineData, otherData);
    }

    public void TryToOpenIronMine()
    {
        TryToOpenMine(mainData, mainData.ironMineData, otherData);
        if (mainData.ironMineData.isUnlocked) lockOfIronMine.SetActive(false);
    }

    public void TryToOpenGoldMine()
    {
        TryToOpenMine(mainData, mainData.goldMineData, otherData);
        if (mainData.goldMineData.isUnlocked) lockOfGoldMine.SetActive(false);
    }

    public void TryToOpenBenitoiteMine()
    {
        TryToOpenMine(mainData, mainData.benitoiteMineData, otherData);
        if (mainData.benitoiteMineData.isUnlocked) lockOfBenitoiteMine.SetActive(false);
    }

    public void TryToOpenDiamondMine()
    {
        TryToOpenMine(mainData, mainData.diamondMineData, otherData);
        if (mainData.diamondMineData.isUnlocked) lockOfDiamondMine.SetActive(false);
    }

    public void TryToOpenAmethystMine()
    {
        TryToOpenMine(mainData, mainData.amethystMineData, otherData);
        if (mainData.amethystMineData.isUnlocked) lockOfAmethystMine.SetActive(false);
    }

    public void TryToOpenRubyMine()
    {
        TryToOpenMine(mainData, mainData.rubyMineData, otherData);
        if (mainData.rubyMineData.isUnlocked) lockOfRubyMine.SetActive(false);
    }

    public void TryToOpenCopperMine()
    {
        TryToOpenMine(mainData, mainData.copperMineData, otherData);
        if (mainData.copperMineData.isUnlocked) lockOfCopperMine.SetActive(false);
    }

    public void TryToOpenTinMine()
    {
        TryToOpenMine(mainData, mainData.tinMineData, otherData);
        if (mainData.tinMineData.isUnlocked) lockOfTinMine.SetActive(false);
    }

    public void TryToOpenSapphireMine()
    {
        TryToOpenMine(mainData, mainData.sapphireMineData, otherData);
        if (mainData.sapphireMineData.isUnlocked) lockOfSapphireMine.SetActive(false);
    }

    public void TryToOpenOnyxMine()
    {
        TryToOpenMine(mainData, mainData.onyxMineData, otherData);
        if (mainData.onyxMineData.isUnlocked) lockOfOnyxMine.SetActive(false);
    }

    public void TryToOpenEmeraldMine()
    {
        TryToOpenMine(mainData, mainData.emeraldMineData, otherData);
        if (mainData.emeraldMineData.isUnlocked) lockOfEmeraldMine.SetActive(false);
    }

    private void TryToOpenMine(MainData mainData, MineData mineData, OtherData otherData)
    {
        if (!mineData.isUnlocked && mainData.otherData.money >= mineData.cost && otherData.lvl >= mineData.levelOfPrestige)
        {
            mainData.otherData.money -= mineData.cost;
            mineData.isUnlocked = true;
        }
    }
}