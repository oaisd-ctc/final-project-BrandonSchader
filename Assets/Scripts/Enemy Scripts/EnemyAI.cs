using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Transform zombieTransform;

    public float chaseSpeed;

    private CapsuleCollider col;
    private Transform player;
    private Animator anim;

    //animation states
    private string ANIMATION_ATTACK = "Attack";
    private string ANIMATION_RUN = "Run";
    private string ANIMATION_SPEED = "Speed";

    private void Awake()
    {
        col = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        zombieTransform = this.transform;
    }

    private void Update()
    {
        float distance = Vector3.Distance (zombieTransform.position, player.position);

    }
    void Chase()
    {
        anim.SetBool(ANIMATION_RUN, true);
        anim.SetFloat(ANIMATION_SPEED, chaseSpeed);
        anim.SetBool(ANIMATION_ATTACK, false);
    }
    void Attack()
    {
        anim.SetBool (ANIMATION_ATTACK, true);
    }
}
