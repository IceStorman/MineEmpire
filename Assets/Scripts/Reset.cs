using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        Debug.LogWarning("Reseted");
    }
}
