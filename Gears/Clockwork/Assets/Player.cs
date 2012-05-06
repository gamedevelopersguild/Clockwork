using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public CharacterController cc;

	public enum CharacterState{Idle = 0, Walk = 1, Jump = 2, Fire = 3};
	public CharacterState current = CharacterState.Idle;
	public GearProjectile gear;
	public GameObject explosion; //spawnPoint,
				      //explosion;
	
	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
	private Vector3 unchangedMoveDirection = Vector3.zero;
	

	public Camera playCam;
	public bool isJumping = false;
	public float health ;
	public float nextRespawn = 0;
	public bool mustRespwan = false;
		
	public Vector3 start;
	public Main gears;

	
	void Start () 
	{
		health = 100f;
		start = transform.position;
		//rigidbody.freerotation = true ;	
	}


	void Update () 
	{
		movement();
		if(nextRespawn < Time.timeSinceLevelLoad && mustRespwan)
		{
			// Respawn
			mustRespwan = false;
			transform.position = start;
			gears.substractStuff(50);
		
		}
	}
	
	void OnTriggerEnter(Collider current)
	{
		if (current.tag == "Respawn" )
		{
			iExploded() ;
			//previousTime = Time.timeSinceLevelLoad;
			//iExploded() ;
			
			nextRespawn = Time.timeSinceLevelLoad + 0.3f;
			mustRespwan = true;
		}
	}
	
	
	private void FaceForward() {
		int facingAngle = 0;
		if(unchangedMoveDirection.x > 0) facingAngle = 90;
		if(unchangedMoveDirection.x < 0) facingAngle = 270;
		
		//print("Camera: "+ playCam.transform.eulerAngles.y);
		Vector3 lastAngle = playCam.transform.eulerAngles;
		Vector3 lastPos = playCam.transform.position;
		if(unchangedMoveDirection.x != 0) 
		{
			gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x,
	                                          			facingAngle,
                                              			transform.eulerAngles.z);
			// Keep the camera in the same position as it was before.
			playCam.transform.position = new Vector3(lastPos.x, playCam.transform.position.y, lastPos.z);
			//playCam.transform.eulerAngles = new Vector3(playCam.transform.eulerAngles.x,
	        //                                 			facingAngle,
            //                                  			playCam.transform.eulerAngles.z);
		}
		// Keep the camera facing the same way always.
		playCam.transform.eulerAngles = lastAngle;
		//print("Camera: "+ playCam.transform.eulerAngles.y);
		
	}
	
	public void movement()
	{	
		if (cc.isGrounded) 
		{
			moveDirection = Vector3.right * Input.GetAxis("Horizontal");
			
			if(Input.GetAxis("Horizontal") != 0 || Input.acceleration.x > 0.2f || Input.acceleration.x < -0.2f) 
			{
				animation.CrossFade("Run");	
				if (Input.acceleration.x > 0.2f)
				{
					moveDirection = Vector3.right;
				}
				else if (Input.acceleration.x < -0.2f)
				{
					moveDirection = Vector3.left;
				}
			}
			else animation.CrossFade("NormalIdle");
			
			unchangedMoveDirection = moveDirection;
			FaceForward();

            moveDirection *= speed;
            if (Input.GetButton("Jump") ||  Input.touchCount > 0) {
                moveDirection.y = jumpSpeed;
			}
            
        }
		
		if(!cc.isGrounded) {
			animation.Play("Jump"); 
		}
        moveDirection.y -= gravity * Time.deltaTime;
		

		//Hardcode the z axis to 0, to make motion 2D.
		moveDirection.z = 0;
        cc.Move(moveDirection * Time.deltaTime);
	}
	
	public virtual void takeDamage(float damage)
	{
		if (health - damage <= 0)
			damage = health ;
		
		health -= damage;
		
		if(health == 0f)
		{
			iExploded();
			Destroy(gameObject);
		}
	}
	
	public virtual void iExploded()
	{
		Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation) ;
		//if(Time.timeSinceLevelLoad -previousTime > 1)
		//{
		//	transform.position = start;
		//	gears.substractStuff(50);
		//	previousTime = Time.timeSinceLevelLoad;
		//}
	}
	
	public virtual float getHealth()
	{
		return health;
	}
}