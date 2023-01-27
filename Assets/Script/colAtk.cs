using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class colAtk : MonoBehaviour
{
    public ATK atk;

    public TextMeshProUGUI dmgText;
   
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
        if (collision.tag == "HitBoxEnemy")
        {
            dmgText.gameObject.SetActive(true);
        }
    }
}
