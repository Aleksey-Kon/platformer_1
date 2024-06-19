using UnityEngine;
public class Save : MonoBehaviour
{
    [SerializeField] private ChangeLang _script;
    public void SaveOptions()
    {
        PlayerPrefs.SetFloat("MusicValue", music.MusicValue);
        PlayerPrefs.SetFloat("AudioValue", Audio.AudioValue);
        PlayerPrefs.SetInt("Lang", LangButton.Lang);
        PlayerPrefs.Save();
        _script.ChangeLangText();
    }
}