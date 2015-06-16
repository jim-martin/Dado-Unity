//uScript Generated Code - Build 0.9.2255
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class lift_make_your_lift : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _Person_Controller = null;
   UnityEngine.GameObject _Person_Controller_previous = null;
   public UnityEngine.KeyCode BOTTOM = UnityEngine.KeyCode.None;
   UnityEngine.GameObject local_11_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_11_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_13_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_13_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_40_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_40_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_42_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_42_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_44_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_44_UnityEngine_GameObject_previous = null;
   System.String local_47_System_String = "";
   System.String local_49_System_String = "";
   System.String local_51_System_String = "";
   UnityEngine.GameObject local_etage_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_etage_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject_previous = null;
   public UnityEngine.KeyCode TOP = UnityEngine.KeyCode.None;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_1 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_1 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_1 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_1 = (bool) true;
   System.Boolean logic_uScriptCon_CompareGameObjects_ReportNull_1 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_1 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_3 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_3 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_3 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_3 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_3;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_3;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_3;
   bool logic_uScriptAct_GetChildrenByName_Out_3 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_3 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_3 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_4 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_4 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_4;
   bool logic_uScriptAct_GetParent_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_Teleport logic_uScriptAct_Teleport_uScriptAct_Teleport_5 = new uScriptAct_Teleport( );
   UnityEngine.GameObject[] logic_uScriptAct_Teleport_Target_5 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_Teleport_Destination_5 = null;
   System.Boolean logic_uScriptAct_Teleport_UpdateRotation_5 = (bool) false;
   bool logic_uScriptAct_Teleport_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_6 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_6 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_6 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_6 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_6 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_6 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_8 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_8 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_8;
   bool logic_uScriptAct_GetParent_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_9 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_9 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_9 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_9 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_9;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_9;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_9;
   bool logic_uScriptAct_GetChildrenByName_Out_9 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_9 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_9 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_15 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_15 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_15;
   bool logic_uScriptAct_GetParent_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_17 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_17 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_19 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_19 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_19 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_19 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_19 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_19;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_19;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_19;
   bool logic_uScriptAct_GetChildrenByName_Out_19 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_19 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_19 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_20 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_20 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_20 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_20 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_20 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_20 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_22 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_22 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_22 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_22 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_25 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_25 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_25 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_25 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_25 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_25;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_25;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_25;
   bool logic_uScriptAct_GetChildrenByName_Out_25 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_25 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_25 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_26 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_26 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_26;
   bool logic_uScriptAct_GetParent_Out_26 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_27 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_27 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_27 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_27 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_27 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_27 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_29 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_29 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_29 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_29 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_30 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_30 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_30 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_30 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_30 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_30 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_31 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_31 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_31 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_31 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_31 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_31;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_31;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_31;
   bool logic_uScriptAct_GetChildrenByName_Out_31 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_31 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_31 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_35 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_35 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_35;
   bool logic_uScriptAct_GetParent_Out_35 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_38 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_38 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_38 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_38 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_38 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_39 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_39 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_39;
   bool logic_uScriptAct_GetParent_Out_39 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_41 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_41 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_41;
   bool logic_uScriptAct_GetParent_Out_41 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_43 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_43 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_43;
   bool logic_uScriptAct_GetParent_Out_43 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_45 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_45 = null;
   System.String logic_uScriptAct_GetGameObjectName_name_45;
   bool logic_uScriptAct_GetGameObjectName_Out_45 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_46 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_46 = "";
   System.String logic_uScriptCon_CompareString_B_46 = "detect_lift_last";
   bool logic_uScriptCon_CompareString_Same_46 = true;
   bool logic_uScriptCon_CompareString_Different_46 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_48 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_48 = "";
   System.String logic_uScriptCon_CompareString_B_48 = "detect_lift_1st";
   bool logic_uScriptCon_CompareString_Same_48 = true;
   bool logic_uScriptCon_CompareString_Different_48 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_50 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_50 = null;
   System.String logic_uScriptAct_GetGameObjectName_name_50;
   bool logic_uScriptAct_GetGameObjectName_Out_50 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_52 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_52 = "";
   System.String logic_uScriptCon_CompareString_B_52 = "detect_lift_middle";
   bool logic_uScriptCon_CompareString_Same_52 = true;
   bool logic_uScriptCon_CompareString_Different_52 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_53 = null;
   System.String logic_uScriptAct_GetGameObjectName_name_53;
   bool logic_uScriptAct_GetGameObjectName_Out_53 = true;
   //pointer to script instanced logic node
   uScriptAct_SendCustomEvent logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54 = new uScriptAct_SendCustomEvent( );
   System.String logic_uScriptAct_SendCustomEvent_EventName_54 = "stop";
   uScriptCustomEvent.SendGroup logic_uScriptAct_SendCustomEvent_sendGroup_54 = uScriptCustomEvent.SendGroup.Children;
   UnityEngine.GameObject logic_uScriptAct_SendCustomEvent_EventSender_54 = null;
   bool logic_uScriptAct_SendCustomEvent_Out_54 = true;
   //pointer to script instanced logic node
   uScriptAct_SendCustomEvent logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_55 = new uScriptAct_SendCustomEvent( );
   System.String logic_uScriptAct_SendCustomEvent_EventName_55 = "go";
   uScriptCustomEvent.SendGroup logic_uScriptAct_SendCustomEvent_sendGroup_55 = uScriptCustomEvent.SendGroup.Children;
   UnityEngine.GameObject logic_uScriptAct_SendCustomEvent_EventSender_55 = null;
   bool logic_uScriptAct_SendCustomEvent_Out_55 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_0 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = null;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptCon_CompareGameObjects_B_1 || false == m_RegisteredForEvents )
      {
         logic_uScriptCon_CompareGameObjects_B_1 = GameObject.Find( "detect_floor" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == _Person_Controller || false == m_RegisteredForEvents )
      {
         _Person_Controller = GameObject.Find( "First Person Controller" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Person_Controller_previous != _Person_Controller || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != _Person_Controller_previous )
         {
            {
               uScript_Triggers component = _Person_Controller_previous.GetComponent<uScript_Triggers>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         _Person_Controller_previous = _Person_Controller;
         
         //setup new listeners
         if ( null != _Person_Controller )
         {
            {
               uScript_Triggers component = _Person_Controller.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_0;
               }
            }
            {
               uScript_Triggers component = _Person_Controller.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_40_UnityEngine_GameObject_previous != local_40_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_40_UnityEngine_GameObject_previous = local_40_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_42_UnityEngine_GameObject_previous != local_42_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_42_UnityEngine_GameObject_previous = local_42_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Person_Controller_previous != _Person_Controller || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != _Person_Controller_previous )
         {
            {
               uScript_Triggers component = _Person_Controller_previous.GetComponent<uScript_Triggers>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         _Person_Controller_previous = _Person_Controller;
         
         //setup new listeners
         if ( null != _Person_Controller )
         {
            {
               uScript_Triggers component = _Person_Controller.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_0;
               }
            }
            {
               uScript_Triggers component = _Person_Controller.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_40_UnityEngine_GameObject_previous != local_40_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_40_UnityEngine_GameObject_previous = local_40_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_42_UnityEngine_GameObject_previous != local_42_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_42_UnityEngine_GameObject_previous = local_42_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != _Person_Controller )
      {
         {
            uScript_Triggers component = _Person_Controller.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_4.SetParent(g);
      logic_uScriptAct_Teleport_uScriptAct_Teleport_5.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_8.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_15.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_19.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_25.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_26.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_31.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_35.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_38.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_39.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_41.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_43.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_45.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_46.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_48.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_50.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_52.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.SetParent(g);
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54.SetParent(g);
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_55.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Finished += uScriptAct_MoveToLocationRelative_Finished_6;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Finished += uScriptAct_MoveToLocationRelative_Finished_20;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.Finished += uScriptAct_MoveToLocationRelative_Finished_27;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.Finished += uScriptAct_MoveToLocationRelative_Finished_30;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Finished -= uScriptAct_MoveToLocationRelative_Finished_6;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Finished -= uScriptAct_MoveToLocationRelative_Finished_20;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.Finished -= uScriptAct_MoveToLocationRelative_Finished_27;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.Finished -= uScriptAct_MoveToLocationRelative_Finished_30;
   }
   
   void Instance_OnEnterTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Instance_WhileInsideTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_0( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_6( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_20( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_27(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_27( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_30( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      local_11_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_1();
   }
   
   void Relay_OnExitTrigger_0()
   {
      local_11_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      local_11_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_53();
      Relay_In_50();
      Relay_In_45();
   }
   
   void Relay_In_1()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_1 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.In(logic_uScriptCon_CompareGameObjects_A_1, logic_uScriptCon_CompareGameObjects_B_1, logic_uScriptCon_CompareGameObjects_CompareByTag_1, logic_uScriptCon_CompareGameObjects_CompareByName_1, logic_uScriptCon_CompareGameObjects_ReportNull_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.Same;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_3()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_3 = local_lift_make_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.In(logic_uScriptAct_GetChildrenByName_Target_3, logic_uScriptAct_GetChildrenByName_Name_3, logic_uScriptAct_GetChildrenByName_SearchMethod_3, logic_uScriptAct_GetChildrenByName_recursive_3, out logic_uScriptAct_GetChildrenByName_FirstChild_3, out logic_uScriptAct_GetChildrenByName_Children_3, out logic_uScriptAct_GetChildrenByName_ChildrenCount_3);
      local_13_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_4 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_4.In(logic_uScriptAct_GetParent_Target_4, out logic_uScriptAct_GetParent_Parent_4);
      local_etage_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_4;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_13_UnityEngine_GameObject);
            logic_uScriptAct_Teleport_Target_5 = properties.ToArray();
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_Teleport_Destination_5 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_Teleport_uScriptAct_Teleport_5.In(logic_uScriptAct_Teleport_Target_5, logic_uScriptAct_Teleport_Destination_5, logic_uScriptAct_Teleport_UpdateRotation_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Finished_6()
   {
      Relay_SendCustomEvent_55();
   }
   
   void Relay_In_6()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_6 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_6 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.In(logic_uScriptAct_MoveToLocationRelative_targetArray_6, logic_uScriptAct_MoveToLocationRelative_location_6, logic_uScriptAct_MoveToLocationRelative_source_6, logic_uScriptAct_MoveToLocationRelative_totalTime_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_6()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_6 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_6 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_6, logic_uScriptAct_MoveToLocationRelative_location_6, logic_uScriptAct_MoveToLocationRelative_source_6, logic_uScriptAct_MoveToLocationRelative_totalTime_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_40_UnityEngine_GameObject_previous != local_40_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_40_UnityEngine_GameObject_previous = local_40_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_8 = local_40_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_8.In(logic_uScriptAct_GetParent_Target_8, out logic_uScriptAct_GetParent_Parent_8);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_8;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
         Relay_In_38();
      }
   }
   
   void Relay_In_9()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_9 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.In(logic_uScriptAct_GetChildrenByName_Target_9, logic_uScriptAct_GetChildrenByName_Name_9, logic_uScriptAct_GetChildrenByName_SearchMethod_9, logic_uScriptAct_GetChildrenByName_recursive_9, out logic_uScriptAct_GetChildrenByName_FirstChild_9, out logic_uScriptAct_GetChildrenByName_Children_9, out logic_uScriptAct_GetChildrenByName_ChildrenCount_9);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_9;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_15()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_15 = local_etage_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_15.In(logic_uScriptAct_GetParent_Target_15, out logic_uScriptAct_GetParent_Parent_15);
      local_lift_make_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_15;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_15.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_17 = BOTTOM;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.In(logic_uScriptAct_OnInputEventFilter_KeyCode_17);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_19();
         Relay_SendCustomEvent_54();
      }
   }
   
   void Relay_In_19()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_19 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_19.In(logic_uScriptAct_GetChildrenByName_Target_19, logic_uScriptAct_GetChildrenByName_Name_19, logic_uScriptAct_GetChildrenByName_SearchMethod_19, logic_uScriptAct_GetChildrenByName_recursive_19, out logic_uScriptAct_GetChildrenByName_FirstChild_19, out logic_uScriptAct_GetChildrenByName_Children_19, out logic_uScriptAct_GetChildrenByName_ChildrenCount_19);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_19;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_19.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
   }
   
   void Relay_Finished_20()
   {
      Relay_SendCustomEvent_55();
   }
   
   void Relay_In_20()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_20 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_20 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.In(logic_uScriptAct_MoveToLocationRelative_targetArray_20, logic_uScriptAct_MoveToLocationRelative_location_20, logic_uScriptAct_MoveToLocationRelative_source_20, logic_uScriptAct_MoveToLocationRelative_totalTime_20);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_20()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_20 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_20 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_20, logic_uScriptAct_MoveToLocationRelative_location_20, logic_uScriptAct_MoveToLocationRelative_source_20, logic_uScriptAct_MoveToLocationRelative_totalTime_20);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_22()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_22 = TOP;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.In(logic_uScriptAct_OnInputEventFilter_KeyCode_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_25();
         Relay_SendCustomEvent_54();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_25 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_25.In(logic_uScriptAct_GetChildrenByName_Target_25, logic_uScriptAct_GetChildrenByName_Name_25, logic_uScriptAct_GetChildrenByName_SearchMethod_25, logic_uScriptAct_GetChildrenByName_recursive_25, out logic_uScriptAct_GetChildrenByName_FirstChild_25, out logic_uScriptAct_GetChildrenByName_Children_25, out logic_uScriptAct_GetChildrenByName_ChildrenCount_25);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_25;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_25.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_27();
      }
   }
   
   void Relay_In_26()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_42_UnityEngine_GameObject_previous != local_42_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_42_UnityEngine_GameObject_previous = local_42_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_26 = local_42_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_26.In(logic_uScriptAct_GetParent_Target_26, out logic_uScriptAct_GetParent_Parent_26);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_26;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_26.Out;
      
      if ( test_0 == true )
      {
         Relay_In_22();
      }
   }
   
   void Relay_Finished_27()
   {
      Relay_SendCustomEvent_55();
   }
   
   void Relay_In_27()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_27 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_27 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.In(logic_uScriptAct_MoveToLocationRelative_targetArray_27, logic_uScriptAct_MoveToLocationRelative_location_27, logic_uScriptAct_MoveToLocationRelative_source_27, logic_uScriptAct_MoveToLocationRelative_totalTime_27);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_27()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_27 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_27 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_27.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_27, logic_uScriptAct_MoveToLocationRelative_location_27, logic_uScriptAct_MoveToLocationRelative_source_27, logic_uScriptAct_MoveToLocationRelative_totalTime_27);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_29 = BOTTOM;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.In(logic_uScriptAct_OnInputEventFilter_KeyCode_29);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_31();
         Relay_SendCustomEvent_54();
      }
   }
   
   void Relay_Finished_30()
   {
      Relay_SendCustomEvent_55();
   }
   
   void Relay_In_30()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_30 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_30 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.In(logic_uScriptAct_MoveToLocationRelative_targetArray_30, logic_uScriptAct_MoveToLocationRelative_location_30, logic_uScriptAct_MoveToLocationRelative_source_30, logic_uScriptAct_MoveToLocationRelative_totalTime_30);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_30()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            properties.Add((UnityEngine.GameObject)local_lift_active_UnityEngine_GameObject);
            logic_uScriptAct_MoveToLocationRelative_targetArray_30 = properties.ToArray();
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_30 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_30.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_30, logic_uScriptAct_MoveToLocationRelative_location_30, logic_uScriptAct_MoveToLocationRelative_source_30, logic_uScriptAct_MoveToLocationRelative_totalTime_30);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_31()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_31 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_31.In(logic_uScriptAct_GetChildrenByName_Target_31, logic_uScriptAct_GetChildrenByName_Name_31, logic_uScriptAct_GetChildrenByName_SearchMethod_31, logic_uScriptAct_GetChildrenByName_recursive_31, out logic_uScriptAct_GetChildrenByName_FirstChild_31, out logic_uScriptAct_GetChildrenByName_Children_31, out logic_uScriptAct_GetChildrenByName_ChildrenCount_31);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_31;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_31.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_In_35()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_35 = local_44_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_35.In(logic_uScriptAct_GetParent_Target_35, out logic_uScriptAct_GetParent_Parent_35);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_35;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_35.Out;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_38()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_38 = TOP;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_38.In(logic_uScriptAct_OnInputEventFilter_KeyCode_38);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_38.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_9();
         Relay_SendCustomEvent_54();
      }
   }
   
   void Relay_In_39()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_39 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_39.In(logic_uScriptAct_GetParent_Target_39, out logic_uScriptAct_GetParent_Parent_39);
      local_40_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_39;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_40_UnityEngine_GameObject_previous != local_40_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_40_UnityEngine_GameObject_previous = local_40_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_39.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_In_41()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_41 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_41.In(logic_uScriptAct_GetParent_Target_41, out logic_uScriptAct_GetParent_Parent_41);
      local_42_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_41;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_42_UnityEngine_GameObject_previous != local_42_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_42_UnityEngine_GameObject_previous = local_42_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_41.Out;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
   }
   
   void Relay_In_43()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_43 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_43.In(logic_uScriptAct_GetParent_Target_43, out logic_uScriptAct_GetParent_Parent_43);
      local_44_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_43;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_43.Out;
      
      if ( test_0 == true )
      {
         Relay_In_35();
      }
   }
   
   void Relay_In_45()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_45 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_45.In(logic_uScriptAct_GetGameObjectName_gameObject_45, out logic_uScriptAct_GetGameObjectName_name_45);
      local_47_System_String = logic_uScriptAct_GetGameObjectName_name_45;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_45.Out;
      
      if ( test_0 == true )
      {
         Relay_In_46();
      }
   }
   
   void Relay_In_46()
   {
      {
         {
            logic_uScriptCon_CompareString_A_46 = local_47_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_46.In(logic_uScriptCon_CompareString_A_46, logic_uScriptCon_CompareString_B_46);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_46.Same;
      
      if ( test_0 == true )
      {
         Relay_In_43();
      }
   }
   
   void Relay_In_48()
   {
      {
         {
            logic_uScriptCon_CompareString_A_48 = local_49_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_48.In(logic_uScriptCon_CompareString_A_48, logic_uScriptCon_CompareString_B_48);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_48.Same;
      
      if ( test_0 == true )
      {
         Relay_In_41();
      }
   }
   
   void Relay_In_50()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_50 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_50.In(logic_uScriptAct_GetGameObjectName_gameObject_50, out logic_uScriptAct_GetGameObjectName_name_50);
      local_49_System_String = logic_uScriptAct_GetGameObjectName_name_50;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_50.Out;
      
      if ( test_0 == true )
      {
         Relay_In_48();
      }
   }
   
   void Relay_In_52()
   {
      {
         {
            logic_uScriptCon_CompareString_A_52 = local_51_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_52.In(logic_uScriptCon_CompareString_A_52, logic_uScriptCon_CompareString_B_52);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_52.Same;
      
      if ( test_0 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_In_53()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_53 = local_11_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.In(logic_uScriptAct_GetGameObjectName_gameObject_53, out logic_uScriptAct_GetGameObjectName_name_53);
      local_51_System_String = logic_uScriptAct_GetGameObjectName_name_53;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.Out;
      
      if ( test_0 == true )
      {
         Relay_In_52();
      }
   }
   
   void Relay_SendCustomEvent_54()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54.SendCustomEvent(logic_uScriptAct_SendCustomEvent_EventName_54, logic_uScriptAct_SendCustomEvent_sendGroup_54, logic_uScriptAct_SendCustomEvent_EventSender_54);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_SendCustomEvent_55()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_55.SendCustomEvent(logic_uScriptAct_SendCustomEvent_EventName_55, logic_uScriptAct_SendCustomEvent_sendGroup_55, logic_uScriptAct_SendCustomEvent_EventSender_55);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
