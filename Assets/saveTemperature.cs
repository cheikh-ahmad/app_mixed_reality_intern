using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class saveTemperature : MonoBehaviour{
     string chemin;
     string jsonstring; 
     public GameObject slider;
     public float val ;
    public void Save()
    {
        chemin= Application.persistentDataPath+"/data1.json";
        jsonstring= File.ReadAllText(chemin);

        slider = GameObject.Find("Slider");
        val = slider.GetComponent<Slider> ().value;

        if (val!=0){
            Temperature temp= JsonUtility.FromJson<Temperature>(jsonstring);

        temp.temperature= val.ToString();

        jsonstring = JsonUtility.ToJson(temp);
        File.WriteAllText(chemin,jsonstring);

        }
        else{

        Temperature temp= JsonUtility.FromJson<Temperature>(jsonstring);

        temp.temperature= "37.2";

        jsonstring = JsonUtility.ToJson(temp);
        File.WriteAllText(chemin,jsonstring);
    }
    }
    public class Temperature 
    {
       public string temperature;
       public string tension;
       public string glycemie;
       public string nivtransfusion;
       public string frequencerespiratoire;

    }
}
