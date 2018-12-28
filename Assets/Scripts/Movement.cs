using UnityEngine;

public class Movement : MonoBehaviour {

	Touch firstTouch;

	void Update () {

        /*if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began)
				firstTouch = touch;
			else if (touch.phase == TouchPhase.Moved) {
				Vector2 delta = firstTouch.position - touch.position;
				delta.Normalize ();
				//delta = camera.InverseTransformDirection (delta);
				transform.Rotate (delta * Time.deltaTime * 45);
			}
		}*/

#if UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE

        //Check if Input has registered more than zero touches
        if (Input.touchCount > 0)
        {
            //Store the first touch detected.
            Touch myTouch = Input.touches[0];

            //Check if the phase of that touch equals Began
            if (myTouch.phase == TouchPhase.Began)
            {
                //If so, set touchOrigin to the position of that touch
                firstTouch = myTouch;
            }

            //If the touch phase is not Began :
            else if (myTouch.phase == TouchPhase.Ended )
            {
                //Set touchEnd to equal the position of this touch
                Vector2 delta = firstTouch.position - myTouch.position;

                delta.Normalize();
                //delta = camera.InverseTransformDirection (delta);
                transform.Rotate(delta * Time.deltaTime * 45);

            }
        }

#endif //End of mobile platform dependendent compilation section started above with #elif



    }
}
