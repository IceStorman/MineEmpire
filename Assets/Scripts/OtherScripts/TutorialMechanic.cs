using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialMechanic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Image tutorImage;
    [SerializeField] private Text tutorText;

    [SerializeField] private List<Sprite> pageImage = new List<Sprite>();
    [SerializeField] private List<string> pageText = new List<string>();

    bool isTutor = false;
    int whatPageIsNow = 0;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void StartedTutorial()
    {
        panel.SetActive(true);
        NextPage();
        isTutor = true;
    }

    public void EndTutorial()
    {
        whatPageIsNow = 0;
        panel.SetActive(false);
        isTutor = false;
    }

    public void NextPage()
    {
        if (whatPageIsNow >= pageImage.Count)
        {
            EndTutorial();
            return;
        }
        tutorImage.sprite = pageImage[whatPageIsNow];
        tutorText.text = pageText[whatPageIsNow];
        whatPageIsNow++;
    }
}