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

    [SerializeField] private bool classicMineOpened = true;
    [SerializeField] private bool ironMineOpened = false;
    [SerializeField] private bool goldMineOpened = false;
    [SerializeField] private bool benitoiteMineOpened = false;
    [SerializeField] private bool diamondMineOpened = false;
    [SerializeField] private bool amethystMineOpened = false;
    [SerializeField] private bool rubyMineOpened = false;
    [SerializeField] private bool copperMineOpened = false;
    [SerializeField] private bool tinMineOpened = false;

    [SerializeField] private GameObject chooseOfClassicMine;
    [SerializeField] private GameObject chooseOfIronMine;
    [SerializeField] private GameObject chooseOfGoldMine;
    [SerializeField] private GameObject chooseOfBenitoiteMine;
    [SerializeField] private GameObject chooseOfDiamondMine;
    [SerializeField] private GameObject chooseOfAmethystMine;
    [SerializeField] private GameObject chooseOfRubyMine;
    [SerializeField] private GameObject chooseOfCopperMine;
    [SerializeField] private GameObject chooseOfTinMine;

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
        classicMineOpened = true;
        CloseChoosen();
        chooseOfClassicMine.SetActive(true);
    }

    public void IronMineStart()
    {
        if (mainData.ironMineData.isOpened)
        {
            CloseChoosen();
            chooseOfIronMine.SetActive(true);
            CloseMines();
            ironMineOpened = true;
        }
    }

    public void GoldMineStart()
    {
        if (mainData.goldMineData.isOpened)
        {
            CloseMines();
            goldMineOpened = true;
            CloseChoosen();
            chooseOfGoldMine.SetActive(true);
        }
    }

    public void BenitoiteMineStart()
    {
        if (mainData.benitoiteMineData.isOpened)
        {
            CloseMines();
            benitoiteMineOpened = true;
            CloseChoosen();
            chooseOfBenitoiteMine.SetActive(true);
        }
    }

    public void DiamondMineStart()
    {
        if (mainData.diamondMineData.isOpened)
        {
            CloseMines();
            diamondMineOpened = true;
            CloseChoosen();
            chooseOfDiamondMine.SetActive(true);
        }
    }

    public void AmethystMineStart()
    {
        if (mainData.amethystMineData.isOpened)
        {
            CloseMines();
            amethystMineOpened = true;
            CloseChoosen();
            chooseOfAmethystMine.SetActive(true);
        }
    }

    public void RubyMineStart()
    {
        if (mainData.rubyMineData.isOpened)
        {
            CloseMines();
            rubyMineOpened = true;
            CloseChoosen();
            chooseOfRubyMine.SetActive(true);
        }
    }

    public void CopperMineStart()
    {
        if (mainData.copperMineData.isOpened)
        {
            CloseMines();
            copperMineOpened = true;
            CloseChoosen();
            chooseOfCopperMine.SetActive(true);
        }
    }

    public void TinMineStart()
    {
        if (mainData.tinMineData.isOpened)
        {
            CloseMines();
            tinMineOpened = true;
            CloseChoosen();
            chooseOfTinMine.SetActive(true);
        }
    }

    private void CloseMines()
    {
        classicMineOpened = false;
        ironMineOpened = false;
        goldMineOpened = false;
        benitoiteMineOpened = false;
        diamondMineOpened = false;
        amethystMineOpened = false;
        rubyMineOpened = false;
        copperMineOpened = false;
        tinMineOpened = false;
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

    public void EarnMechanic()
    {
        float rnd = Random.Range(0, 101);
        if (classicMineOpened)
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
    }

    private void EarnResource(OreData oreData, Text resourceText)
    {
        oreData.ore++;
    }
}