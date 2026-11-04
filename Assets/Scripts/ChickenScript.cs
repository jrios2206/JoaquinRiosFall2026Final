using UnityEngine;

public class ChickenScript : MonoBehaviour
{
    public float tileSize = 1f;

    public void Move(Vector3 direction)
    {
        transform.position += direction *  tileSize;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
