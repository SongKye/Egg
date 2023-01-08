using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private float verMv;
    private float horMv;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("moveCoroutine");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator moveCoroutine()
    {
        while (true)
        {
            verMv = moveRandom();
            horMv = moveRandom();
            transform.Translate(verMv, 0, horMv);
            Debug.Log("expired");
            yield return new WaitForSeconds(1f);
        }
        //yield return null;
    }

    float moveRandom()
    {
        float rt = Random.Range(-0.5f, 0.5f);
        return rt;
    }
}
