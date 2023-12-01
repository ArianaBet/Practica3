using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class sub_menus : MonoBehaviour
{
     Button bttn_1_1, bttn_1_2, bttn_1_3, bttn_1_4;
      Button bttn_2_1, bttn_2_2, bttn_2_3, bttn_2_4;
       Button bttn_3_1, bttn_3_2, bttn_3_3, bttn_3_4;
     
     GameObject go;
     bool status;
    

    // Start is called before the first frame update
    void Start()
    {
       
        bttn_1_1 = GameObject.Find("bttn_1_1").GetComponent<Button>();
         bttn_1_2 = GameObject.Find("bttn_1_2").GetComponent<Button>();
          bttn_1_3 = GameObject.Find("bttn_1_3").GetComponent<Button>();
           bttn_1_4 = GameObject.Find("bttn_1_4").GetComponent<Button>();
           
         bttn_2_1 = GameObject.Find("bttn_2_1").GetComponent<Button>();
          bttn_2_2 = GameObject.Find("bttn_2_2").GetComponent<Button>();
           bttn_2_3 = GameObject.Find("bttn_2_3").GetComponent<Button>();
            bttn_2_4 = GameObject.Find("bttn_2_4").GetComponent<Button>();  
        
          bttn_3_1 = GameObject.Find("bttn_3_1").GetComponent<Button>();
           bttn_3_2 = GameObject.Find("bttn_3_2").GetComponent<Button>();
            bttn_3_3 = GameObject.Find("bttn_3_3").GetComponent<Button>();
             bttn_3_4 = GameObject.Find("bttn_3_4").GetComponent<Button>();
       
        bttn_1_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Orange_01 (2)")));             
         bttn_1_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Apple_01")));
          bttn_1_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Pear_01")));
           bttn_1_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Lemon_Grown_01")));
           
           bttn_2_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Wheat_Optimised_01")));
            bttn_2_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Carrot_01_M")));
             bttn_2_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Watermelon_01")));
              bttn_2_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Potato_01_L (5)")));
              
           bttn_3_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Sunflower_01")));
            bttn_3_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Road_GrassEdge_01 (1)")));
             bttn_3_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Flowers_01")));
              bttn_3_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Reeds_01")));
              
              status = false;
     
         } // end of Start() 
   
       
   // Update is called once per frame
    void Update()
    {
          if (Input.GetMouseButtonDown(0) && status) {
           
           Camera cmr = GameObject.Find("Camera").GetComponent<Camera>(); 
           Vector3 mouse_pstn = cmr.ViewportToWorldPoint(new Vector3(Input.mousePosition.x/Screen.width,0f,6f));
           Vector3 objt_pstn = new Vector3(mouse_pstn.x,0f, mouse_pstn.z);
           Instantiate(go,objt_pstn, Quaternion.identity);   
           
                                                      }     
                                                      
      } // end of Update()                                                
      
     
                         
    GameObject select_go(GameObject game_object) { 
    
    go = game_object; 
    status = true;
    return go;
   
                                               }
    
    
  }
   
           
         
           
           
           
         
            
          
                         
        
    

    
   
    






