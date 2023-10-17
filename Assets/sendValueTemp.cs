using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class sendValueTemp : MonoBehaviour
{
    string chemin;
    string chemin_memoire;
    string jsonstring_memoire ;
    string jsonstring;
    public GameObject slider;
    public float val ;
    public int i;
    public void Save()
    {
        chemin_memoire= Application.persistentDataPath+"/memoire.json";
        jsonstring_memoire= File.ReadAllText(chemin_memoire);
        Memoire mem= JsonUtility.FromJson<Memoire>(jsonstring_memoire);

        for ( i=1 ; i<12 ; i++) 
        {
            if (mem.salle == "salle"+i)
            {
        
                chemin= Application.persistentDataPath+"/data"+i+".json";
                jsonstring= File.ReadAllText(chemin);

                slider = GameObject.Find("Slider");
                val = slider.GetComponent<Slider> ().value;

                if (val!=0)
                {
                    Struct temp= JsonUtility.FromJson<Struct>(jsonstring);

                    temp.temperature= val.ToString();

                    jsonstring = JsonUtility.ToJson(temp);
                    File.WriteAllText(chemin,jsonstring);

                }
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
