using UnityEngine;
using UnityEngine.UI;


public class PauseSettings : MonoBehaviour
{
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject creditsPanel;

    public void Start()
    {
        Close();
        creditsPanel.SetActive(false);
    }

    public void Open()
    {
        Pause.SetActive(true);
    }

    public void Close()
    {
        Pause.SetActive(false);
    }

    private bool isOpenedCredits = false;

    public void CreditsMech()
    {
        if (isOpenedCredits) creditsPanel.SetActive(false);
        else creditsPanel.SetActive(true);
        isOpenedCredits = !isOpenedCredits;
    }
}