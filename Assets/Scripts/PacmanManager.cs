using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanManager : MonoBehaviour
{
    [SerializeField]
    Transform[] transformArray;

    int lastTime;
    int lastMoveTime;
    float timer;

    public float speed = 0.01f;

    public Animator animatorController;
    public AudioClip noPellet;

    //Coroutine moveCoroutine;

    const float moveWait = 0.02f;
    //const float scaleWait = 2.0f;

    

    private Vector3 destination;
    Vector3 firstPoint = new Vector3(-12.5f, 13.5f, 0f);
    Vector3 secondPoint = new Vector3(-7.5f, 13.5f, 0f);
    Vector3 thirdPoint = new Vector3(-7.5f, 9.5f, 0f);
    Vector3 fourthPoint = new Vector3(-12.5f, 9.5f, 0f);

    void Start()
    {
        ResetTime();

        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 16.0f;

        SetDestination(secondPoint);

        GetComponent<AudioSource>().clip = noPellet;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if ((int)timer > lastTime)
        {
            lastTime = (int)timer;
            Debug.Log(lastTime);
            GetComponent<AudioSource>().Play();
        }

        if (timer > lastMoveTime + (int)moveWait)
        {
            lastMoveTime = (int)timer;
            MoveObjects();
        }
        //MoveObjects();
        //print(transformArray[0].position);
        //print(destination);
    }
    private void ResetTime()
    {
        lastTime = -1;
        lastMoveTime = 0;
        timer = 0.0f;

        //CancelInvoke("ScaleObjects");
        //InvokeRepeating("ScaleObjects", scaleWait, scaleWait);
    }


    private void MoveObjects()
    {
        /*if (transformArray[0].transform.position.y == firstPoint.y && transformArray[0].transform.position.x < secondPoint.x)
        {
            //currentPos.x += 0.01f;
            SetDestination(secondPoint);
            transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
            //transformArray[0].transform.position = transformArray[0].transform.position + a.normalized * 0.01;
            print("1");
        }

        if (transformArray[0].position.x == secondPoint.x && transformArray[0].position.y > thirdPoint.y)
        {
            //currentPos.y -= 0.01f;
            SetDestination(thirdPoint);
            transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
            //transformArray[0].position = transformArray[0].transform.position + b.normalized * 0.01f;
            print("2");
        }

        if (transformArray[0].position.y == thirdPoint.y && transformArray[0].position.x > fourthPoint.x)
        {
            //currentPos.x -= 0.01f;
            SetDestination(fourthPoint);
            transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
            //transformArray[0].position = transformArray[0].transform.position + c.normalized * 0.01f;
            print("3");
        }

        if (transformArray[0].position.x == fourthPoint.x && transformArray[0].position.y < firstPoint.y)
        {
            //currentPos.y += 0.01f;
            SetDestination(firstPoint);
            transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
            //transformArray[0].position = transformArray[0].transform.position + d.normalized * 0.01f;
            print("4");
        }*/
        

        // Move from firstPoint to secondPoint
        if (destination == secondPoint)
        {
            if (transformArray[0].position.x > -7.55f)
            {
                SetDestination(thirdPoint);
                
            }
            else
            {
                animatorController.SetBool("MoveRight", true);
                animatorController.SetBool("MoveUp", false);
                transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
                print("First To Second");
            }
        }

        // Move from secondPoint to thirdPoint
        if (destination == thirdPoint)
        {
            if (transformArray[0].position.y < 9.55f)
            {
                SetDestination(fourthPoint);
                
            }
            else
            {
                animatorController.SetBool("MoveDown", true);
                animatorController.SetBool("MoveRight", false);
                transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
                print("Second To Third");
            }
        }

        // Move from thirdPoint to fourthPoint
        if (destination == fourthPoint)
        {
            if (transformArray[0].position.x < -12.45f)
            {
                SetDestination(firstPoint);
            }
            else
            {
                animatorController.SetBool("MoveLeft", true);
                animatorController.SetBool("MoveDown", false);
                transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
                print("Third To Fourth");
            }
        }

        // Move from fourthPoint to firstPoint
        if (destination == firstPoint)
        {
            if (transformArray[0].position.y > 13.45f)
            {
                SetDestination(secondPoint);
                
            }
            else
            {
                animatorController.SetBool("MoveUp", true);
                animatorController.SetBool("MoveLeft", false);
                transformArray[0].transform.position = Vector3.Lerp(transformArray[0].position, destination, speed);
                print("Fourth To First");
            }
        }
    }

    public void SetDestination(Vector3 newPos)
    {
        destination = newPos;
    }
    /*
    private void ScaleObjects()
    {
        foreach (Transform trans in transformArray)
        {
            if (trans.localScale.x > 1.5f)
                trans.localScale = trans.localScale / 1.2f;
            else
                trans.localScale = trans.localScale * 1.2f;
        }
    }
    */

    /*
    IEnumerator RotateObjects(float randomDelay)
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(randomDelay);
            foreach (Transform trans in transformArray)
                trans.Rotate(new Vector3(0.0f, 0.0f, 90.0f));

        }

        moveCoroutine = null;
    }
    */


}
