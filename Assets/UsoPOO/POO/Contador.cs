using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public static int contador = 0;

    TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI.text = "Doro conteo: " + contador.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = "Doro conteo: " + contador.ToString();
    }
}
