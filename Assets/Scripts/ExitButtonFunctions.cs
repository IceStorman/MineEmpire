using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonFunctions : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
