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

    [SerializeField] private GameObject chooseOfClassicMine;
    [SerializeField] private GameObject chooseOfIronMine;
    [SerializeField] private GameObject chooseOfGoldMine;
    [SerializeField] private GameObject chooseOfBenitoiteMine;
    [SerializeField] private GameObject chooseOfDiamondMine;

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

    private void CloseMines()
    {
        classicMineOpened = false;
        ironMineOpened = false;
        goldMineOpened = false;
        benitoiteMineOpened = false;
        diamondMineOpened = false;
    }

    private void CloseChoosen()
    {
        chooseOfClassicMine.SetActive(false);
        chooseOfIronMine.SetActive(false);
        chooseOfGoldMine.SetActive(false);
        chooseOfBenitoiteMine.SetActive(false);
        chooseOfDiamondMine.SetActive(false);
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
        int rnd = Random.Range(0, 1001);
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
    }

    private void EarnResource(OreData oreData, Text resourceText)
    {
        oreData.ore++;
    }
}