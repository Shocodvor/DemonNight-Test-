
using UnityEngine;
using UnityEngine.UI;


namespace TestTusk
{

    public class PlayerHealth : BaseCharacterHealth
    {

      
        public override float Healthcount { get; set; }
        public override float MaxHealth { get; set; }

        public Image HealthBar;
        [SerializeField] private events _events;

        void Start()
        {

            Healthcount = 100f;

        }

       
        void Update()
        {

         

            Healthcount = Mathf.Clamp(Healthcount, 0, 100f);

            HealthBar.fillAmount = Healthcount / 100;

            if (Healthcount == 0)
            {
        
                _events.eventsInv();


            }


        }

        public override void ApllyDamage(float DamageValue)
        {
          
            Healthcount -= DamageValue;
           

        }
    }


}