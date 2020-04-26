using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour
{

    public Text horseText;
    public Text actionText;

    float horseDialogueDelay;
    float timer;
    string[] horseDialogue = { "NEIGH", "Neighhhh", "neigh..", "n e i g h", "nehhh" };
    int dialogueIndex;

    public bool showingHorseDialogue;

    bool haveKey;
    bool haveCarrot;

    bool showingActionDialgue;
    float actionDialogueDelay;
    float actionDialogueTimer;

    // Start is called before the first frame update
    void Start()
    {
        horseText.text = "";
        actionText.text = "";
        horseDialogueDelay = 4;
        dialogueIndex = 0;
        showingHorseDialogue = false;

        haveKey = false;
        haveCarrot = false;

        actionDialogueDelay = 3;
    }

    // Update is called once per frame
    void Update()
    {

        if (!showingHorseDialogue)
        {
            timer += Time.deltaTime;
            if (timer > horseDialogueDelay)
            {
                if (dialogueIndex < 4)
                {
                    horseText.text = horseDialogue[dialogueIndex];
                    dialogueIndex++;
                } else
                {
                    horseText.text = "the horse is dead :(";
                }
                showingHorseDialogue = true;
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timer = 0;
                horseText.text = "";
                showingHorseDialogue = false;
            }
        }

        if (showingActionDialgue)
        {
            actionDialogueTimer += Time.deltaTime;
            if (actionDialogueTimer > actionDialogueDelay)
            {
                actionDialogueTimer = 0;
                actionText.text = "";
                showingActionDialgue = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "carrot")
        {
            if (haveKey)
            {
                actionText.text = "Now you can feed the horse! Hurry!";
            } else if (!haveKey)
            {
                actionText.text = "The horse would eat this, but how can we get into the barn?";
            }

            showingActionDialgue = true;
            haveCarrot = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "key")
        {
            if (haveCarrot)
            {
                actionText.text = "Let's get in the barn and feed the horse!";
            } else if (!haveCarrot)
            {
                actionText.text = "Now we can open the barn door!";
            }

            showingActionDialgue = true;
            haveKey = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "padlock")
        {
            if (haveKey)
            {
                actionText.text = "Youve made it inside! That horse looks awfully hungry";
                Destroy(collision.gameObject);
            }
            else if (!haveKey)
            {
                actionText.text = "The door is locked";
            }
            showingActionDialgue = true;
        }
        if (collision.gameObject.name == "horse")
        {
            if (haveCarrot)
            {
                actionText.text = "You fed the horse! It happily eats the carrot.";
            }
            else if (!haveCarrot)
            {
                actionText.text = "The horse looks so hungry, find some food quick!";
            }
            showingActionDialgue = true;
        }
    }
}
