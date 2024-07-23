using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class events:MonoBehaviour
{
    public static event UnityAction OnEvent;

   public void eventsInv ()
    {

        OnEvent?.Invoke();

    }
  
    

}
