using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerConroller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed,_jump,_input;
    [SerializeField] private Animator _animator;
    private bool _right = true;

    public static event Action OnKeyPickUp;
    public void Jimp()
    {
        if (_rb.velocity.y <= 0.2f && _rb.velocity.y >= -0.2f)
        {
            _rb.AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);
            _animator.SetTrigger("Jump");
        }
    }
    #region MovePlayer
    public void SetMovePlayer(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<float>();
    }
    private void PlayerScale(int i)
    {
        _right = !_right;
        gameObject.transform.localScale = new Vector3(3 * i, 3, 1);
    }
    public void PlayerRun(int direction)
    {
        if(_right && direction == -1) {
           PlayerScale(direction);
        }
        if (!_right && direction == 1)
        {
            PlayerScale(direction);
        }
        _rb.AddForce(new Vector2(_speed * direction, 0), ForceMode2D.Force);
        //_rb.AddForce(, ForceMode.Acceleration);
        //_rb.Seta
        _animator.SetFloat("Run", 1f);
    }
    #endregion
    public void PlayerKeyPickUp()
    {
        OnKeyPickUp?.Invoke();
        _animator.SetTrigger("Sneaking");
    }
    private void FixedUpdate()
    {
        PlayerRun((int)_input);
        if(_input == 0)
        {
            _animator.SetFloat("Run", 0f);
        }
    }
}