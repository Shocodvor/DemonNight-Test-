using UnityEngine;
using UnityEngine.UI;



namespace TestTusk {
    
   


public abstract class BaseCharacterHealth : MonoBehaviour
{
        

        abstract public float Healthcount { get; set; }

        abstract public float MaxHealth { get; set; }

        abstract public void ApllyDamage(float DamageValue);


    void ColorChanger()
    {
       // Color healthColor = Color.Lerp(Color.red, Color.green, (Healthcount / MaxHealth));


          //  Image.color = healthColor;
      //  ringHealthBar.color = healthColor;

    }


}

}