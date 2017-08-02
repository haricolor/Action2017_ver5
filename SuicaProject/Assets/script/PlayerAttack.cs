using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public float animationTime = 0.333f;
    public Collider2D RightCollider;
    public Collider2D LeftCollider;
    public Collider2D BackCollider;
    public Collider2D FrontCollider;
    Animator WeaponAnim;


    void Start()
    {
        
        WeaponAnim = GetComponent<Animator>();
    }

    void Update () {
        Attack();
	}

    private void Attack()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            WeaponAnim.SetBool("IsAttack", true);

            switch (Player.Vector)
            {
                case "Front":
                    FrontCollider.isTrigger = false;
                    break;

                case "Back":
                    BackCollider.isTrigger = false;
                    break;

                case "Right":
                    RightCollider.isTrigger = false;
                    break;

                case "Left":
                    LeftCollider.isTrigger = false;
                    break;
            }
        }
        Invoke("NotAttack", animationTime);
    }

    void NotAttack()
    {
        RightCollider.isTrigger = true;
        LeftCollider.isTrigger = true;
        BackCollider.isTrigger = true;
        FrontCollider.isTrigger = true;
        WeaponAnim.SetBool("IsAttack", false);
    }

    
}
