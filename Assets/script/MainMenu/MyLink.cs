using UnityEngine;
public class MyLink : MonoBehaviour
{
    public void Telegram(string url){
        Application.OpenURL(url);
    }
    public void DonationAlerts(string url){
        Application.OpenURL(url);
    }
}