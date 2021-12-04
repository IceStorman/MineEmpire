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

    /*private MineData[] dataMassive = new MineData[]
    {
        MainData.stoneData
    };*/

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

    /*private void EarnResource(OreData oreData, Text resourceText, float rnd, int i)
    {
        if (resourceText == stoneText && )
    }*/

    public void OnEarn()
    {
        if (mainData.classicMineData.isItOpenedNow) EarnMechanic(mainData.classicMineData, mainData.stoneData);
        if (mainData.ironMineData.isItOpenedNow) EarnMechanic(mainData.ironMineData, mainData.ironData);
        if (mainData.goldMineData.isItOpenedNow) EarnMechanic(mainData.goldMineData, mainData.goldData);
        if (mainData.benitoiteMineData.isItOpenedNow) EarnMechanic(mainData.benitoiteMineData, mainData.benitoiteData);
        if (mainData.rubyMineData.isItOpenedNow) EarnMechanic(mainData.rubyMineData, mainData.rubyData);
        if (mainData.emeraldMineData.isItOpenedNow) EarnMechanic(mainData.emeraldMineData, mainData.emeraldData);
        if (mainData.diamondMineData.isItOpenedNow) EarnMechanic(mainData.diamondMineData, mainData.diamondData);
        if (mainData.onyxMineData.isItOpenedNow) EarnMechanic(mainData.onyxMineData, mainData.onyxData);
        if (mainData.sapphireMineData.isItOpenedNow) EarnMechanic(mainData.sapphireMineData, mainData.sapphireData);
        if (mainData.tinMineData.isItOpenedNow) EarnMechanic(mainData.tinMineData, mainData.tinData);
        if (mainData.copperMineData.isItOpenedNow) EarnMechanic(mainData.copperMineData, mainData.copperData);
        if (mainData.amethystMineData.isItOpenedNow) EarnMechanic(mainData.amethystMineData, mainData.amethystData);
    }

    private void Check()
    {

    }

    private void EarnMechanic(MineData mineData, OreData oreData)
    {
        float rnd = Random.Range(0, 101);
        
        for (int i = 0; i <= howManyOres; i++)
        {
            if (i == 0 && mineData.stoneDropPrecentage >= rnd && !mainData.classicMineData.isItOpenedNow) { mainData.stoneData.ore++; break; }
            else if (i == 1 && mineData.ironDropPrecentage >= rnd && !mainData.ironMineData.isItOpenedNow) { mainData.ironData.ore++; break; }
            else if (i == 2 && mineData.goldDropPrecentage >= rnd && !mainData.goldMineData.isItOpenedNow) { mainData.goldData.ore++; break; }
            else if (i == 3 && mineData.benitoiteDropPrecentage >= rnd && !mainData.benitoiteMineData.isItOpenedNow) { mainData.benitoiteData.ore++; break; }
            else if (i == 4 && mineData.rubyDropPrecentage >= rnd && !mainData.rubyMineData.isItOpenedNow) { mainData.rubyData.ore++; break; }
            else if (i == 5 && mineData.emeraldDropPrecentage >= rnd && !mainData.emeraldMineData.isItOpenedNow) { mainData.emeraldData.ore++; break; }
            else if (i == 6 && mineData.diamondDropPrecentage >= rnd && !mainData.diamondMineData.isItOpenedNow) { mainData.diamondData.ore++; break; }
            else if (i == 7 && mineData.onyxDropPrecentage >= rnd && !mainData.onyxMineData.isItOpenedNow) { mainData.onyxData.ore++; break; }
            else if (i == 8 && mineData.sapphireDropPrecentage >= rnd && !mainData.sapphireMineData.isItOpenedNow) { mainData.sapphireData.ore++; break; }
            else if (i == 9 && mineData.tinDropPrecentage >= rnd && !mainData.tinMineData.isItOpenedNow) { mainData.tinData.ore++; break; }
            else if (i == 10 && mineData.copperDropPrecentage >= rnd && !mainData.copperMineData.isItOpenedNow) { mainData.copperData.ore++; break; }
            else if (i == 11 && mineData.amethystDropPrecentage >= rnd && !mainData.amethystMineData.isItOpenedNow) { mainData.amethystData.ore++; break; }
            else if (i == 12) oreData.ore++;

            //if (mainData.classicMineData.isItOpenedNow) EarnResource(mainData.stoneData, stoneText, rnd, i);
        }


        /*if (classicMineOpened)
        {
            if (mainData.classicMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.classicMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.classicMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.classicMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.classicMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.classicMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.diamondData, diamondText);
            else if (mainData.classicMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.classicMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.classicMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.classicMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else EarnResource(mainData.stoneData, stoneText);
        }

        else if (ironMineOpened)
        {
            if (mainData.ironMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.ironMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.ironMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.ironMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.ironMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.ironMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.diamondData, diamondText);
            else if (mainData.ironMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.ironMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.ironMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.ironMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.ironMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else EarnResource(mainData.ironData, ironText);

        }

        else if (goldMineOpened)
        {
            if (mainData.goldMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.goldMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.goldMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.goldMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.goldMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.goldMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.diamondData, diamondText);
            else if (mainData.goldMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.goldMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.goldMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.goldMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.goldMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else EarnResource(mainData.goldData, goldText);
        }

        else if (benitoiteMineOpened)
        {
            if (mainData.benitoiteMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.benitoiteMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.benitoiteMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.benitoiteMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.benitoiteMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.benitoiteMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.diamondData, diamondText);
            else if (mainData.benitoiteMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.benitoiteMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.benitoiteMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.benitoiteMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.benitoiteMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else EarnResource(mainData.benitoiteData, benitoiteText);
        }

        else if (diamondMineOpened)
        {
            if (mainData.diamondMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.diamondMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.diamondMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.diamondMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.diamondMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.diamondMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.diamondMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.diamondMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.diamondMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.diamondMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.diamondMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else mainData.diamondData.ore++;
        }

        else if (amethystMineOpened)
        {
            if (mainData.amethystMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.amethystMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.amethystMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.amethystMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.amethystMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.amethystMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.amethystMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.amethystMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.amethystMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.amethystMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.amethystMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.amethystMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
        }

        else if (rubyMineOpened)
        {
            if (mainData.rubyMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.rubyMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.rubyMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.rubyMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.rubyMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.rubyMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.rubyMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.rubyMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.rubyMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.rubyMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.rubyMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.rubyMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
        }

        else if (copperMineOpened)
        {
            if (mainData.copperMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.copperMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.copperMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.copperMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.copperMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.copperMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.copperMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.copperMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.copperMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.copperMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.copperMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.copperMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
        }

        else if (tinMineOpened)
        {
            if (mainData.tinMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.tinMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.tinMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.tinMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.tinMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.tinMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.tinMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.tinMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.tinMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.tinMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.tinMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.tinMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
        }

        else if (sapphireMineOpened)
        {
            if (mainData.sapphireMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.sapphireMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.sapphireMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.sapphireMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.sapphireMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.sapphireMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.sapphireMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.sapphireMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.sapphireMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.sapphireMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.sapphireMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.sapphireMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
        }

        else if (onyxMineOpened)
        {
            if (mainData.onyxMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.onyxMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.onyxMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.onyxMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.onyxMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.onyxMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
            else if (mainData.onyxMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.onyxMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.onyxMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.onyxMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.onyxMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.onyxMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
        }

        else if (emeraldMineOpened)
        {
            if (mainData.emeraldMineData.amethysDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.emeraldMineData.tinDropPrecentage >= rnd) EarnResource(mainData.tinData, tinText);
            else if (mainData.emeraldMineData.sapphireDropPrecentage >= rnd) EarnResource(mainData.sapphireData, sapphireText);
            else if (mainData.emeraldMineData.copperDropPrecentage >= rnd) EarnResource(mainData.copperData, copperText);
            else if (mainData.emeraldMineData.onyxDropPrecentage >= rnd) EarnResource(mainData.onyxData, onyxText);
            else if (mainData.emeraldMineData.diamondDropPrecentage >= rnd) EarnResource(mainData.amethystData, amethystText);
            else if (mainData.emeraldMineData.rubyDropPrecentage >= rnd) EarnResource(mainData.rubyData, rubyText);
            else if (mainData.emeraldMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
            else if (mainData.emeraldMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.emeraldMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.emeraldMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.emeraldMineData.emeraldDropPrecentage >= rnd) EarnResource(mainData.emeraldData, emeraldText);
        }*/
    }
}