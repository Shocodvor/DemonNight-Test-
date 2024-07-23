using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static TestTusk.ShootButton;

namespace TestTusk
{


    public class MakarovShoose : MonoBehaviour
    {


        public void AtviveMakarov(ShootButton shoot)
        {

            shoot.ChooseWeapon = Weapon.Makarov;

        }



    }








}
