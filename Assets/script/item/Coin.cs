using System;
using UnityEngine;
public class CoinClass : MonoBehaviour
{
    public static event Action<GameObject,int> OnCoinPuckUp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            OnCoinPuckUp?.Invoke(gameObject,1);
            Destroy(gameObject);
        }
    }
}