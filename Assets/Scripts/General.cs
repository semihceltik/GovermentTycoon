
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class General : MonoBehaviour
{
    public Text ParaText;
    public Text HalKText;
    public long HalkSayi = 1;
    public long HalkTutarSayi = 5;
    [SerializeField]
    public long ParaSayisi = 0;
    
    

    public void Update()
    {
        HalKText.text = (Convert.ToString(HalkSayi));
        ParaText.text = Convert.ToString(ParaSayisi);
        ParaSayisi += HalkSayi * 5;
    }
    public void NufusEkle()
    {
        if (ParaSayisi >= HalkTutarSayi)
        {
            ParaSayisi = ParaSayisi - HalkTutarSayi;
            HalkSayi++;
            HalkTutarSayi = HalkSayi * 5;
        }
    }
}

