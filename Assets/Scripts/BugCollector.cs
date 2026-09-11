using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.XR;

public class BugCollector : MonoBehaviour
{
    public Rigidbody2D BugBody;
    void Start()
    {

    }

    public void BugSpawner()
    {
        if (_numofBugsonField == maxnumofBugsonField)
        {
            return;
        }
        Instantiate(bugPrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
        bugTime = 5f;

    }
    //public BugCollector bugPrefab;
    public GameObject bugPrefab;
    public float GameTime = 60f;
    public float bugTime = 3f;
    public int _numofBugsonField;
    public int maxnumofBugsonField = 10;
    public TextMeshProUGUI ScoreText;
    public int BScore = 0;
    

    public void AddToScore(int amount)
    {
        BScore += amount;
        ScoreUi();
    }
    void Update()
    {
        if (bugTime > 0)
        {
            bugTime -= Time.deltaTime;

            bugTime -= Time.deltaTime;
            if (bugTime <= 0)
            {
                BugSpawner();
                bugTime = 3f;
            }

        }

        Vector2 vel = new Vector2(0, 0);
        BugBody.linearVelocity = vel;
    }

    void ScoreUi()
    {
        ScoreText.text = "Score" + BScore;
    }
}
