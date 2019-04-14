using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSpawn : MonoBehaviour
{
    public Transform imagePoint1;
    public Transform imagePoint2;
    public Transform imagePoint3;
    public Transform imagePoint4;
    public Transform imagePoint5;
    public Transform imagePoint6;

    public GameObject[] hotDogPrefab;
    public GameObject[] condiPrefab;

    public GameObject hotdogOnions;
    public GameObject hotdogCheese;

    public GameObject currentHotdog;
    public GameObject currentCondi;

    public static int whichHotdog;
    public static int whichCondi;


	void Start ()
    {


        Resetter();
        //StartCoroutine("ImageChange");

        /*if (whichCondi == 3)
        {
            Instantiate(hotdogOnions, .position, Quaternion.identity);

            Instantiate(hotdogCheese, imagePoint4.position, Quaternion.identity);

        }*/
    }
	
    public void Resetter ()
    {
        Destroy(currentCondi);
        Destroy(currentHotdog);

        //need to delete previous spawned food
        StartCoroutine("ImageChange");

    }

    void Update ()
    {

        if (HotdogBuild.timeToReset == true)
        {
            HotdogBuild.timeToReset= false;
            Resetter();

        }
	}

    public IEnumerator ImageChange()
    {
        yield return new WaitForSeconds(0.1f);

        whichHotdog = Random.Range(0, 3);
        whichCondi = Random.Range(0, 3);

        currentHotdog = Instantiate(hotDogPrefab[whichHotdog], imagePoint1.position, Quaternion.identity);

        currentCondi = Instantiate(condiPrefab[whichCondi], imagePoint2.position, Quaternion.identity);


    }
}
