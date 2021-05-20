using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ComidaPicker : MonoBehaviour
{
    private float comidaPickeada = 0;
    public TextMeshProUGUI textoMonedas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Comida")
        {
            comidaPickeada++;
            textoMonedas.text = comidaPickeada.ToString();
            Destroy(other.gameObject);
        }
    }
}
