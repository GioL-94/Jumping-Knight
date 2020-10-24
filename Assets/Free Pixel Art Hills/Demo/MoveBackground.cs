using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBackground : MonoBehaviour {


	[Range(0f, 0.20f)]
	public float ParallaxSpeed = 0.2f;
	public RawImage Background;
	public RawImage Hill;
	public RawImage Tree2;
	public RawImage Tree1;
	public RawImage plat2;
	public GameObject uiIdle;

	public enum GameState { Idle, Playing };
	public GameState gamestate = GameState.Idle;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		//Empieza el juego

		if(gamestate == GameState.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)))
        {
			gamestate = GameState.Playing;
			uiIdle.SetActive(false);
        }else if(gamestate == GameState.Playing)
        {//cambio de estado a playing
			Parallax();
		}

		
	}

	void Parallax()
    {
		float finalSpeed = ParallaxSpeed * Time.deltaTime;
		Background.uvRect = new Rect(Background.uvRect.x + finalSpeed, 0f, 1f, 1f);
		Hill.uvRect = new Rect(Hill.uvRect.x + finalSpeed * 0.5f, 0f, 1f, 1f);
		Tree2.uvRect = new Rect(Tree2.uvRect.x + finalSpeed, 0f, 1f, 1f);
		Tree1.uvRect = new Rect(Tree1.uvRect.x + finalSpeed, 0f, 1f, 1f);
		plat2.uvRect = new Rect(plat2.uvRect.x + finalSpeed * 1.5f, 0f, 1f, 1f); 
	}
}
