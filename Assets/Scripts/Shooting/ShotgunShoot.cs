
using UnityEngine;

namespace TestTusk


{

    public class ShotgunShoot : BaseShootin
    {
        public override GameObject _prefab { get; set; }
        public override Vector3 _spawnPoint { get; set; }
        public override View view { get; set; }




        public void InstanstiateFire(Vector3 pos)
        {

            _spawnPoint = pos;
            _prefab = Resources.Load<GameObject>("ShotGunShoot");
            Instantiate(_prefab, _spawnPoint, Quaternion.identity);








        }








    }


}