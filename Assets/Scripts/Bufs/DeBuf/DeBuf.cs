using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuf

{

    public GameObject _slowSpeedBuf, _deadBuf;



    public DeBuf()
    {

        _slowSpeedBuf = Resources.Load<GameObject>("slowSpeedBuf");
        _deadBuf = Resources.Load<GameObject>("deadBuf");



    }




}
