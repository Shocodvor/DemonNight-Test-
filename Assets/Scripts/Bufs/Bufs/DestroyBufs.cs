using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyBufs : MonoBehaviour
{

    private void Start()
    {

        StartCoroutine(DestroyBuf());


    }


    IEnumerator DestroyBuf()

    {

        yield return new WaitForSeconds(5f);

        Destroy(gameObject);

    }


}
