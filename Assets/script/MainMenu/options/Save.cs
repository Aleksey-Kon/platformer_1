using UnityEngine;
public class Save : MonoBehaviour
{
    [SerializeField] private ChangeLang _script;
    public void SaveOptions()
    {
        PlayerPrefs.SetFloat("MusicValue", music.MusicValue);
        PlayerPrefs.SetFloat("AudioValue", Audio.AudioValue);
        PlayerPrefs.SetInt("Lang", LangButton.Lang);
        PlayerPrefs.SetInt("Fullscreen", FullscreenToggle.FullScreen);
        PlayerPrefs.Save();
        _script.ChangeLangText();
        FullscreenToggle.SetFullscreen(FullscreenToggle.FullScreen);
    }
}