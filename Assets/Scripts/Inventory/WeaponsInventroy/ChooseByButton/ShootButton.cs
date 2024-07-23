using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

namespace TestTusk
{


    public class ShootButton : MonoBehaviour
    {

        [SerializeField] private Button _shootbutton;
        public Weapon ChooseWeapon;

        public View _view;

        public Transform aim;

     

        public enum Weapon { 


        Makarov,
        Ak,
        Greande
        
        }
 

            public void Shooting() {


            var playerPosition = _view.PlayerPosition();
          

            RayH ray = new RayH();
            ray.ShootRay(_view._playerTransform,0.01f,aim);

            switch ((Weapon)ChooseWeapon)
            {

                 
                case Weapon.Makarov:


                    AkShooting Ak = new AkShooting();
                    Ak.InstanstiateFire(playerPosition);

                    break;



                case Weapon.Ak:

                   
                    MakarovShooting Mak= new MakarovShooting();
                    Mak.InstanstiateFire(playerPosition);



                    break;

                case Weapon.Greande:


                    GrenadeShoot Gr= new GrenadeShoot();
                   Gr.InstanstiateFire(playerPosition);


                    break;



            }


        }

        }








    }
