using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestTusk
{
    public class Bufs
    {

        public GameObject _immortalBuff, _multispeed, weaponbonus;



        public Bufs()
        {

            _immortalBuff = Resources.Load<GameObject>("_immortalBuff");
            _multispeed = Resources.Load<GameObject>("_multispeed");
            weaponbonus = Resources.Load<GameObject>("_weaponBonus");



        }





    }

}