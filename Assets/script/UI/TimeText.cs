using TMPro;
using UnityEngine;
public class TimeText : MonoBehaviour
{
    [SerializeField] private TMP_Text _timetext;
    private float _timer;
    private void Update()
    {
        _timer += Time.deltaTime;
        float minutes = Mathf.FloorToInt(_timer / 60);
        float seconds = Mathf.FloorToInt(_timer % 60);
        _timetext.text = $"{minutes}:{seconds}";
    }
}