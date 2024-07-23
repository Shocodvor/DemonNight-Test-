using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;

public class PlayerDeathAction : MonoBehaviour
{


  
    private events _events;

    [SerializeField]
    private Item Coins;

    [SerializeField]
    private int coiinsCount;

    [SerializeField] private GameObject Spawner;
   




    private void OnEnable()
    {


        events.OnEvent += DeathPlayer;


    }

    private void OnDisable()
    {
        events.OnEvent -= DeathPlayer;
    }




    public void DeathPlayer()
    {
        
        Destroy (Spawner);  

        Destroy(gameObject);

       
    }
}



