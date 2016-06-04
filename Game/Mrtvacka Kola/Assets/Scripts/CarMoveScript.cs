using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarMoveScript : MonoBehaviour {


    public Text timeInGame;
    public string vrijemeProvedeno;
    float time;
    float ubrzanje;
    int i;

	void Start () {
        time = 0.1f;
        ubrzanje = 1;
	}

    // Update is called once per frame
    void Update() {

        if (i > 100) {
            ubrzanje += 0.1f;
            i = 0;
                }
        if (transform.position.y >= 60)
        {
            vrijemeProvedeno = time.ToString();
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.forward * (-0.5f));

        }
        else if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.forward * 0.5f);

        }
        transform.Translate(Vector3.right *  ubrzanje);
        time += Time.deltaTime;
        i++;
        timeInGame.text = "SCORE: " + time.ToString();
       }

       
    
}
