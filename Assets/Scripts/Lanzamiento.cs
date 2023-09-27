using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Lanzamiento : MonoBehaviour
{
    [SerializeField]
    private GameObject[] doroMunicion = null;
    [SerializeField]
    private GameObject puntoSpawn;
    [SerializeField]
    private Button btnLanzar;
    // Start is called before the first frame update
    void Start()
    {
        AgregarEventos(btnLanzar, EventTriggerType.PointerEnter);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerarDoro();
        }
    }

    public void GenerarDoro()
    {
        int indice = Random.Range(0, doroMunicion.Length);
        Instantiate(doroMunicion[indice], puntoSpawn.transform);
    }

    private void AgregarEventos(Button btn, EventTriggerType tipo)
    {
        EventTrigger triggerDown = btn.gameObject.AddComponent<EventTrigger>();
        var pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = tipo;
        pointerDown.callback.AddListener((e) => GenerarDoro());
        triggerDown.triggers.Add(pointerDown);
    }
}
