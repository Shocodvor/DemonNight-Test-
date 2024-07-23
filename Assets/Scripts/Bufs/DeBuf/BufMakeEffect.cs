using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TestTusk;
using Unity.VisualScripting;
using UnityEngine;

public class BufMakeEffect : AbstractBuffDebuff
{

    public override GameObject _prefab { get; set; }
    public override Vector3 _spawnPoint { get; set; }
    public override View view { get; set; }
    public override int time { get; set; }

    public BufMakeEffect()

    {

        view = GameObject.Find("Player").GetComponent<View>();
        GetPlyerData();

       
    }


    public override void GetPlyerData()
    {
     

        while (time > 0)
        {
            view.speed = 0.6f;
            Debug.Log(time);

            time--;


        }
        

    }
}
