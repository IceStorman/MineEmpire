using UnityEngine;
using UnityEngine.UI;

public class TutorialMechanic : MonoBehaviour
{
    [SerializeField] private GameObject tutorMine;
    [SerializeField] private GameObject tutorInventory;
    [SerializeField] private GameObject tutorPlant1;
    [SerializeField] private GameObject tutorPlant2;
    [SerializeField] private GameObject tutorPlant3;
    [SerializeField] private GameObject tutorPlant4;
    [SerializeField] private GameObject tutorPlant5;
    [SerializeField] private GameObject tutorExchange1;
    [SerializeField] private GameObject tutorExchange2;
    [SerializeField] private GameObject tutorExchange3;
    [SerializeField] private GameObject tutorPrestige1;
    [SerializeField] private GameObject tutorPrestige2;
    [SerializeField] private GameObject tutorPrestige3;
    [SerializeField] private GameObject tutorPrestige4;
    [SerializeField] private GameObject tutorPrestige5;
    [SerializeField] private GameObject tutorEndPanel;

    [SerializeField] private MainData mainData;

    [SerializeField] private bool isStarted = false;

    private int oldStone;
    private float oldStoneRec;
    private float oldMoney;

    private void Update()
    {
        if (mainData.phoneData.wasBought)
        {
            OnOff(tutorExchange3, false);
            OnOff(tutorPrestige1, false);
            OnOff(tutorPrestige2, false);
            OnOff(tutorPrestige3, false);
            OnOff(tutorPrestige4, true);
            OnOff(tutorPrestige5, true);
            tutorEndPanel.SetActive(true);
        }
        else if (isStarted && oldMoney < mainData.otherData.money - 200)
        {
            OnOff(tutorPlant4, false);
            OnOff(tutorPlant5, false);
            OnOff(tutorExchange1, false);
            OnOff(tutorExchange2, false);
            OnOff(tutorExchange3, true);
            OnOff(tutorPrestige1, true);
            OnOff(tutorPrestige2, true);
            OnOff(tutorPrestige3, true);
        }
        else if (isStarted && oldStoneRec < mainData.stoneData.recycleOre - 100)
        {
            OnOff(tutorPlant1, false);
            OnOff(tutorPlant2, false);
            OnOff(tutorPlant3, false);
            OnOff(tutorPlant4, true);
            OnOff(tutorPlant5, true);
            OnOff(tutorExchange1, true);
            OnOff(tutorExchange2, true);
        }
        else if (isStarted && oldStone < mainData.stoneData.ore - 200)
        {
            OnOff(tutorInventory, false);
            OnOff(tutorPlant1, true);
            OnOff(tutorPlant2, true);
            OnOff(tutorPlant3, true);
        }
        else if (isStarted && oldStone < mainData.stoneData.ore - 20)
        {
            OnOff(tutorMine, false);
            OnOff(tutorInventory, true);
        }
    }

    public void TutorialStarted()
    {
        isStarted = true;
        OnOff(tutorMine, true);
        oldMoney = mainData.otherData.money;
        oldStoneRec = mainData.stoneData.recycleOre;
        oldStone = mainData.stoneData.ore;
    }

    public void OnOff(GameObject image, bool on)
    {
        if (on) image.SetActive(true);
        else image.SetActive(false);
    }

    public void Close()
    {
        tutorEndPanel.SetActive(false);
    }
}