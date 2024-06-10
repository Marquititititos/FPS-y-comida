using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    // Start is called before the first frame update

    public Text texto;
    int puntos = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = puntos.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLISIONASTE");

        PickupScript pickupScript = other.gameObject.GetComponent<PickupScript>();
        puntos += pickupScript.puntos;

        if (pickupScript.esComida == true)
        {
            Destroy(other.gameObject);
        }

    }
}
