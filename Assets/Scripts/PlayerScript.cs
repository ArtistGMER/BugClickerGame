using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D Hand;
    void Start()
    {
        //UpdateScore();
        Invoke("SpawnCoin",3);


    }

    public void SpawnCoin()
    {
        Instantiate(CoinPrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
    }
    public CoinScript CoinPrefab;

    // to keep tract of time, we must have a timer variable 
    public float Timer = 3;
// time.deltatime  is used for keeping track of time, usually in real time. Its also sused to keep track of
// how much time has passed since the last frame, OR since the last update 


    void Update()
    {
        // this makes it so that the time subtracts as the timer goes down. Once it hits 0, it spawns a coin. But 
        //after that, it stays at -0.1, which is below 0. HENCE WHY it wont spawn another coin!
        if (Timer > 0)
     {
            Timer -= Time.deltaTime;
        
        Timer -= Time.deltaTime; // this is the default line of code for timer based coding
        if (Timer <= 0 ) 
        {
            //Timer = 3;
            SpawnCoin();
            //Instantiate(CoinPrefab, new Vector3(Random.Range(-8f,8f), Random.Range(-4f,4f)), Quaternion.identity);
        }
     }
        // this says " when timer hits 0, spawn a coin, and then reset the time to 3. Repeat the fuction" 
        Vector2 vel = new Vector2(0, 0);

        Hand.linearVelocity = vel;

        
    }
}
