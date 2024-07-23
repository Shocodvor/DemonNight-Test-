using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TestTusk;
using UnityEngine;

public class SaveSerial:MonoBehaviour
{
    int ArmorInt, AmmunitionInt, Health;

    public Item Armor, Ammunition, HealthITem;



    private void Start()
    {
        LoadGame();
    }

    private void Update()
    {
     //   ArmorInt = Armor.ItemCount;
       // AmmunitionInt = Ammunition.ItemCount;
      //  Health = HealthITem.ItemCount;  


    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath
          + "/MySaveData.dat");
        SaveData data = new SaveData();
        data.ArmorCount = ArmorInt;
        data.AmmunitionCount = AmmunitionInt;
        data.HealthAidCoint = Health;
        bf.Serialize(file, data);
        file.Close();
        
    }


    void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath
          + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file =
              File.Open(Application.persistentDataPath
              + "/MySaveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            ArmorInt = data.ArmorCount;
            AmmunitionInt = data.AmmunitionCount;
            Health = data.HealthAidCoint;
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }


}
