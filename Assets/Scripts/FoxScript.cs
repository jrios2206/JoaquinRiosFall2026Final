using UnityEngine;

public class FoxScript : MonoBehaviour
{
    public Transform Player;
    public float tileSize = 1f;
    public GameObject loseText;
    public void TakeTurn()
    {
        if (transform.position.x < Player.position.x)
        {
            transform.position += new Vector3(tileSize, 0, 0);
        }
        else if (transform.position.x > Player.position.x)
        {
            transform.position += new Vector3(-tileSize, 0, 0);
        }
        else if (transform.position.z < Player.position.z)
        {
            transform.position += new Vector3(0, 0, tileSize);
        }
        else if (transform.position.z > Player.position.z)
        {
            transform.position += new Vector3(0, 0, -tileSize);
        }
        if (transform.position == Player.position)
        {
            Debug.Log("Fox: " + transform.position + "  Chicken: " + Player.position);
            
            loseText.SetActive(true);
            Debug.Log("Caught: ");
        }
    }
}
