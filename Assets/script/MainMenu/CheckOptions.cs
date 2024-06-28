using UnityEngine;
public class CheckOptions : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Lang"))
        {
            if (Application.systemLanguage == SystemLanguage.Russian) PlayerPrefs.SetInt("Lang", 1);
            else if (Application.systemLanguage == SystemLanguage.English) PlayerPrefs.SetInt("Lang", 0);
            else PlayerPrefs.SetInt("Lang", 0);
        }
        if(!PlayerPrefs.HasKey("MusicValue")) PlayerPrefs.SetFloat("MusicValue", 0.6f);
        if(!PlayerPrefs.HasKey("AudioValue")) PlayerPrefs.SetFloat("AudioValue", 0.6f);
        if(!PlayerPrefs.HasKey("AudioValue")) PlayerPrefs.SetFloat("AudioValue", 0.6f);
        if(!PlayerPrefs.HasKey("Fullscreen")) PlayerPrefs.SetInt("Fullscreen", 1);

        FullscreenToggle.SetFullscreen(PlayerPrefs.GetInt("Fullscreen"));
    }
}