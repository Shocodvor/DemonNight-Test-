using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;

public class BufTouch : MonoBehaviour
{



    [SerializeField] private GameObject _buf;
  

    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.CompareTag("Player"))
        {

           


                Instantiate(_buf, new Vector3(0,0,0), Quaternion.identity);


            }



        }


    }



