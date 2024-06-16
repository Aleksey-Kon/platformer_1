using TMPro;
using UnityEngine;
public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _keyCoin;
    private void OnEnable()
    {
        itemstorage.OnCoinText += SetTextCoin;
    }
    private void OnDisable()
    {
        itemstorage.OnCoinText -= SetTextCoin;
    }
    private void SetTextCoin(string text)
    {
        _keyCoin.text = text;
    }
}