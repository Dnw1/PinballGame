using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour 
{
		public GameObject           leftFlipper;
		public GameObject           rightFlipper;
		
		private flipper             _leftFlipper;
		private flipper             _rightFlipper;
		
		void Start() {
			_leftFlipper = leftFlipper.GetComponent<flipper>();
			_rightFlipper = rightFlipper.GetComponent<flipper>();
			
		}
		
		void Update () {
				if (Input.GetButtonDown("Fire1")) {
					_leftFlipper.on();
				}
				if (Input.GetButtonUp("Fire1")) {
					_leftFlipper.off();
				}
		        if (Input.GetButtonDown("Fire2")) {
		        	_rightFlipper.on();
		        }
				if (Input.GetButtonUp("Fire2")) {
					_rightFlipper.off();
				}
		}
}
