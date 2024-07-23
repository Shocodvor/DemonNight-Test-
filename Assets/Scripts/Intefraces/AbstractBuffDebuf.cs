using TestTusk;
using UnityEngine;

public abstract class AbstractBuffDebuff : MonoBehaviour
{

    [SerializeField] public abstract GameObject _prefab { get; set; }
    [SerializeField] public abstract Vector3 _spawnPoint { get; set; }
    [SerializeField] public abstract View view { get; set; }

    [SerializeField] public abstract int time { get; set; }


    public abstract void GetPlyerData();
  






}