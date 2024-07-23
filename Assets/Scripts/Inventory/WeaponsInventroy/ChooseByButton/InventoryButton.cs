using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace TestTusk
{


    public class InventoryButton : MonoBehaviour
    {

        [SerializeField] private Button _InventoryButton;

        [SerializeField] private GameObject Inventory;
   


        private void OnEnable()
        {

            _InventoryButton.onClick.AddListener(AtviveInventory);
        }

        private void OnDisable()
        {

            _InventoryButton.onClick.RemoveListener(AtviveInventory);
        }


       private void AtviveInventory()

        {
            Inventory.SetActive(true);
            


        }

    }








}
