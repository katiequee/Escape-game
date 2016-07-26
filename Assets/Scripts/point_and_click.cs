using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class point_and_click : MonoBehaviour {
    public Player smithy;
    public Text notify;
    public float timer;
    public GameObject paper1;
    public GameObject paper2;
    public GameObject paper3;
    public GameObject paper4;
    public GameObject keycard;
    public GameObject door;
    public GameObject green;
    public GameObject red;
	public VaultKeyPadHandler keypad;

	// Use this for initialization
	void Start () {
        notify.text = "WASD to move. Spacebar to close text and progress the game.";
        notify.gameObject.SetActive(true);
		keypad = new VaultKeyPadHandler();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            notify.gameObject.SetActive(false);
        }

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            /*if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Item")
            {
                hit.collider.gameObject.SetActive(false);
                Debug.Log("Got Item");
            }*/

            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Hammer")
            {
                hit.collider.gameObject.SetActive(false);
                Debug.Log("Picked up a hammer.");
                notify.text = "Picked up a hammer.";
                notify.gameObject.SetActive(true);
                smithy.hasHammer = true;
            }

            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Key")
            {
                hit.collider.gameObject.SetActive(false);
                Debug.Log("Picked up a key.");
                notify.text = "Picked up a key.";
                notify.gameObject.SetActive(true);
                smithy.hasKey = true;
            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Piggy") && smithy.hasHammer == true)
            {
                hit.collider.gameObject.SetActive(false);
                Debug.Log("Broke the piggy bank.");
                notify.text = "Broke the piggy bank.";
                notify.gameObject.SetActive(true);

            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Closet") && smithy.hasKey == true)
            {
                paper1.SetActive(true);
                Debug.Log("Unlocked the closet. A page fell out!");
                notify.text = "Unlocked the closet. A page fell out!";
                notify.gameObject.SetActive(true);

            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Piggy") && smithy.hasHammer == false)
            {
                Debug.Log("Seems like there's something inside.");
                notify.text = "Seems like there's something inside.";
                notify.gameObject.SetActive(true);

            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Closet") && smithy.hasKey == false)
            {
                Debug.Log("Locked.");
                notify.text = "Locked.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Painting")
            {
                paper4.SetActive(true);
                Debug.Log("A page fell out from behind the painting.");
                notify.text = "A page fell out from behind the painting.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Bulba")
            {
                Debug.Log("Let him live his life.");
                notify.text = "Let him live his life.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Keycard")
            {
                hit.collider.gameObject.SetActive(false);
                smithy.hasKeycard = true;
                Debug.Log("Got the key card.");
                notify.text = "Got the key card.";
                notify.gameObject.SetActive(true);

            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Card scanner") && smithy.hasKeycard == true)
            {
                door.SetActive(false);
                green.SetActive(true);
                red.SetActive(false);
                Debug.Log("Opened the door.");
                notify.text = "Opened the door.";
                notify.gameObject.SetActive(true);

            }
            else if ((Physics.Raycast(ray, out hit) && hit.collider.tag == "Card scanner") && smithy.hasKeycard == false)
            {
                Debug.Log("Looks like a card scanner.");
                notify.text = "Looks like a card scanner";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "pillow")
            {
                paper2.SetActive(true);
                Debug.Log("There's a piece of paper under the pillow.");
                notify.text = "There's a piece of paper under the pillow.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Chair")
            {
                Debug.Log("This chair is made of an unusually bouncy material. How curious.");
                notify.text = "This chair is made of an unusually bouncy material. How curious.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Lamp")
            {
                Debug.Log("Surprisingly, this is actually a lamp.");
                notify.text = "Surprisingly, this is actually a lamp.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "box")
            {
                Debug.Log("A couch that, when not in use, folds into an extremely easy to build box. Mankind's greatest invention.");
                notify.text = "A couch that, when not in use, folds into an extremely easy to build box. Mankind's greatest invention.";
                notify.gameObject.SetActive(true);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key1")
            {
                //Debug.Log("1");
                keypad.InputNumber(1);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key2")
            {
                //Debug.Log("2");
                keypad.InputNumber(2);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key3")
            {
                //Debug.Log("3");
                keypad.InputNumber(3);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key4")
            {
                //Debug.Log("4");
                keypad.InputNumber(4);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key5")
            {
                //Debug.Log("5");
                keypad.InputNumber(5);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key6")
            {
                //Debug.Log("6");
                keypad.InputNumber(6);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key7")
            {
                //Debug.Log("7");
                keypad.InputNumber(7);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key8")
            {
                //Debug.Log("8");
                keypad.InputNumber(8);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key9")
            {
                //Debug.Log("9");
                keypad.InputNumber(9);

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "key0")
            {
                //Debug.Log("0");
                keypad.InputNumber(0);

            }
        }
    }
	public class VaultKeyPadHandler
        {
            private int[] code = { 7, 3, 5, 9 };
            private int[] inputtedcode = new int[4];
            private int numberon = 0;

            public void InputNumber(int input)
            {
                inputtedcode[numberon] = input;
                if (numberon == 3) //Actually needs to be 3 even though there are 4 numbers because arrays start at 0 in C# hahaaaaaa
                {
                    if (Enumerable.SequenceEqual(code, inputtedcode))
                    {
                        //Correct code inputted
                        Debug.Log("Correct Code");
                    }
                    else
                    {
                        //Incorreect code inputted
                        Debug.Log("Incorrect Code");
                    }
                    numberon = 0;
                }
                else
                {
                    numberon++;
                }

            }
        }
}

