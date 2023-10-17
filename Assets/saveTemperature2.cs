using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class saveTemperature2 : MonoBehaviour
{
     string chemin;
     string chemin_memoire;
     string jsonstring_memoire;
     string jsonstring;
    
    public void Save()
    {
        chemin_memoire= Application.persistentDataPath+"/memoire.json";
        jsonstring_memoire =File.ReadAllText(chemin_memoire);

        Memoire mem= JsonUtility.FromJson<Memoire>(jsonstring_memoire);

       /* if(mem.salle == "salle2")
         {
            chemin= Application.persistentDataPath+"/data2.json";
            jsonstring= File.ReadAllText(chemin);

            Temperature temp= JsonUtility.FromJson<Temperature>(jsonstring);

            temp.temperature= "37";

            jsonstring = JsonUtility.ToJson(temp);
            
            File.WriteAllText(chemin,jsonstring);
         }*/
        
        for (int i=1; i<12 ; i++ ){

            if (mem.salle== "salle"+i) 
            {

                chemin= Application.persistentDataPath+"/data"+i+".json";
                jsonstring= File.ReadAllText(chemin);

                Struct temp= JsonUtility.FromJson<Struct>(jsonstring);

                temp.temperature= "37";

                jsonstring = JsonUtility.ToJson(temp);
            
                File.WriteAllText(chemin,jsonstring);

            }
        }

         
     }

    public class Memoire 
    {
        public string salle ;
    }

    public class Struct 
    {
       public string temperature;
       public string tension;
       public string glycemie;
       public string nivtransfusion;
       public string frequencerespiratoire;

    }
}
