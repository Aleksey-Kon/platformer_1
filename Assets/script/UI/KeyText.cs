using TMPro;
using UnityEngine;
public class KeyText : MonoBehaviour
{
    private void OnEnable()
    {
        itemstorage.OnKeyText += SetTextKey;
    }
    private void OnDisable()
    {
        itemstorage.OnKeyText -= SetTextKey;
    }
    [SerializeField] private TMP_Text _keyText;
    public void SetTextKey(string text){
        _keyText.text = text;
    }
}