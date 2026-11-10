using Unity.Cinemachine;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public CinemachineCamera cam;
    public ChickenScript[] flock;
    public int selectedIndex = 0;
    public FoxScript fox;
    public Transform farm;  
    public int savedCount = 0;
    public int neededTowin;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        neededTowin = Mathf.CeilToInt(flock.Length * 0.8f);
        cam.Follow = flock[selectedIndex].transform;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            flock[selectedIndex].Move(new Vector3(0, 0, 1));
            CheckFarm();
            fox.TakeTurn();
            
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            flock[selectedIndex].Move(new Vector3(0, 0, -1));
            CheckFarm();
            fox.TakeTurn();
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            flock[selectedIndex].Move(new Vector3(-1, 0, 0));
            CheckFarm();
            fox.TakeTurn();
            
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            flock[selectedIndex].Move(new Vector3(1, 0, 0));
            CheckFarm();
            fox.TakeTurn();
            
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectedIndex++;
            if (selectedIndex >= flock.Length)
            {
                selectedIndex = 0;
            }
            cam.Follow = flock[selectedIndex].transform;
        }



    }

    void CheckFarm()
    {
        ChickenScript chicken = flock[selectedIndex];   

        
        if (Mathf.Approximately(chicken.transform.position.x, farm.position.x) &&
            Mathf.Approximately(chicken.transform.position.z, farm.position.z))
        {
            savedCount++;                               // +1 saved
            chicken.gameObject.SetActive(false);        // hide it, like the moles
            Debug.Log("Saved: " + savedCount);

            if (savedCount >= neededTowin)
            {
                Debug.Log("YOU WIN");
            }
        }
    }
}
