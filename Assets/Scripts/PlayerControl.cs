using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public Animator animator;

	private bool _firing;

	void Update () {
		if ( Input.GetButton("Fire1") ) {
			_firing = true;
		} else {
			_firing = false;
		}
	}

	void FixedUpdate() {
		animator.SetBool("IsFiring", _firing);
	}
}
