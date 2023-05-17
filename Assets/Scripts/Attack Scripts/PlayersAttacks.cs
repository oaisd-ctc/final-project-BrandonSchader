using UnityEngine;

public class PlayersAttacks : MonoBehaviour
{

    private Animator anim;
    private AudioSource audioSource;


    //animation states
    private string ANIMATION_ATTACK = "Attack";

    private void Awake()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        HandleLeftClicks();
        HandleShootInput();
    }

    public void AttackButtonPressed()
    {
        anim.SetBool(ANIMATION_ATTACK, true);
    }

    public void AttackButtonReleased()
    {
        anim.SetBool(ANIMATION_ATTACK, false);
    }

    void HandleLeftClicks()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool(ANIMATION_ATTACK, true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetBool(ANIMATION_ATTACK, false);
        }
    }
    void HandleShootInput()
    {
        if (Input.GetButton("Fire2"))
        {
            // Shoot
            PlayerGun.Instance.Shoot();
        }
    }
}
