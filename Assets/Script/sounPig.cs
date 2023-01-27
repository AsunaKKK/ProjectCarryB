using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounPig : MonoBehaviour
{
    public AudioSource pigAni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pigAni.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pigAni.Stop();
        }
    }

}
