using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerSOS : MonoBehaviour{

    public int whoseTurn, turnCounter, thatNumber;

    public List<Sprite> playerIcons; // s=1, o = 0
    public Button[] sosSpaces;
    public Button resetButton;
    public Button sButton;
    public Button oButton;
    public List<int> Liste;
    public GameObject[] turnIcons;

    public int count1, count2;

    public Text p1, p2;



    public bool finish = false;



    void Start(){
    
    InitialisePageComponents();

    
    }
    public void InitialisePageComponents(){
        whoseTurn = 0;
        turnCounter = 0;
        count1 = 0;
        count2 = 0;

        finish = false;
        for(int i = 0; i<81; i++){
        Liste[i] = 10;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
        //Debug.Log("burası");
            
        }
        for(int i = 0; i<sosSpaces.Length; i++){
            sosSpaces[i].interactable = true;
            sosSpaces[i].image.sprite = null;
            

        }


        sButton.onClick.AddListener(sButtonClick);
        oButton.onClick.AddListener(oButtonClick);
    }
    public void sButtonClick(){
        whoseTurn = 1;
        turnIcons[0].SetActive(false);
        turnIcons[1].SetActive(true);
    }
    public void oButtonClick(){
        whoseTurn = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
    }    

    public void sosButton(int whichNumber){
        sosSpaces[whichNumber].interactable = false;
        sosSpaces[whichNumber].image.sprite = playerIcons[whoseTurn];
        

        if(whichNumber < 5){
            thatNumber =whichNumber+20;
  
        }
        else if(whichNumber <10){
            thatNumber = whichNumber+24;

        }
        else if(whichNumber <15){
            thatNumber =whichNumber+28;

        }else if(whichNumber <20){
            thatNumber = whichNumber+32;
        }
        else{
            thatNumber = whichNumber+36;

        }
        Liste[thatNumber]=whoseTurn;
        
        Check(thatNumber);

        
    }

    public void Check(int whichNumber){
        if(Liste[whichNumber]+ Liste[whichNumber+1]+ Liste[whichNumber+2] == 2 && Liste[whichNumber+1] == 0){
            Debug.Log("Doru");
            Sayac();
        }
        if(Liste[whichNumber-1]+ Liste[whichNumber]+Liste[whichNumber+1]==2 && Liste[whichNumber] == 0){
            Sayac();
            Debug.Log("2");
        }
        if(Liste[whichNumber-2]+ Liste[whichNumber-1]+ Liste[whichNumber] == 2 && Liste[whichNumber-1] ==0){
            Sayac();
            Debug.Log("3");
        }

        if(Liste[whichNumber]+ Liste[whichNumber+9]+ Liste[whichNumber+18] == 2 && Liste[whichNumber+9] == 0){
            Sayac();
            Debug.Log("4");
        }
        if(Liste[whichNumber-9]+ Liste[whichNumber]+ Liste[whichNumber+9] == 2 && Liste[whichNumber] == 0){
            Sayac();
            Debug.Log("5");
        }
        if(Liste[whichNumber-18]+ Liste[whichNumber-9]+ Liste[whichNumber] == 2 && Liste[whichNumber-9] == 0){
            Sayac();
            Debug.Log("6");
        }

        if(Liste[whichNumber]+ Liste[whichNumber+10]+ Liste[whichNumber+20] == 2 && Liste[whichNumber+10] == 0){
            Sayac();
            Debug.Log("7");
        }
        if(Liste[whichNumber-10]+ Liste[whichNumber]+ Liste[whichNumber+10] == 2 && Liste[whichNumber] == 0){
            Sayac();
            Debug.Log("8");
        }
        if(Liste[whichNumber-20]+ Liste[whichNumber-10]+ Liste[whichNumber] == 2 && Liste[whichNumber-10] == 0){
            Sayac();
            Debug.Log("9");
        }

        if(Liste[whichNumber]+ Liste[whichNumber+8]+ Liste[whichNumber+16] == 2 && Liste[whichNumber+8] == 0){
            Sayac();
            Debug.Log("10");
        }
        if(Liste[whichNumber-8]+ Liste[whichNumber]+ Liste[whichNumber+8] == 2 && Liste[whichNumber] == 0){
            Sayac();
            Debug.Log("11");
        }
        if(Liste[whichNumber-16]+ Liste[whichNumber-8]+ Liste[whichNumber] == 2 && Liste[whichNumber-8] == 0){
            Sayac();
            Debug.Log("12");
        }



        turnCounter ++;
    }
    public void Sayac(){

        if(turnCounter%2 == 0){
            count1++;
            p1.GetComponent<Text>().text = count1.ToString();

        }
        else{
            count2++;
            p2.GetComponent<Text>().text = count2.ToString();

        }
        
    }

}
