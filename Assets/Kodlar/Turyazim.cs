using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Turyazim : MonoBehaviour
{
    public int tur;
    [SerializeField] TextMeshProUGUI tursayac;
    [SerializeField] TextMeshProUGUI Kazanma;

    void Start()
    {
        tur = PlayerPrefs.GetInt("tur");
        tursayac.text = tur.ToString();
        if(tur <= 30)
        { Kazanma.text = ("Yasasin aklindan tuttugun sayiyi buldum.."); }
        PlayerPrefs.SetInt("tur", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
