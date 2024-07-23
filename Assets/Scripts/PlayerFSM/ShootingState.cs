using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestTusk
{

    public class ShootingState : Istate
    {
       
        public Weapon ChooseWeapon;

        public View _view;

        private Transform _aim;

        public int shooseWeapon;

        [SerializeField] private float _damage;

        public void Enter()
        {
            
            _view = GameObject.FindGameObjectWithTag("Player").GetComponent<View>();
            _aim = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Transform>();    

        }

        public void Exit()
        {
          
        }

        public void Update()
        {


          

            if (Input.GetMouseButtonDown(0))

            {
                Shooting();


            }

        if(StaticWeaponChoose._chooseWeapon == 1)

            {

                ChooseWeapon = Weapon.Greande;

            }


            if (StaticWeaponChoose._chooseWeapon == 2)

            {

                ChooseWeapon = Weapon.Ak;

            }

            if (StaticWeaponChoose._chooseWeapon == 3)

            {

                ChooseWeapon = Weapon.Makarov;

            }

            if (StaticWeaponChoose._chooseWeapon == 4)

            {

                ChooseWeapon = Weapon.Shotgun;

            }

            



        }



        public enum Weapon
        {


            Makarov,
            Ak,
            Greande,
            Shotgun

        }


        public void Shooting()
        {

        
            var playerPosition = _view.PlayerPosition();


            RayH ray = new RayH();
            ray.ShootRay(_view._playerTransform, _damage, _aim);

          

            switch ((Weapon)ChooseWeapon)
            {


                case Weapon.Makarov:


                    AkShooting Ak = new AkShooting();
                    Ak.InstanstiateFire(playerPosition);
                    _damage = 3f;

                    break;



                case Weapon.Ak:


                    MakarovShooting Mak = new MakarovShooting();
                    Mak.InstanstiateFire(playerPosition);
                    _damage = 1f;


                    break;

                case Weapon.Greande:


                    GrenadeShoot Gr = new GrenadeShoot();
                    Gr.InstanstiateFire(playerPosition);
                    _damage = 10f;

                    break;

                case Weapon.Shotgun:


                   ShotgunShoot shotgun = new ShotgunShoot();
                    shotgun.InstanstiateFire(playerPosition);
                    shotgun.InstanstiateFire(playerPosition);
                    shotgun.InstanstiateFire(playerPosition);
                    shotgun.InstanstiateFire(playerPosition);
                    shotgun.InstanstiateFire(playerPosition);

                    _damage = 1.5f;

                    break;




            }


        }
    }


}
