using System;
using UnityEngine;
public class itemstorage : MonoBehaviour
{
    private static int _keys;
    public static int Keys => _keys;
    public static int Coin {  get; private set; }
    public static event Action<string> OnKeyText;
    public static event Action<string> OnCoinText;
    public void AddCoin(object obj, int i)
    {
        Coin += i;
        OnCoinText?.Invoke(Coin.ToString());
    }
    public static void AddKeys(object obj,int i)
    {
        _keys += i;
        OnKeyText?.Invoke(_keys.ToString());
    }
    private void OnEnable()
    {
        CoinClass.OnCoinPuckUp += AddCoin;
    }
    private void OnDisable()
    {
        CoinClass.OnCoinPuckUp -= AddCoin;
    }
}