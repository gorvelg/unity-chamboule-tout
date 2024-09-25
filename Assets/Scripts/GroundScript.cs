using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolScript : MonoBehaviour
{
    public TMP_Text PointsText;
    int compteur;

    void Start()
    {
        PointsText.text= "0";
        compteur = 0;
    }

    void OnTriggerEnter() {
        compteur++; // ajoute 1 à la valeur "compteur"
        Debug.Log(compteur); // Afficher la valeur de compteur dans la console (optionnel)
        PointsText.text = compteur.ToString(); // Remplace le texte de l'UI par la valeur de compteur
    }
}