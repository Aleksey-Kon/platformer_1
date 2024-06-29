using UnityEngine;
public class AndroidButtonsActive : MonoBehaviour
{
    [SerializeField] private GameObject _androidButtons;
    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _androidButtons.SetActive(true);
        }
    }
}