using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControle : MonoBehaviour
{

    Rigidbody fizik;
    float horizontal =0;
    float vertical =0;
    Vector3 vec;
    float playerHiz = 3.3f;

    float minX = -2.88f;
    float maxX = 2.88f;
    float minZ =-3.8f;
    float maxZ=-0.73f;


    float atesZamani =0f;
    float atesGecenSure =0f;
    public GameObject mermi;
    public Transform mermiCikisYeri;

    AudioSource audio;
    
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButton("Ates") && Time.time > atesZamani)
        {
            atesZamani = Time.time +0.1f; // her 0.1 saniyede bir ateş etmeyi sağlar.
            
            Instantiate(mermi, mermiCikisYeri.position , Quaternion.identity ); // Instantiate (object, position, rotation);

             audio.Play();
        }
    }

    void FixedUpdate()
    {
        //yatay ve dikey yönlü inputları alıp hareket ettirmek için.
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3 (horizontal,0,vertical);
        fizik.velocity = vec*playerHiz;
    

        //Player objesi ekrandan çıkmasın diye.
        fizik.position = new Vector3
        (
            Mathf.Clamp(fizik.position.x, minX, maxX),
            -2.05f,
            Mathf.Clamp(fizik.position.z, minZ, maxZ)
        );

        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-5f); // sağa sola hareket ettikçe player'ın 3d görüntü elde etmesi için.
    }
}
