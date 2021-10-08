using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMineButtonFunctions : MonoBehaviour
{
    public void GoToMine()
    {
        SceneManager.LoadScene("Mine");
    }
}
