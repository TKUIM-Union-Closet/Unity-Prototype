using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;
using AngleSharp;
using AngleSharp.Dom;
using UnityEngine.UI;
using System;

public class Fashion : MonoBehaviour {

    private int cnt = 1;

    private string URl;
    private Image Image;
    private string path;
    public Text SearchTextBox;

    void Start(){
        
        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li.large > div.image_container > p.img > a.over > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);


            StartCoroutine(LoadPic(URl,path));




        }


    }



    // Update is called once per frame
    void Update () {
		
	}

    public void ChangeToDailyGirl()
    {
        SceneManager.LoadScene("DailyGirl");
    }

    public void ChangeToSocial()
    {
        SceneManager.LoadScene("Social");
    }

    public void ChangeToUnion()
    {
        SceneManager.LoadScene("Union");
    }

    public void Reload()
    {
        SceneManager.LoadScene("Fashion");
    }

    IEnumerator LoadPic(String URL,String Path){


        WWW www = new WWW(URL);
        while (!www.isDone)
        {
            //Debug.Log("Download image on progress" + www.progress);
            yield return null;
        }



        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log("Download failed");
        }
        else
        {
            //Debug.Log("Download succes");
            Texture2D texture = new Texture2D(1, 1);
            www.LoadImageIntoTexture(texture);

            Sprite sprite = Sprite.Create(texture,
                new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            Image = GameObject.Find("Canvas/Panel/Rect/Image_Area/" + cnt).GetComponent<Image>();
            Image.sprite = sprite;

            cnt++;

        }

    }

    public void Search(){

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/coordinate/?search_word="+GameObject.Find("SearchInput").GetComponent<InputField>().text;
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Uppon()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/tops/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Jacket()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/jacket-outerwear/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Skirt()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/skirt/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Lower()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/pants/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Shoes()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/shoes/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void Bag()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/bag/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }

    public void hat()
    {

        cnt = 1;

        IConfiguration config = Configuration.Default.WithDefaultLoader();
        string url = "https://wear.tw/category/hat/";
        IDocument doc = BrowsingContext.New(config).OpenAsync(url).Result;

        /*CSS Selector寫法*/
        //IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul li div.image_container p.img a.over img");//取得圖片
        IHtmlCollection<IElement> imgs = doc.QuerySelectorAll("ul > li > div.image > a.over > p.img > img");//取得圖片

        foreach (IElement img in imgs)
        {
            URl = "https:" + img.GetAttribute("data-original");
            Debug.Log(URl);

            StartCoroutine(LoadPic(URl, path));

        }

    }








}
