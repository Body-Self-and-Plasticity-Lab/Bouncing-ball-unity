using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bouncer
{
    public class Bouncer : MonoBehaviour
    {

        public Transform objectToMove, startPosition, endPosition;

        // Use this for initialization
        void Start()
        {
            objectToMove.position = startPosition.position;
        }

            // Update is called once per frame
            void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                Bounce(1f, 1f);
            }
        }

        public void Bounce(float bounceTime, float waitTime)
        {
            StartCoroutine(BounceRoutine(bounceTime, waitTime));
        }


        private IEnumerator BounceRoutine(float bounceTime, float waitTime)
        {
            float elapsedTime = 0f;

            //Forward
            while (elapsedTime < bounceTime)
            {
                elapsedTime += Time.deltaTime;
                objectToMove.position = Vector3.LerpUnclamped(startPosition.position, endPosition.position, elapsedTime / bounceTime);
                yield return null;
            }

            elapsedTime = 0;

            yield return new WaitForFixedTime(waitTime);

            //Return
            while (elapsedTime < bounceTime)
            {
                elapsedTime += Time.deltaTime;
                objectToMove.position = Vector3.LerpUnclamped(endPosition.position, startPosition.position, elapsedTime / bounceTime);
                yield return null;
            }
        }
    }
}
