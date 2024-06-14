using UnityEngine;
public class Key : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private bool _PossiblePickUp;
    private void OnEnable()
    {
        PlayerConroller.OnKeyPickUp += PickUp;
    }
    private void OnDisable()
    {
        PlayerConroller.OnKeyPickUp -= PickUp;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        _PossiblePickUp = true;
        if (collision.gameObject.tag == "Player")
        {
            _animator.SetBool("KeyApproach", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _PossiblePickUp = false;
        _animator.SetBool("KeyApproach", false);
    }
    public void PickUp()
    {
        if (_PossiblePickUp){
            itemstorage.AddKeys(gameObject, 1);
            Destroy(gameObject, 0.5f);
        }
    }
}