using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP_Bar : MonoBehaviour
{
    public float hp;
    public float hp_Cur;

    public Image hpBar_Front;
    public Image hpBar_Back;
    public GameObject Player;
    public GameObject[] Text;

    public float addBlood = 1f;
    public float second = 1f;

    public string sceneName;

    public int trapDmg;
    public int pigDmg;
    public int wormDmg;
    public int birdDmg;
    public int porcupineDmg;
    public AudioSource tapSound;
    public AudioSource coreSound;
    public string SceneName;
    private void Start()
    {
        hp_Cur = hp;
       
        Player.SetActive(true);
        for (int i = 0; i < 8; i++)
        {
            Text[i].SetActive(true);
        }

        //StartCoroutine(addblood(addBlood, second));

    }

    void SyncBar()
    {
        hpBar_Front.fillAmount = hp_Cur / hp;
        if (hpBar_Back.fillAmount > hpBar_Front.fillAmount)
        {
            hpBar_Back.fillAmount = Mathf.Lerp(hpBar_Back.fillAmount,
                hpBar_Front.fillAmount, Time.deltaTime);
        }
    }

    private void Update()
    {
        SyncBar();
        dedgo();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pigdamage" )
        {
            hp_Cur -= pigDmg;
            
            
        } 
        else if (collision.tag == "Tap")
        {
            hp_Cur -= trapDmg;
            tapSound.Play();
        }
        else if (collision.tag == "bird")
        {
            hp_Cur -= birdDmg;
        }
        else if(collision.tag == "worm")
        {
            hp_Cur -= wormDmg;
           
        }
        else if (collision.tag == "porcupine")
        {
            hp_Cur -= porcupineDmg;
        }
        else if (collision.tag == "Soul")
        {
            hp_Cur += 5f;
            coreSound.Play();
            Destroy(collision.gameObject);
            

        }
        else if (collision.tag == "Soul_Worm")
        {
            hp_Cur += 10f;
            coreSound.Play();
            Destroy(collision.gameObject);
            

        }
        else if (collision.tag == "Soul_Pig")
        {
            hp_Cur += 30f;
            coreSound.Play();
            Destroy(collision.gameObject);
            

        }
        else if(collision.tag == "BossPig")
        {
            hp_Cur -= 20f;
        }






    }
    public void dedgo()
    {

        if (hp_Cur <= 0)
        {
            SceneManager.LoadScene(SceneName);


        }



    }

    /*public IEnumerator addblood(float value, float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (hp_Cur > 0)
            {
                hp_Cur += value;
            }
          
        }
    }*/
}
