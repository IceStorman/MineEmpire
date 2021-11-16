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
    }

    public void EarnMechanic()
    {
        int rnd = Random.Range(0, 101);
        if (classicMineOpened)
        {
            if (mainData.classicMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.classicMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
            else if (mainData.classicMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.classicMineData.benitoiteDropPrecentage >= rnd) EarnResource(mainData.benitoiteData, benitoiteText);
        }

        else if (ironMineOpened)
        {
            if (mainData.ironMineData.goldDropPrecentage >= rnd) EarnResource(mainData.goldData, goldText);
            else if (mainData.ironMineData.stoneDropPrecentage >= rnd) EarnResource(mainData.stoneData, stoneText);
            else if (mainData.ironMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);

        }

        else if (goldMineOpened)
        {
            if (mainData.goldMineData.ironDropPrecentage >= rnd) EarnResource(mainData.ironData, ironText);
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