using UnityEngine;
using UnityEngine.UI;


public class PauseSettings : MonoBehaviour
{
    [SerializeField] private GameObject Pause;

    public void Start()
    {
        Close();
    }

    public void Open()
    {
        Pause.SetActive(true);
    }

    public void Close()
    {
        Pause.SetActive(false);
    }
}