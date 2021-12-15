using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementMechanic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool isOpened = false;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Text textPrefab;
    public List<int> moneysList = new List<int>();
    [SerializeField] Image checkerOn;
    [SerializeField] MainData mainData;

    void Start()
    {
        SpawnPefabs();
        panel.SetActive(false);
    }

    public void Update()
    {
        /*for (int i = 0; i < moneysList.Count; i++)
        {
            if (mainData.otherData.money >= moneysList[i] || mainData.achivementData.moneysAchivementList[i]) { return; }
        }*/
    }

    void SpawnPefabs()
    {
        for (int i = 0; i < 9; i++)
        {
            Vector2 spawnPointButton = new Vector2(-493, 426 - (i * 12.5f));
            Button buttonClone;
            buttonClone = Instantiate(buttonPrefab, spawnPointButton, Quaternion.identity);
            buttonClone.transform.parent = GameObject.Find("AchivementPanel").transform;

            textPrefab.text = $"Earn {moneysList[i]} Money";
            Vector2 spawnPointText = new Vector2(-405, 420 - (i * 12.5f));
            Text textClone;
            textClone = Instantiate(textPrefab, spawnPointText, Quaternion.identity);
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