using System;
using UnityEngine;
public class itemstorage : MonoBehaviour
{
    private static int _keys;
    public int Keys => _keys;
    public static event Action<string> OnKeyText;
    public static void AddKeys(object obj,int i)
    {
        _keys += i;
        OnKeyText?.Invoke(_keys.ToString());
    }
}