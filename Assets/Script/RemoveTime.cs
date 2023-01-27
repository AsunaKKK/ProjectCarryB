using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RemoveTime : MonoBehaviour
{

    public Text TimeText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("RemoveTime"))
        {
            //Debug.Log("sdasd");
            GameObject.FindGameObjectWithTag("RemoveTime").GetComponent<Text>().color = new Color32(7, 7, 7, 7);
            // aaas.color = new Color(7, 7, 7, 7);
        }


    }
}