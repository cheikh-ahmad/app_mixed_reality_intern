using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
 using UnityEngine.UI;

public class delete_memoire : MonoBehaviour
{
    string chemin;
     string jsonstring;
     public void Save()
     {
         chemin= Application.persistentDataPath+"/memoire.json";
        jsonstring= File.ReadAllText(chemin);

        Salle s = JsonUtility.FromJson<Salle>(jsonstring);

        s.salle= "";

        jsonstring = JsonUtility.ToJson(s);
        File.WriteAllText(chemin,jsonstring);

     }

   public class Salle
   {
       public string salle ;
   }
}
