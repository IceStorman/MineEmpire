using UnityEngine;
using UnityEngine.UI;

public class EarnResoursesMechanic : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    [SerializeField] private GameObject minePanel;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;

    private void Start()
    {
        minePanel.SetActive(true);
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        stoneText.text = mainData.stoneData.ore.ToString();
        ironText.text = mainData.ironData.ore.ToString();
        goldText.text = mainData.goldData.ore.ToString();
    }

    public void EarnMechanic()
    {
        int rnd = Random.Range(0, 101);
        if (mainData.goldData.dropProcent >= rnd) EarnResource(mainData.goldData, goldText);
        else if (mainData.ironData.dropProcent >= rnd) EarnResource(mainData.ironData, ironText);
        else if (mainData.stoneData.dropProcent >= rnd) EarnResource(mainData.stoneData, stoneText);
    }

    private void EarnResource(OreData oreData, Text resourceText)
    {
        oreData.ore++;
        resourceText.text = oreData.ore.ToString();
    }
}