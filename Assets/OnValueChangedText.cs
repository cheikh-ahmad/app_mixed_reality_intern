using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnValueChangedText : MonoBehaviour
{
private UnityEngine.UI.Text ValueText;

    private void Start()
    {
        ValueText = GetComponent<UnityEngine.UI.Text>();
    }

    public void OnSliderValueChanged(float value)
    {
        ValueText.text = value.ToString("0.00");
    }
}
