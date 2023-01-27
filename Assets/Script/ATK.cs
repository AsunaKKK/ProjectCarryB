using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATK : MonoBehaviour
{
    public AudioSource atkSound;
    Animator playerAnim;

    bool comboPossible;
    public int atk;
    

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
            atkSound.Play();
        }
            
    }

    void Attack()
    {
        if (atk == 0)
        {
            playerAnim.Play("Attack");
           
        }


        if (atk != 0)
        {
            if (comboPossible)
            {
                comboPossible = false;
             
            }
        }
    }
    public GameObject hitBox;

    void ChangeTag(string t)
    {
        hitBox.tag = t;
    }


    public void ComboPossible()
    {
        comboPossible = true;
    }
}
