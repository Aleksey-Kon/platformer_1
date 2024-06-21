using UnityEngine;
public class ButtonMove : MonoBehaviour
{
    [SerializeField] private PlayerConroller _controller;
    private bool _clicked = false;
    private int _direction;
    public void ClickedDown(int a)
    {
        _direction = a;
        _clicked = true;
    }
    public void ClickedUp()
    {
        _clicked = false;
    }
    private void Update()
    {
        if( _clicked)
        {
            _controller.PlayerRun(_direction);
        }
    }
}