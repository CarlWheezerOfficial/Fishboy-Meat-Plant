using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public List<GameObject> targets;
    private float SR = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GOT;
    public bool IGA;
    public Button RB;
    private GameObject T;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SG()
    {
        IGA = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0); 
        T.gameObject.SetActive(false);
    }

    IEnumerator SpawnTarget()
    {
        while(IGA)
        {
            yield return new WaitForSeconds(SR);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int STA)
    {
        score += STA;
        scoreText.text = "Score: " + score;
    }

    public void RG()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GO()
    {
        GOT.gameObject.SetActive(true);
        RB.gameObject.SetActive(true);
        IGA = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
