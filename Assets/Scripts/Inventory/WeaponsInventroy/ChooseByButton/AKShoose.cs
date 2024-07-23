using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static TestTusk.ShootButton;

namespace TestTusk
{


    public class AKShoose : MonoBehaviour
    {


        public void AtviveAk(ShootButton shoot)
        {

            shoot.ChooseWeapon = Weapon.Ak;

        }



    }








}
