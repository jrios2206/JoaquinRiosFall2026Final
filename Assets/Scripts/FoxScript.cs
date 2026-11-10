
using UnityEngine;

public class FoxScript : MonoBehaviour
{

    public float tileSize = 1f;
    public GameObject loseText;
    public ChickenScript[] chickens;
    public void TakeTurn()
    {
        Transform target = null;
        float closestDistance = Mathf.Infinity;
        for (int i = 0; i < chickens.Length; i++)
        {
            float distance = Vector3.Distance(transform.position, chickens[i].transform.position);
            if(!chickens[i].gameObject.activeSelf) continue;
            if (distance < closestDistance)
            {
                closestDistance = distance;
                target = chickens[i].transform;
            }

        }

        if (target == null)
        {
            return;
        }
        if (transform.position.x < target.position.x)
        {
            transform.position += new Vector3(tileSize, 0, 0);
        }
        else if (transform.position.x > target.position.x)
        {
            transform.position += new Vector3(-tileSize, 0, 0);
        }
        else if (transform.position.z < target.position.z)
        {
            transform.position += new Vector3(0, 0, tileSize);
        }
        else if (transform.position.z > target.position.z)
        {
            transform.position += new Vector3(0, 0, -tileSize);
        }
        if (Mathf.Approximately(transform.position.x, target.position.x)  && Mathf.Approximately(transform.position.z, target.position.z))
        {
            Debug.Log("Fox: " + transform.position + "  Chicken: " + target.position);
            loseText.SetActive(true);
            Debug.Log("Caught: ");
        }
    }
}
