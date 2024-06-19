using UnityEngine;
using UnityEngine.UI;
public class Audio : MonoBehaviour
{
    [SerializeField] private Slider _sliderAudio;
    public static float AudioValue { get; private set; }
    private void Awake()
    {
        _sliderAudio.value = PlayerPrefs.GetFloat("AudioValue");
    }
    public void OnMusicChange(float value)
    {
        AudioValue = value;
    }
}