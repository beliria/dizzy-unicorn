using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTuberias : MonoBehaviour
{
    private Transform myPosition;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        myPosition = GetComponent<Transform>();
        Invoke("Destroy", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        myPosition.position = myPosition.position + (Vector3.left * speed * Time.deltaTime);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
