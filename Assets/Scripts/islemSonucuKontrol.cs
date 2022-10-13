using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class islemSonucuKontrol : MonoBehaviour
{
    public Text ilksayitext, islemtext, ikincisayitext, sonuctext, dogruveyayanlistext;
    public InputField sonucınputFieldtext;
    int ilksayi, ikincisayi, islemturu;
    // Start is called before the first frame update
    void Start()
    {
        yenisoru();
    }
    int kullaniciningirdigi = 0, islemingerceksonucu;
    // Update is called once per frame
    void Update()
    {
        if (sonuctext.text != "")
        {
            
            kullaniciningirdigi = int.Parse(sonuctext.text);
            switch (islemturu)
            {
                case 1:
                    islemingerceksonucu = ilksayi + ikincisayi;
                    break;
                case 2:
                    islemingerceksonucu = ilksayi - ikincisayi;
                    break;
                case 3:
                    islemingerceksonucu = ilksayi * ikincisayi;
                    break;
                case 4:
                    islemingerceksonucu = ilksayi / ikincisayi;
                    break;
            }
            if (islemingerceksonucu == kullaniciningirdigi)
            {
                dogruveyayanlistext.text = "Doğru girdiniz";
            }
            else
            {
                dogruveyayanlistext.text = "Yanlış girdiniz";
            }
            
        }
    }
    public void yenisoru()
    {
        ilksayi = Random.Range(1, 21);
        ikincisayi = Random.Range(1, 21);
        islemturu = Random.Range(1, 5);
        while (ilksayi < ikincisayi)
        {
            ilksayi = Random.Range(1, 20);
            ikincisayi = Random.Range(1, 20);
        }
        ilksayitext.text = ilksayi.ToString();
        ikincisayitext.text = ikincisayi.ToString();

        switch (islemturu)
        {
            case 1:
                islemtext.text = "+";
                break;
            case 2:
                islemtext.text = "-";
                break;
            case 3:
                islemtext.text = "x";
                break;
            case 4:
                islemtext.text = "/";
                break;
        }
        

        sonucınputFieldtext.text ="" ;
        dogruveyayanlistext.text = "";
        
    }

}
