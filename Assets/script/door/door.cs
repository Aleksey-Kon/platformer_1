using UnityEngine;
public class door : MonoBehaviour
{
    //ооооосылочки https://open.spotify.com/track/1LiRjgMyfg1OGzS4jhgz5Q?si=71b7e6a548a14dd6
    [SerializeField] private Animator _animator,_animatorUI;
    private bool _abilityopendoor,_dooropened;
    [SerializeField] private Transform _spawnpoint;
    [SerializeField] private Transform _playertr;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _animator.SetBool("doorapproach", true);
            _abilityopendoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool("doorapproach", false);
        _abilityopendoor = false;
    }
    public void DoorOpen()
    {
        if (_abilityopendoor){
            if (itemstorage.Keys <= 0) {
                _animatorUI.SetBool("NoKey", true);
                return;
            }
            if (_dooropened)
            {
                print("дверь уже открыта");
                return;
            }
            else
            {
                itemstorage.AddKeys(gameObject, -1);
                _playertr.position = _spawnpoint.position;
                print("дверь открыта");
                _dooropened = true;
            }
        }
    }
    private void OnEnable()
    {
        PlayerConroller.OnDoorOpen += DoorOpen;
    }
    private void OnDisable()
    {
        PlayerConroller.OnDoorOpen -= DoorOpen;
    }
}