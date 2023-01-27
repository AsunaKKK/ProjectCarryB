using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chworm : MonoBehaviour
{
    public wormenimy[] enemyArray;
    public AudioSource wormAudi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (wormenimy enemy in enemyArray)
            {
                wormAudi.Play();
                enemy.chase = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (wormenimy enemy in enemyArray)
            {
                enemy.chase = false;
            }
        }
    }



}
