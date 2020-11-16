using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemaslaYokOl : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerPatlama;
     GameObject oyunKontrol;
     OyunKontrol kontrol;
    
    void Start()
    {
          oyunKontrol= GameObject.FindGameObjectWithTag("oyunKontrol");
        kontrol = oyunKontrol.GetComponent<OyunKontrol>();
    }
    void OnTriggerEnter(Collider col)
    {
       if(col.tag != "sinir")
       {
        Destroy(col.gameObject);
        Destroy(gameObject);
        Instantiate(patlama, transform.position,transform.rotation);
        kontrol.ScoreArttir(1);
        
       }
       if(col.tag == "Player")
       {
            Instantiate(playerPatlama, col.transform.position, col.transform.rotation);
            kontrol.OyunBitti();
       }
    }
}
