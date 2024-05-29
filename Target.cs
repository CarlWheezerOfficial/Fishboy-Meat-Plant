using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody RB;
    private float MiS = 12;
    private float MaS = 16;
    private float MT = 10;
    private float xR = 4;
    private float ySP = 1;
    private GM G;
    public int PV;
    public ParticleSystem ExP;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(RF(), ForceMode.Impulse);
        RB.AddTorque(RT(), ForceMode.Impulse);
        transform.position = RSP();
        G = GameObject.Find("Game Manager").GetComponent<GM>();
    }

    Vector3 RF()
    {
        return Vector3.up * Random.Range(MiS,MaS);
    }

    Vector3 RT()
    {
        float x = Random.Range(-MT, MT);
        float y = Random.Range(-MT, MT);
        float z = Random.Range(-MT, MT);
        return new Vector3(x, y, z);
    }

    Vector3 RSP()
    {
        return new Vector3(Random.Range(-xR, xR), -ySP);
        
    }

    private void OnMouseDown()
    {
        if(G.IGA)
        {
            Destroy(gameObject);
            Instantiate(ExP, transform.position, transform.rotation);
            G.UpdateScore(PV);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad")) 
        {
            G.GO();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
