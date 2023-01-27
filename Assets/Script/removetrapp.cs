using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removetrapp : MonoBehaviour
{
    public GameObject[] pp;
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
        if (collision.tag == "porcupine")
        {
            for (int i = 0; i < 20; i++)
            {
                Destroy(pp[i]);
            }
        }
    }
}
