using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itembuttom : MonoBehaviour
{
    public int buttonID;
    private item thisItem;

    
   
    public GameObject dd;
    
   
   


    private void Start()
    {
        
       dd.SetActive(false);
        
       
    }
    private void Update()
    {

        
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private item GetThisItem()
    {
        for (int i=0; i<GameManager.instance.items.Count;i++)
        {
           
            if (buttonID == i)
            {
                thisItem = GameManager.instance.items[i];
                
            }
        }
        return thisItem;
        
    }

    public void CloseButton()
    {
        GameManager.instance.RemoveItem(GetThisItem());
        
       dd.SetActive(true);
        
        


    }
   

    
  


}
