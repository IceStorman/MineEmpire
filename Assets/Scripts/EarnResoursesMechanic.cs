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

    /*[SerializeField] private bool classicMineOpened = true;
    [SerializeField] private bool ironMineOpened = false;
    [SerializeField] private bool goldMineOpened = false;
    [SerializeField] private bool benitoiteMineOpened = false;
    [SerializeField] private bool diamondMineOpened = false;
    [SerializeField] private bool amethystMineOpened = false;
    [SerializeField] private bool rubyMineOpened = false;
    [SerializeField] private bool copperMineOpened = false;
    [SerializeField] private bool tinMineOpened = false;
    [SerializeField] private bool sapphireMineOpened = false;
    [SerializeField] private bool onyxMineOpened = false;
    [SerializeField] private bool emeraldMineOpened = false;*/

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
    [SerializeField] private OreData oreData;

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
    }

    public void IronMineStart()
    {
        if (mainData.ironMineData.isUnlocked)
        {
            CloseMines();
            mainData.ironMineData.isItOpenedNow = true;
            CloseChoosen();
            chooseOfIronMine.SetActive(true);
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
        }
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
        benitoiteText.text = mainData.benitoiteData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        emeraldText.text = mainData.emeraldData.ore.ToString();
        diamondText.text = mainData.diamondData.ore.ToString();
        onyxText.text = mainData.onyxData.ore.ToString();
        sapphireText.text = mainData.sapphireData.ore.ToString();
        tinText.text = mainData.tinData.ore.ToString();
        copperText.text = mainData.copperData.ore.ToString();
        amethystText.text = mainData.amethystData.ore.ToString();
    }

    public void OnEarn()
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

        if (mainData.classicMineData.isItOpenedNow) EarnMechanic(mainData.classicMineData, mainData.stoneData, oreDropPrecentageMassive, 80);
        if (mainData.ironMineData.isItOpenedNow) EarnMechanic(mainData.ironMineData, mainData.ironData, oreDropPrecentageMassive, 50);
        if (mainData.goldMineData.isItOpenedNow) EarnMechanic(mainData.goldMineData, mainData.goldData, oreDropPrecentageMassive, 25);
        if (mainData.benitoiteMineData.isItOpenedNow) EarnMechanic(mainData.benitoiteMineData, mainData.benitoiteData, oreDropPrecentageMassive, 15);
        if (mainData.rubyMineData.isItOpenedNow) EarnMechanic(mainData.rubyMineData, mainData.rubyData, oreDropPrecentageMassive, 14);
        if (mainData.emeraldMineData.isItOpenedNow) EarnMechanic(mainData.emeraldMineData, mainData.emeraldData, oreDropPrecentageMassive, 13);
        if (mainData.diamondMineData.isItOpenedNow) EarnMechanic(mainData.diamondMineData, mainData.diamondData, oreDropPrecentageMassive, 12);
        if (mainData.onyxMineData.isItOpenedNow) EarnMechanic(mainData.onyxMineData, mainData.onyxData, oreDropPrecentageMassive, 11);
        if (mainData.sapphireMineData.isItOpenedNow) EarnMechanic(mainData.sapphireMineData, mainData.sapphireData, oreDropPrecentageMassive, 10);
        if (mainData.tinMineData.isItOpenedNow) EarnMechanic(mainData.tinMineData, mainData.tinData, oreDropPrecentageMassive, 9);
        if (mainData.copperMineData.isItOpenedNow) EarnMechanic(mainData.copperMineData, mainData.copperData, oreDropPrecentageMassive, 8);
        if (mainData.amethystMineData.isItOpenedNow) EarnMechanic(mainData.amethystMineData, mainData.amethystData, oreDropPrecentageMassive, 7);
    }

    private void EarnMechanic(MineData mineData, OreData oreData, float[] precentageOre, int chanceOfOre)
    {
        float rnd = Random.Range(0, 101);

        for (int i = -1; i <= howManyOres; i++)
        {
            if (chanceOfOre > rnd) { oreData.ore++; break; }
            if (i == 0 && precentageOre[i] > rnd) { mainData.amethystData.ore++; break; }
            if (i == 1 && precentageOre[i] > rnd) { mainData.diamondData.ore++; break; }
            if (i == 2 && precentageOre[i] > rnd) { mainData.sapphireData.ore++; break; }
            if (i == 3 && precentageOre[i] > rnd) { mainData.rubyData.ore++; break; }
            if (i == 4 && precentageOre[i] > rnd) { mainData.onyxData.ore++; break; }
            if (i == 5 && precentageOre[i] > rnd) { mainData.emeraldData.ore++; break; }
            if (i == 6 && precentageOre[i] > rnd) { mainData.benitoiteData.ore++; break; }
            if (i == 7 && precentageOre[i] > rnd) { mainData.tinData.ore++; break; }
            if (i == 8 && precentageOre[i] > rnd) { mainData.copperData.ore++; break; }
            if (i == 9 && precentageOre[i] > rnd) { mainData.goldData.ore++; break; }
            if (i == 10 && precentageOre[i] > rnd) { mainData.ironData.ore++; break; }
            if (i == 11 && precentageOre[i] > rnd) { mainData.stoneData.ore++; break; }
            if (i == 12) oreData.ore++;
        }
    }
}