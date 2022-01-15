using UnityEngine;

public class antiCheat : MonoBehaviour
{
    [SerializeField] private int cps = 0;
    [SerializeField] private GameObject panelIdiot;
    [SerializeField] private Songs stop;
    [SerializeField] private MainData mainData;
    [SerializeField] private AudioSource scarySound;

    public void ClickCheatCheck()
    {
        cps++;
        Invoke("Minus", 1f);
    }

    private void Minus()
    {
        cps--;
    }

    private void Update()
    {
        if (cps >= 25)
        {
            scarySound.Play();
            panelIdiot.SetActive(true);
            stop.StopAllMusics();
            Invoke("Quit", 10f);
        }
    }

    private void Quit()
    {
        Application.Quit();
    }
}
