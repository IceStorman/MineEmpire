using UnityEngine;

public class FirstSpecialSectionMechanics : MonoBehaviour
{
    [SerializeField] private GameObject firstSpecialSectionPanel;

    public void ClosePanel()
    {
        firstSpecialSectionPanel.SetActive(false);
    }
}
