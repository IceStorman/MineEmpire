using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementMechanic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool isOpened = false;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Text textPrefab;
    public List<int> moneysList = new List<int>(9);
    [SerializeField] Image checkerOn;
    [SerializeField] MainData mainData;
    private Button[] buttonsMass = new Button[9];

    private void Start()
    {
        SpawnPefabs();
        panel.SetActive(false);
    }

    private void Update()
    {
        if (buttonsMass[9])
        {
            for (int i = 0; i < 9; i++)
            {
                if (mainData.otherData.money <= moneysList[i] || mainData.achivementData.moneysAchivementList[i])
                {
                    buttonsMass[i].image = checkerOn;
                }
            }
        }
    }

    private void SpawnPefabs()
    {
        for (int i = 0; i < 9; i++)
        {
            Vector2 spawnPointButton = new Vector2(-493, 426 - (i * 12.5f));
            Button buttonClone = Instantiate(buttonPrefab, spawnPointButton, Quaternion.identity);
            buttonClone.transform.parent = GameObject.Find("AchivementPanel").transform;
            buttonsMass[i] = buttonClone;

            textPrefab.text = $"Earn {moneysList[i]} Money";
            Vector2 spawnPointText = new Vector2(-405, 420 - (i * 12.5f));
            Text textClone = Instantiate(textPrefab, spawnPointText, Quaternion.identity);
            textClone.transform.parent = GameObject.Find("AchivementPanel").transform;
        }
    }

    public void Click(Button button)
    {
        button.image = checkerOn;
    }

    public void OpenClose()
    {
        if (!isOpened)
        {
            panel.SetActive(true);
            isOpened = !isOpened;
        }
        else if (isOpened)
        {
            panel.SetActive(false);
            isOpened = !isOpened;
        }
    }
}