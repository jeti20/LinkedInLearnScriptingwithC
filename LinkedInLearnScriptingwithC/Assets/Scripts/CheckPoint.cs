using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckPoint : MonoBehaviour
{
    public TextMeshProUGUI UIText; //zmienna odnosz¹ca siê do Text z UI
    public GameObject CheckPointText;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        {
            StartCoroutine(CheckPointWord());
            UIText.text = "25m reached!";
        }
        
    }


    IEnumerator CheckPointWord()
    {
        CheckPointText.SetActive(true);
        yield return new WaitForSeconds(2);
        CheckPointText.SetActive(false);

    }    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
