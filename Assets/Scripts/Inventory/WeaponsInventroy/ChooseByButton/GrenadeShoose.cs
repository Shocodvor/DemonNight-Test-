using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static TestTusk.ShootButton;

namespace TestTusk
{


    public class GrenadeChoose : MonoBehaviour
    {


        public void AtviveGreande(ShootButton shoot)
        {

            shoot.ChooseWeapon = Weapon.Greande;

        }



    }








}
