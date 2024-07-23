using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))





            Destroy(gameObject, 0);


    }



    }
