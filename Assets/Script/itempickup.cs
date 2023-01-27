using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempickup : MonoBehaviour
{
    

    public item itemdata;
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.instance.AddItem(itemdata);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
