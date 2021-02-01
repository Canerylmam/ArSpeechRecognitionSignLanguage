using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechRecognizer : MonoBehaviour
{


    KeywordRecognizer KeywordRecognizerObj;
    public string[] Keywords_array;

    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        KeywordRecognizerObj = new KeywordRecognizer(Keywords_array);
        KeywordRecognizerObj.OnPhraseRecognized += OnKeywordsRecognized;
        KeywordRecognizerObj.Start();

        anim = GetComponent<Animator>();
    }

    void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("keyword" + args.text + "; Confidence " + args.confidence);
        ActionPerformer(args.text);

    }

    void ActionPerformer(string command)
    {
        if (command.Contains("merhaba"))
        {
            anim.Play("merhaba", -1, 0f);
        }
        if (command.Contains("hello"))
        {
            anim.Play("merhaba", -1, 0f);
        }

        if (command.Contains("how are you"))
        {
            anim.Play("how-are-you", -1, 0f);
        }
        if (command.Contains("i'm great"))
        {
            anim.Play("im-great", -1, 0f);
        }
        if (command.Contains("thank you"))
        {
            anim.Play("thank-you", -1, 0f);
        }
        if (command.Contains("iyiyim"))
        {
            anim.Play("im-great", -1, 0f);
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
