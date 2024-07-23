using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : MonoBehaviour
{
    public static bool _immortal;


    private void Start()
    {

        _immortal = true;



        StartCoroutine(Box1());

    }


      IEnumerator Box1()

     {

        yield return new WaitForSeconds(10f);


       _immortal = false;
        Destroy(this);


      }



}
