using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float deltaTime;

    private void Start()
    {
        deltaTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && deltaTime > 2.0f)
        {
            deltaTime = 0.0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
