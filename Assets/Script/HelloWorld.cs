using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int speed = 10;
    public GameObject helloText;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        helloText.GetComponent<TextMeshPro>().text = "AgHaAAAAaAa!";
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello World: Part 2");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    }
}
