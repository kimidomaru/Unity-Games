using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpawn : MonoBehaviour {

    [SerializeField]
    float maxTime = 1;

    private float timer = 0;

    [SerializeField]
    GameObject cano;

    [SerializeField]
    float altura;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(timer > maxTime) {
            GameObject novoCano = Instantiate(cano);
            novoCano.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(novoCano, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
