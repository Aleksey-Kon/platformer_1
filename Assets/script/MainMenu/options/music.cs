using UnityEngine;
using UnityEngine.UI;
public class music : MonoBehaviour
{
    [SerializeField] private Slider _sliderMusic;
    public static float MusicValue {  get; private set; }
    private void Awake()
    {
        _sliderMusic.value = PlayerPrefs.GetFloat("MusicValue");
    }
    public void OnMusicChange(float value)
    {
        MusicValue = value;
    }
}