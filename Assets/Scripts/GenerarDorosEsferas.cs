using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GenerarDorosEsferas : MonoBehaviour
{
    [SerializeField]
    private GameObject[] doroEsferas = null;
    [SerializeField]
    protected List<Transform> spawnsDoroEsferas = new List<Transform>();
    [SerializeField]
    private Button btnLanzar;
    private void Start()
    {
        AgregarEventos(btnLanzar, EventTriggerType.PointerEnter);
    }

    // Update is called once per frame
    void Update()
    {
        EsperaGenerar();
    }

    public void GenerarDoro()
    {
        int indice = Random.Range(0, doroEsferas.Length);
        int indiceEsferas = Random.Range(0, spawnsDoroEsferas.Count);
        Debug.Log(indice);
        Debug.Log(indiceEsferas);
        Instantiate(doroEsferas[indice], spawnsDoroEsferas[indiceEsferas]);
    }

    IEnumerator EsperaGenerar()
    {
        yield return new WaitForSeconds(5);
        GenerarDoro();
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
