using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrail : MonoBehaviour
{

    private MeleeWeaponTrail weaponTrail;
    private Transform sword;
    public Transform slashThreePoint;

    private AudioSource audioSource;

    public AudioClip swordHit1;
    public AudioClip swordHit2;
    public AudioClip earthHitMusic;
    public AudioClip jiaoHanSheng;

    // Start is called before the first frame update
    void Awake()
    {
        sword = GameObject.Find("Hotdog A").transform;
        weaponTrail = sword.gameObject.GetComponent<MeleeWeaponTrail>();
        audioSource = GetComponent<AudioSource>();
    }
    void SlashOneWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            audioSource.PlayOneShot(swordHit1);
        }
    }
    void SlashOneWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
        }
    }

    void SlashTwoWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            audioSource.PlayOneShot(swordHit2);
        }
    }
    void SlashTwoWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
        }
    }

    void SlashThreeWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            audioSource.PlayOneShot(jiaoHanSheng);
        }
    }
    void SlashThreeWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
