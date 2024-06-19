using TMPro;
using UnityEngine;
public class LangButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _textLang;
    public static int Lang {  get; private set; }
    private void Awake()
    {
        Lang = PlayerPrefs.GetInt("Lang");
    }
    public void ButtonPress()
    {
        if (Lang == 0)
        {
            Lang = 1;
            _textLang.text = "Русский";
        }
        else if (Lang == 1)
        {
            Lang = 0;
            _textLang.text = "English";
        }
    }
}