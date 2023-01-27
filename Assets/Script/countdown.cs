using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public Text scoreTime;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public int minutes;
    public int secondsFill;

    public float timeLimit = 11f;
    public float timeremain;

    public Text timetext;
    public int addTime;


    public int time;
    public string sceneName;
    public AudioSource audioSource;

    //public Transform playerTraget;



    // Start is called before the first frame update
    void Start()
    {
        timeremain = 11f;

        scoreAmount = 60f;
        pointIncreasedPerSecond = 1f;
        secondsFill = 0;
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        sTime();
        ff();
        //traget();

        timescore();
        

       
        

    }

    public void sTime()
    {

        //scoreTime.text = "Time: " + (int)minutes + ":" + (int)secondsFill + (int)scoreAmount;
        scoreAmount -= pointIncreasedPerSecond * Time.deltaTime;
        timetext.text = " " + timeremain + ":" + (int)scoreAmount;
        

        if (scoreAmount < 0)
        {
            minutes++;
            timeremain = timeLimit - minutes;
            scoreAmount = 60f;
           
        }




        /*if (scoreAmount < 10)
        {
            scoreTime.text = "Time: " + (int)minutes + ":" + (int)secondsFill + (int)scoreAmount;
        }

        if (scoreAmount > 10)
        {
            scoreTime.text = "Time: " + (int)minutes + ":" + (int)scoreAmount;
        }*/

    }


    public void ff()
    {
        if (timeremain <= -1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Time")
        {
            timeremain += addTime;
            minutes -= addTime;
            audioSource.Play();
            
            Destroy(collision.gameObject);
        }
    }

    /*public void traget()
    {
        

        //GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position = new Vector3(playerTraget.position.x, playerTraget.position.y, transform.position.z);

        transform.position = new Vector3(playerTraget.position.x, playerTraget.position.y, transform.position.z);
    }*/

    public void timescore()
    {
        PlayerPrefs.SetFloat("jjj",timeremain);
    }
}
