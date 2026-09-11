using UnityEditor.Build.Content;
using UnityEngine;

public class bug : MonoBehaviour
{
    public BugCollector BugCount;
    void Start()
    {
        //BugCollector GameManager = GameObject.FindFirstObjectByType<BugCollector>();
        BugCount = GameObject.FindFirstObjectByType<BugCollector>();


        if (BugCount == null )
        {
            Debug.Log("Error");
        }
    }

    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (BugCount != null)
        {
            BugCount.BScore++;
            
            Destroy(gameObject);
            Debug.Log("Clicked");
        }
        
    }
}
