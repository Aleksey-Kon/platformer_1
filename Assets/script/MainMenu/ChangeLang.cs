using TMPro;
using UnityEngine;
public class ChangeLang : MonoBehaviour
{
    [SerializeField] private string[] _langRu, _langEn;
    private int Lang;
    [SerializeField] private TMP_Text[] _text;
    private void Start()
    {
        ChangeLangText();
    }
    public void ChangeLangText()
    {
        Lang = PlayerPrefs.GetInt("Lang");
        for (int i = 0; i < _text.Length; i++)
        {
            if(Lang == 0)
            {
                _text[i].text = _langEn[i];
            }
            if (Lang == 1)
            {
                _text[i].text = _langRu[i];
            }
        }
    }
}