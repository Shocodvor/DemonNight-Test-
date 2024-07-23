using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestTusk


{

    public abstract class BaseShootin:MonoBehaviour
    {

        [SerializeField] public abstract GameObject _prefab { get; set; }
        [SerializeField] public abstract Vector3 _spawnPoint { get; set; }
        [SerializeField] public abstract View view { get; set; }






   
 

    }






}

