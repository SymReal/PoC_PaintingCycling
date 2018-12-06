/*  author: Antoine Posnic
 *  mail:   contact@posnicantoine.pro
 *  
 *  current status: Student Master 2 IL Rennes 1 University
 *  date: late 2018
 *   
 **/



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingBehavior : MonoBehaviour {
    
    //path of a file filled only of Pictures URLs each lines.
    public string _path;
    //seconds after a refresh is needed.
    public float _secAfterRefresh;

    private List<string> _lines = new List<string>();
    private float _count;
    private IEnumerator _coroutine;


    //initialisation of the links
    private void Start()
    {
        System.IO.StreamReader file = new System.IO.StreamReader(@_path);

        foreach(string line in file.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None))
        {
            _lines.Add(line);
        }
    }


    //call every frames
    void Update ()
    {
        //count
        if (_count >= _secAfterRefresh)
        {
            Debug.Log("New load");

            String url = _lines[UnityEngine.Random.Range(0, _lines.Count)];
            _coroutine = LoadOntoTexture(url);
            StartCoroutine(_coroutine);
            _count = 0;
        }
        else
        {
            _count += Time.deltaTime;
        }
    }


    //Coroutine for downloading and attach the new texture.
    private IEnumerator LoadOntoTexture(String url_)
    {
        Texture2D tex;

        using (WWW www = new WWW(url_))
        {
            yield return www;
            Debug.Log(url_ );
            tex = new Texture2D(www.texture.width, www.texture.height, TextureFormat.DXT1, false);
            www.LoadImageIntoTexture(tex);
            GetComponent<Renderer>().material.mainTexture = tex;

            //Dispose doesn't seem to do his job well
            www.Dispose();
        }
    }
}
