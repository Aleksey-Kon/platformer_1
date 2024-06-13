using UnityEngine;
public class Key : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _animator.SetBool("KeyApproach", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool("KeyApproach", false);
    }
    public void KeyApproach()
    {
        _animator.SetBool("KeyApproach",true);
    }
}