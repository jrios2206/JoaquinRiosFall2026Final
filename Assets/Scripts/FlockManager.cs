using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public ChickenScript[] flock;
    public int selectedIndex = 0;
    public FoxScript fox;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            flock[selectedIndex].Move(new Vector3(0,0,1));
            fox.TakeTurn();
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            flock[selectedIndex].Move(new Vector3(0,0,-1));
            fox.TakeTurn();
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            flock[selectedIndex].Move(new Vector3(-1,0,0));
            fox.TakeTurn();
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            flock[selectedIndex].Move(new Vector3(1,0,0));
            fox.TakeTurn();
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectedIndex++;
            if (selectedIndex >= flock.Length)
            {
                selectedIndex = 0;
            }
        }
    }
}
