using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;

public class MultiSpeedBonus : MonoBehaviour
{

    [SerializeField] private View _view;


    private void Start()
    {

        _view = GameObject.FindGameObjectWithTag("Player").GetComponent<View>();

        _view.speed = 1.5f;

        StartCoroutine(Box1());

    }


    IEnumerator Box1()

    {

        yield return new WaitForSeconds(10f);

        _view.speed = 1.0f;

        Destroy(this);


    }



}
