using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class memorise_salle2 : MonoBehaviour
{
     string chemin;
     string jsonstring;
     public void Save()
     {
         chemin= Application.persistentDataPath+"/memoire.json";
        jsonstring= File.ReadAllText(chemin);

        Salle s = JsonUtility.FromJson<Salle>(jsonstring);

        s.salle= "salle2";

        jsonstring = JsonUtility.ToJson(s);
        File.WriteAllText(chemin,jsonstring);

     }

   public class Salle
   {
       public string salle ;
   }

    
}
