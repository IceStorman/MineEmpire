using UnityEngine;
using UnityEngine.UI;

public class EarnResoursesMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private GameObject minePanel;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text benitoiteText;
    [SerializeField] private Text rubyText;
    [SerializeField] private Text emeraldText;
    [SerializeField] private Text diamondText;
    [SerializeField] private Text onyxText;
    [SerializeField] private Text sapphireText;
    [SerializeField] private Text tinText;
    [SerializeField] private Text copperText;
    [SerializeField] private Text amethystText;

    [SerializeField] private GameObject chooseOfClassicMine;
    [SerializeField] private GameObject chooseOfIronMine;
    [SerializeField] private GameObject chooseOfGoldMine;
    [SerializeField] private GameObject chooseOfBenitoiteMine;
    [SerializeField] private GameObject chooseOfDiamondMine;
    [SerializeField] private GameObject chooseOfAmethystMine;
    [SerializeField] private GameObject chooseOfRubyMine;
    [SerializeField] private GameObject chooseOfCopperMine;
    [SerializeField] private GameObject chooseOfTinMine;
    [SerializeField] private GameObject chooseOfSapphireMine;
    [SerializeField] private GameObject chooseOfOnyxMine;
    [SerializeField] private GameObject chooseOfEmeraldMine;

    [SerializeField] private int howManyOres = 12;

    private void Start()
    {
        minePanel.SetActive(true);
    }

    private void Update()
    {
        UpdateUI();
    }

    public void ClassicMineStart()
    {
        CloseMines();
        mainData.classicMineData.isItOpenedNow = true;
        CloseChoosen();
        chooseOfClassicMine.SetActive(true);
        ChangePerctentages(mainData.classicMineData);
    }

    public void IronMineStart()
    {
        if (mainData.ironMineData.isUnlocked)
        {
            CloseMines();
            mainData.ironMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfIronMine.SetActive(true);
            ChangePerctentages(mainData.ironMineData);
        }
    }

    public void GoldMineStart()
    {
        if (mainData.goldMineData.isUnlocked)
        {
            CloseMines();
            mainData.goldMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfGoldMine.SetActive(true);
            ChangePerctentages(mainData.goldMineData);
        }
    }

    public void CopperMineStart()
    {
        if (mainData.copperMineData.isUnlocked)
        {
            CloseMines();
            mainData.copperMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfCopperMine.SetActive(true);
            ChangePerctentages(mainData.copperMineData);
        }
    }

    public void TinMineStart()
    {
        if (mainData.tinMineData.isUnlocked)
        {
            CloseMines();
            mainData.tinMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfTinMine.SetActive(true);
            ChangePerctentages(mainData.tinMineData);
        }
    }

    public void BenitoiteMineStart()
    {
        if (mainData.benitoiteMineData.isUnlocked)
        {
            CloseMines();
            mainData.benitoiteMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfBenitoiteMine.SetActive(true);
            ChangePerctentages(mainData.benitoiteMineData);
        }
    }

    public void EmeraldMineStart()
    {
        if (mainData.emeraldMineData.isUnlocked)
        {
            CloseMines();
            mainData.emeraldMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfEmeraldMine.SetActive(true);
            ChangePerctentages(mainData.emeraldMineData);
        }
    }

    public void OnyxMineStart()
    {
        if (mainData.onyxMineData.isUnlocked)
        {
            CloseMines();
            mainData.onyxMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfOnyxMine.SetActive(true);
            ChangePerctentages(mainData.onyxMineData);
        }
    }

    public void RubyMineStart()
    {
        if (mainData.rubyMineData.isUnlocked)
        {
            CloseMines();
            mainData.rubyMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfRubyMine.SetActive(true);
            ChangePerctentages(mainData.rubyMineData);
        }
    }

    public void SapphireMineStart()
    {
        if (mainData.sapphireMineData.isUnlocked)
        {
            CloseMines();
            mainData.sapphireMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfSapphireMine.SetActive(true);
            ChangePerctentages(mainData.sapphireMineData);
        }
    }

    public void DiamondMineStart()
    {
        if (mainData.diamondMineData.isUnlocked)
        {
            CloseMines();
            mainData.diamondMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfDiamondMine.SetActive(true);
            ChangePerctentages(mainData.diamondMineData);
        }
    }

    public void AmethystMineStart()
    {
        if (mainData.amethystMineData.isUnlocked)
        {
            CloseMines();
            mainData.amethystMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfAmethystMine.SetActive(true);
            ChangePerctentages(mainData.amethystMineData);
        }
    }

    private void ChangePerctentages(MineData mineData)
    {
        mainData.stoneData.dropProcent = mineData.stonePercentage;
        mainData.ironData.dropProcent = mineData.ironPercentage;
        mainData.goldData.dropProcent = mineData.goldPercentage;
        mainData.copperData.dropProcent = mineData.copperPercentage;
        mainData.tinData.dropProcent = mineData.tinPercentage;
        mainData.benitoiteData.dropProcent = mineData.benitoitePercentage;
        mainData.emeraldData.dropProcent = mineData.emeraldPercentage;
        mainData.onyxData.dropProcent = mineData.onyxPercentage;
        mainData.rubyData.dropProcent = mineData.rubyPercentage;
        mainData.sapphireData.dropProcent = mineData.sapphirePercentage;
        mainData.diamondData.dropProcent = mineData.diamondPercentage;
        mainData.amethystData.dropProcent = mineData.amethystPercentage;
    }

    private void CloseMines()
    {
        mainData.classicMineData.isItOpenedNow = false;
        mainData.ironMineData.isItOpenedNow = false;
        mainData.goldMineData.isItOpenedNow = false;
        mainData.benitoiteMineData.isItOpenedNow = false;
        mainData.diamondMineData.isItOpenedNow = false;
        mainData.amethystMineData.isItOpenedNow = false;
        mainData.rubyMineData.isItOpenedNow = false;
        mainData.copperMineData.isItOpenedNow = false;
        mainData.tinMineData.isItOpenedNow = false;
        mainData.sapphireMineData.isItOpenedNow = false;
        mainData.onyxMineData.isItOpenedNow = false;
        mainData.emeraldMineData.isItOpenedNow = false;
    }

    private void CloseChoosen()
    {
        chooseOfClassicMine.SetActive(false);
        chooseOfIronMine.SetActive(false);
        chooseOfGoldMine.SetActive(false);
        chooseOfBenitoiteMine.SetActive(false);
        chooseOfDiamondMine.SetActive(false);
        chooseOfAmethystMine.SetActive(false);
        chooseOfRubyMine.SetActive(false);
        chooseOfCopperMine.SetActive(false);
        chooseOfTinMine.SetActive(false);
        chooseOfSapphireMine.SetActive(false);
        chooseOfOnyxMine.SetActive(false);
        chooseOfEmeraldMine.SetActive(false);
    }

    private void UpdateUI()
    {
        stoneText.text = mainData.stoneData.ore.ToString();
        ironText.text = mainData.ironData.ore.ToString();
        goldText.text = mainData.goldData.ore.ToString();
        copperText.text = mainData.copperData.ore.ToString();
        tinText.text = mainData.tinData.ore.ToString();
        benitoiteText.text = mainData.benitoiteData.ore.ToString();
        emeraldText.text = mainData.emeraldData.ore.ToString();
        onyxText.text = mainData.onyxData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        sapphireText.text = mainData.sapphireData.ore.ToString();
        diamondText.text = mainData.diamondData.ore.ToString();
        amethystText.text = mainData.amethystData.ore.ToString();
    }

    public void OnEarn(MainData mainData)
    {
        float[] oreDropPrecentageMassive = new float[12]
        {
            mainData.amethystData.dropProcent,
            mainData.diamondData.dropProcent,
            mainData.sapphireData.dropProcent,
            mainData.rubyData.dropProcent,
            mainData.onyxData.dropProcent,
            mainData.emeraldData.dropProcent,
            mainData.benitoiteData.dropProcent,
            mainData.tinData.dropProcent,
            mainData.copperData.dropProcent,
            mainData.goldData.dropProcent,
            mainData.ironData.dropProcent,
            mainData.stoneData.dropProcent,
        };
        bool[] isOpenedMines = new bool[12]
        {
            mainData.amethystMineData.isItOpenedNow,
            mainData.diamondMineData.isItOpenedNow,
            mainData.sapphireMineData.isItOpenedNow,
            mainData.rubyMineData.isItOpenedNow,
            mainData.onyxMineData.isItOpenedNow,
            mainData.emeraldMineData.isItOpenedNow,
            mainData.benitoiteMineData.isItOpenedNow,
            mainData.tinMineData.isItOpenedNow,
            mainData.copperMineData.isItOpenedNow,
            mainData.goldMineData.isItOpenedNow,
            mainData.ironMineData.isItOpenedNow,
            mainData.classicMineData.isItOpenedNow,
        };

        if (mainData.classicMineData.isItOpenedNow) EarnMechanic(mainData.stoneData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.ironMineData.isItOpenedNow) EarnMechanic(mainData.ironData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.goldMineData.isItOpenedNow) EarnMechanic(mainData.goldData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.copperMineData.isItOpenedNow) EarnMechanic(mainData.copperData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.tinMineData.isItOpenedNow) EarnMechanic(mainData.tinData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.benitoiteMineData.isItOpenedNow) EarnMechanic(mainData.benitoiteData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.emeraldMineData.isItOpenedNow) EarnMechanic(mainData.emeraldData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.onyxMineData.isItOpenedNow) EarnMechanic(mainData.onyxData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.rubyMineData.isItOpenedNow) EarnMechanic(mainData.rubyData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.sapphireMineData.isItOpenedNow) EarnMechanic(mainData.sapphireData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.diamondMineData.isItOpenedNow) EarnMechanic(mainData.diamondData, oreDropPrecentageMassive, isOpenedMines);
        if (mainData.amethystMineData.isItOpenedNow) EarnMechanic(mainData.amethystData, oreDropPrecentageMassive, isOpenedMines);
    }

    private void EarnMechanic(OreData oreData, float[] precentageOre, bool[] isOpened)
    {
        float rnd = Random.Range(0, 101);

        for (int i = -1; i <= howManyOres; i++)
        {
            if (i == 0 && precentageOre[i] > rnd && !isOpened[i]) { mainData.amethystData.ore++; break; }
            if (i == 1 && precentageOre[i] > rnd && !isOpened[i]) { mainData.diamondData.ore++; break; }
            if (i == 2 && precentageOre[i] > rnd && !isOpened[i]) { mainData.sapphireData.ore++; break; }
            if (i == 3 && precentageOre[i] > rnd && !isOpened[i]) { mainData.rubyData.ore++; break; }
            if (i == 4 && precentageOre[i] > rnd && !isOpened[i]) { mainData.onyxData.ore++; break; }
            if (i == 5 && precentageOre[i] > rnd && !isOpened[i]) { mainData.emeraldData.ore++; break; }
            if (i == 6 && precentageOre[i] > rnd && !isOpened[i]) { mainData.benitoiteData.ore++; break; }
            if (i == 7 && precentageOre[i] > rnd && !isOpened[i]) { mainData.tinData.ore++; break; }
            if (i == 8 && precentageOre[i] > rnd && !isOpened[i]) { mainData.copperData.ore++; break; }
            if (i == 9 && precentageOre[i] > rnd && !isOpened[i]) { mainData.goldData.ore++; break; }
            if (i == 10 && precentageOre[i] > rnd && !isOpened[i]) { mainData.ironData.ore++; break; }
            if (i == 11 && precentageOre[i] > rnd && !isOpened[i]) { mainData.stoneData.ore++; break; }
            if (i == 12) oreData.ore++;
        }
    }
}