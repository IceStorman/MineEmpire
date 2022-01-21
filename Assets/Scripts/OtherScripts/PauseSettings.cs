using UnityEngine;
using UnityEngine.UI;


public class PauseSettings : MonoBehaviour
{
    [SerializeField] private GameObject Pause;
    [SerializeField] private Toggle fullscreenToggle;

    public void Start()
    {
        Close();
    }

    /*public void ChangeFullscreenMode()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }*/

    public void Open()
    {
        Pause.SetActive(true);
    }

    public void Close()
    {
        Pause.SetActive(false);
    }
}