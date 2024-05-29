using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hardness : MonoBehaviour
{
    private Button B;
    private GM G;
    

    // Start is called before the first frame update
    void Start()
    {
        B = GetComponent<Button>();
        B.onClick.AddListener(SD);
        G = GameObject.Find("Game Manager").GetComponent<GM>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SD()
    {
        G.SG();
    }
}
