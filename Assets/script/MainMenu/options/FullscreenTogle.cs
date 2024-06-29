using UnityEngine;
using UnityEngine.UI;
public class FullscreenToggle : MonoBehaviour
{
    public static int FullScreen { get; private set;}
    [SerializeField] private Toggle _toggle;
    private void Awake()
    {
        int a = PlayerPrefs.GetInt("Fullscreen");
        FullScreen = a;
        SetFullscreen(a);
        if (a == 1) _toggle.isOn = true;
        else _toggle.isOn = false;

    }
    public static void SetFullscreen(int i)
    {
        if(i == 1) Screen.fullScreen = true;
        else Screen.fullScreen = false;
    }
    public void ChangeFullScreen(bool screen)
    {
        if (screen)
            FullScreen = 1;
        else
            FullScreen = 0;
    }
}