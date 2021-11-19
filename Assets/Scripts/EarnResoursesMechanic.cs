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

    [SerializeField] private GameObject chooseOfClassicMine;
    [SerializeField] private GameObject chooseOfIronMine;
    [SerializeField] private GameObject chooseOfGoldMine;

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

    private void CloseMines()
    {
        classicMineOpened = false;
        ironMineOpened = false;
        goldMineOpened = false;
    }

    private void CloseChoosen()
    {
        chooseOfClassicMine.SetActive(false);
        chooseOfIronMine.SetActive(false);
        chooseOfGoldMine.SetActive(false);
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
            else if (mainData.classicMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
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
            else if (mainData.ironMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);

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
            else if (mainData.goldMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
        }
    }

    private void EarnResource(OreData oreData, Text resourceText)
    {
        oreData.ore++;
        resourceText.text = oreData.ore.ToString();
    }
}