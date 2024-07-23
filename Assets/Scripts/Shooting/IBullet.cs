

using UnityEngine;

interface IBullet
{

    float launchSpeed { get; set; }
    float reloadtime {  get; set; } 

    Vector2 _transform { get; set; }

    Rigidbody2D rb { get; set; }


    void Launch();




}




