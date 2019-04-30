using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClick : MonoBehaviour
{
    public GameObject character;
    public GameObject boat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);

        character.transform.position = new Vector3(boat.transform.position.x, boat.transform.position.y + 10, boat.transform.position.z);
    }
}
