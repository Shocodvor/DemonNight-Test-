

using UnityEngine;

namespace TestTusk
{

    public class MakarovShooting : BaseShootin


    {
        public override GameObject _prefab { get; set; }
        public override Vector3 _spawnPoint { get; set; }
        public override View view { get; set; }


        public void InstanstiateFire(Vector3 pos)
        {

            _spawnPoint = pos;
            _prefab = Resources.Load<GameObject>("MakarHit");
            Instantiate(_prefab, _spawnPoint, Quaternion.identity);



        }



    }




}