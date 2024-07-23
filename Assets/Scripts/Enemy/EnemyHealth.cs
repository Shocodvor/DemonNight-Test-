using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;


namespace TestTusk {

    public class EnemyHealth : BaseCharacterHealth
    {
        public override float Healthcount { get; set; }
        public override float MaxHealth { get; set; }



   
        [SerializeField] private int _currentPoints;

        [SerializeField] private int _currentHealth;



         void Start()
        {
           
              Healthcount = _currentHealth;
          

        }




        public override void ApllyDamage(float DamageValue)
        {
            Healthcount -= DamageValue;

            Debug.Log(DamageValue);

            if (Healthcount == 0f)
            {


                CurrentScore._currentScore += _currentPoints;
                Destroy(gameObject, 0);


            }


        }
    }

}
