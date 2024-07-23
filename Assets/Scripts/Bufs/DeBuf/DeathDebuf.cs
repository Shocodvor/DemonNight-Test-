
using System.Diagnostics;
using TestTusk;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class DeathDebuf : MonoBehaviour
{


    [SerializeField] private events _events;


    [SerializeField] private GameObject Ui;


    public static event UnityAction OnEvent;

    [SerializeField] private Transform _position;


    private void Start()
    {
        _events = GameObject.Find("Events").GetComponent<events>();

    }


        private void OnTriggerEnter2D(Collider2D col)
    {

 
        if (col.gameObject.CompareTag("Player"))

        {


            _events.eventsInv();
            Destroy(col.gameObject,1);

        }


    }

    private void OnEnable()
    {


        events.OnEvent += OnAdsStart;
       



    }

    private void OnDisable()
    {
        events.OnEvent -= OnAdsStart;
    }

    public void OnAdsStart()
    {


        Ui = Resources.Load<GameObject>("EndGame");
        _position = GameObject.Find("Canvas").GetComponent<Transform>();

      

        Instantiate(Ui, _position);
     

        OnDisable();


    }




}
