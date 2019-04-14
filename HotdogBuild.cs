using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogBuild : MonoBehaviour
{
    //The hotdog game object and animator
    public GameObject hotdogBun;
    Animator bunAnimator;
    bool hasHotdog = false;
    int condiAnim;
    public static bool timeToReset = false;

    public static bool resetTime
    {
        get { return timeToReset; }
        set { timeToReset = value; }
    }

    Dictionary<string, int> foodNum = new Dictionary<string, int>()
    {
        {"Hotdog 1(Clone)", 0},
        {"Hotdog 2(Clone)", 1},
        {"Hotdog 3(Clone)", 2},
        {"Hotdog Ketchup(Clone)", 3},
        {"Hotdog Mustard(Clone)", 4},
        {"Chili(Clone)", 5},
        
    };

    List<string> animNum = new List<string>()
    {
        "PH1", "PH2", "PH3", "KH1", "MH1", "CH1", 
        "KH2", "MH2", "CH2", "KH3", "MH3","CH3",
    };


    void Start ()
    {
        //This sets the parent of the bun to the spawnpoint
        hotdogBun.transform.parent = GameObject.Find("BunSpawn").transform;

        bunAnimator = GetComponent<Animator>();


    }
	
	void Update ()
    {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {


        int theNumber = foodNum[collision.gameObject.name];

        //Changes animation of bun
        if (!hasHotdog) //&& theNumber == ImageSpawn.whichHotdog)
        {
            if (theNumber == ImageSpawn.whichHotdog)
            { 
                //begins hotdog animation & sets up for condiment animation           
                bunAnimator.SetBool(animNum[ImageSpawn.whichHotdog], true);
                Destroy(collision.gameObject);
                hasHotdog = true;
            }

            else
            {
                PlayerScore.moreScore -= 100;
            }

        }

        //Offset theNumber by 3 to match the condiment value range from ImageSpawn
        else if (hasHotdog) // && (theNumber - 3) == ImageSpawn.whichCondi)
        {
            if ((theNumber - 3) == ImageSpawn.whichCondi)
            {
                condiAnim = theNumber + (ImageSpawn.whichHotdog * 3);
                bunAnimator.SetBool(animNum[condiAnim], true);
                Destroy(collision.gameObject);

                StartCoroutine("ResetAnim");
            }
            else
            {
                bunAnimator.SetBool(animNum[ImageSpawn.whichHotdog], false);
                hasHotdog = false;
                bunAnimator.SetTrigger("ResetBun");
                PlayerScore.moreScore -= 100;

            }

        }

    }

    public IEnumerator ResetAnim()
    {
        yield return new WaitForSeconds(1);
        bunAnimator.SetBool(animNum[ImageSpawn.whichHotdog], false);
        bunAnimator.SetBool(animNum[condiAnim], false);
        hasHotdog = false;
        bunAnimator.SetTrigger("ResetBun");
        timeToReset = true;
        PlayerScore.moreScore += 100;
        //GetComponent<ImageSpawn>().Resetter();

    }
}
