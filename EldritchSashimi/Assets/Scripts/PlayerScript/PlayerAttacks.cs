using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttacks : MonoBehaviour
{
    public float timeRemaining = 10;
    public float maxTime = 10;
    public GameObject knifeAttackZone;
    private bool timerIsRunning;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerInput>();
        knifeAttackZone.gameObject.SetActive(false);
        timeRemaining = maxTime;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                knifeAttackZone.gameObject.SetActive(false);
            }
            else
            {
                ResetCooldown();
            }
        }
    }

    private void ResetCooldown()
    {
        timeRemaining = maxTime;
        timerIsRunning = true;
        knifeAttackZone.gameObject.SetActive(true);
        Debug.Log("Time has started over");
    }
}
