using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;

public class SlowTimePickedUp : MonoBehaviour
{
   

    public View view;

    public int time;

    private void Start()
    {
       
        view = GameObject.Find("Player").GetComponent<View>();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {


            view.speed = 0.6f;
           

        }


    }

    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {


            view.speed = 1f;

            Destroy(gameObject);


        }


    }



}


