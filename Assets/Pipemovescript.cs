using UnityEngine;

public class Pipemovescript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadPoint = -40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadPoint)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
