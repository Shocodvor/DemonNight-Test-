using Unity.VisualScripting;
using UnityEngine;

namespace TestTusk
{

   

    public class EnemySpawn 
    {
        public GameObject _emptyPrefab;
        private int _enemyChanse;




        public EnemySpawn ()
        {

            _enemyChanse = Random.Range(0, 11);

          

          if (_enemyChanse<7)

            _emptyPrefab = Resources.Load<GameObject>("BaseEnemy");

            if (_enemyChanse>=7 && _enemyChanse<10)

                _emptyPrefab = Resources.Load<GameObject>("Runner");

            if (_enemyChanse == 10)


                _emptyPrefab = Resources.Load<GameObject>("BigMotherFucker");


        }

    





    }


}
