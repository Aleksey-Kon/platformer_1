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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _PossiblePickUp = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
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
            _PossiblePickUp = false;
            itemstorage.AddKeys(gameObject, 1);
            Destroy(gameObject, 0.5f);
        }
    }
}