using UnityEngine;
public class AndroidOptions : MonoBehaviour
{
    [SerializeField] GameObject _fullscreenToggle;
    private void Awake()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            _fullscreenToggle.SetActive(false);
        }
    }
}