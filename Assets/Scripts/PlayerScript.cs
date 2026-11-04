using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float tilesize = 1f;
    public FoxScript fox;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
            transform.position += new Vector3(0, 0, tilesize);
            fox.TakeTurn();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
            transform.position += new Vector3(0, 0, -tilesize);
            fox.TakeTurn();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
            transform.position += new Vector3(tilesize, 0,0);
            fox.TakeTurn();

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
            transform.position += new Vector3(-tilesize, 0, 0);
            fox.TakeTurn();

        }
    }
}
