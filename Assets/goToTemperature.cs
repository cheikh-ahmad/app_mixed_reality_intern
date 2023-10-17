using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class goToTemperature : MonoBehaviour
{
   public void MoveToScene()
    {
        
        SceneManager.LoadScene("temperature");

        
    }
}
