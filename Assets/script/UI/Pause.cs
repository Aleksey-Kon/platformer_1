using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pause;
    public void PauseActive()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}