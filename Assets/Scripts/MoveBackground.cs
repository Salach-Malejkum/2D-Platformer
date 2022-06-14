using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

	public float speed;
	private float x;
	private bool move;
	public float PontoDeDestino;
	public float PontoOriginal;
	public bool movementLeft = false;
	public bool movementRight = false;
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.A) || movementLeft)
        {
            x = transform.position.x;
			x += -speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);

			if (x >= PontoOriginal)
			{
				x = PontoDeDestino;
				transform.position = new Vector3 (x, transform.position.y, transform.position.z);
			}
        }
        else if (Input.GetKey(KeyCode.D) || movementRight)
        {
            x = transform.position.x;
			x += speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);

			if (x <= PontoDeDestino)
			{
				x = PontoOriginal;
				transform.position = new Vector3 (x, transform.position.y, transform.position.z);
			}
        }
	}
}
