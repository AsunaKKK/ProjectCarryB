using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtk : MonoBehaviour
{
    public Transform target;
    public Animation eniAni;
    int atk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void enemyAtk()
    {
        if ((target.position - transform.position).magnitude < 4)
        {
            switch (atk)
            {
                case 0:
                    eniAni.Play("Enemy_Atk");
                    break;
            }
        }
    }
}
