using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text PuntajeText;
    public Text VidaText;

    public void PrintPuntaje(int puntos) {
        PuntajeText.text = "Monedas: " + puntos;
    }

    public void PrintVida(int vida) {
        VidaText.text = "Vidas: " + vida;
    }
}
