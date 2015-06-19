//uScript Generated Code - Build 0.9.2275
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class active_anim : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.String Close = "";
   System.Single local_12_System_Single = (float) 0;
   System.Single local_13_System_Single = (float) 0;
   System.Single local_16_System_Single = (float) 0;
   System.Single local_18_System_Single = (float) 0;
   public System.String Open = "";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_14 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_2 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_2 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_2 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_2;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_2;
   System.Single logic_uScriptAct_GetAnimationState_animLength_2;
   System.Single logic_uScriptAct_GetAnimationState_speed_2;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_2;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_2;
   bool logic_uScriptAct_GetAnimationState_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_3 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_3 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_3 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_3 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_3 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_4 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_5 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_5 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_5 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_5 = (float) 0;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_7 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_7 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = (float) 0;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_8 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_8 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_8 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_8 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_8 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_8 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_9 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_9 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_9 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_9;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_9;
   System.Single logic_uScriptAct_GetAnimationState_animLength_9;
   System.Single logic_uScriptAct_GetAnimationState_speed_9;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_9;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_9;
   bool logic_uScriptAct_GetAnimationState_Out_9 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_10 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_10 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_10 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_11 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_11 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_11 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_11 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_11 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_15 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_15 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_15 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_15;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_15;
   bool logic_uScriptAct_SubtractFloat_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_17 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_17 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_17;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_17;
   bool logic_uScriptAct_SubtractFloat_Out_17 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_1 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = null;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_0 || false == m_RegisteredForEvents )
      {
         owner_Connection_0 = parentGameObject;
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      if ( null == owner_Connection_14 || false == m_RegisteredForEvents )
      {
         owner_Connection_14 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_0 )
      {
         {
            uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_2.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_4.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_5.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_8.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_9.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_15.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3.Finished += uScriptAct_PlayAnimation_Finished_3;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_5.Out += uScriptAct_SetAnimationPosition_Out_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out += uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11.Finished += uScriptAct_PlayAnimation_Finished_11;
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
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3.Finished -= uScriptAct_PlayAnimation_Finished_3;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_5.Out -= uScriptAct_SetAnimationPosition_Out_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out -= uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11.Finished -= uScriptAct_PlayAnimation_Finished_11;
   }
   
   void Instance_OnEnterTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void uScriptAct_PlayAnimation_Finished_3(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_3( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_5( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_7( );
   }
   
   void uScriptAct_PlayAnimation_Finished_11(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_11( );
   }
   
   void Relay_OnEnterTrigger_1()
   {
      Relay_In_4();
   }
   
   void Relay_OnExitTrigger_1()
   {
      Relay_In_6();
   }
   
   void Relay_WhileInsideTrigger_1()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_2 = owner_Connection_14;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_2 = Close;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_2.In(logic_uScriptAct_GetAnimationState_target_2, logic_uScriptAct_GetAnimationState_animationName_2, out logic_uScriptAct_GetAnimationState_weight_2, out logic_uScriptAct_GetAnimationState_normalizedPosition_2, out logic_uScriptAct_GetAnimationState_animLength_2, out logic_uScriptAct_GetAnimationState_speed_2, out logic_uScriptAct_GetAnimationState_layer_2, out logic_uScriptAct_GetAnimationState_wrapMode_2);
      local_16_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_2;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_Finished_3()
   {
   }
   
   void Relay_In_3()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_14);
            logic_uScriptAct_PlayAnimation_Target_3 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_3 = Open;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_3.In(logic_uScriptAct_PlayAnimation_Target_3, logic_uScriptAct_PlayAnimation_Animation_3, logic_uScriptAct_PlayAnimation_SpeedFactor_3, logic_uScriptAct_PlayAnimation_AnimWrapMode_3, logic_uScriptAct_PlayAnimation_StopOtherAnimations_3);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_4()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_4.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_Out_5()
   {
      Relay_In_3();
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_5 = owner_Connection_14;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_5 = Open;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_5 = local_13_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_5.In(logic_uScriptAct_SetAnimationPosition_target_5, logic_uScriptAct_SetAnimationPosition_animationName_5, logic_uScriptAct_SetAnimationPosition_normalizedPosition_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_6()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_Out_7()
   {
      Relay_In_11();
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_7 = owner_Connection_14;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_7 = Close;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = local_12_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.In(logic_uScriptAct_SetAnimationPosition_target_7, logic_uScriptAct_SetAnimationPosition_animationName_7, logic_uScriptAct_SetAnimationPosition_normalizedPosition_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_8 = local_13_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_8.In(logic_uScriptCon_CompareFloat_A_8, logic_uScriptCon_CompareFloat_B_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_8.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_8.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
      if ( test_1 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_9 = owner_Connection_14;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_9 = Open;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_9.In(logic_uScriptAct_GetAnimationState_target_9, logic_uScriptAct_GetAnimationState_animationName_9, out logic_uScriptAct_GetAnimationState_weight_9, out logic_uScriptAct_GetAnimationState_normalizedPosition_9, out logic_uScriptAct_GetAnimationState_animLength_9, out logic_uScriptAct_GetAnimationState_speed_9, out logic_uScriptAct_GetAnimationState_layer_9, out logic_uScriptAct_GetAnimationState_wrapMode_9);
      local_18_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_9;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_9.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_10 = local_12_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.In(logic_uScriptCon_CompareFloat_A_10, logic_uScriptCon_CompareFloat_B_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_11();
      }
      if ( test_1 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_Finished_11()
   {
   }
   
   void Relay_In_11()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_14);
            logic_uScriptAct_PlayAnimation_Target_11 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_11 = Close;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_11.In(logic_uScriptAct_PlayAnimation_Target_11, logic_uScriptAct_PlayAnimation_Animation_11, logic_uScriptAct_PlayAnimation_SpeedFactor_11, logic_uScriptAct_PlayAnimation_AnimWrapMode_11, logic_uScriptAct_PlayAnimation_StopOtherAnimations_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_15()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_15 = local_16_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_15.In(logic_uScriptAct_SubtractFloat_A_15, logic_uScriptAct_SubtractFloat_B_15, out logic_uScriptAct_SubtractFloat_FloatResult_15, out logic_uScriptAct_SubtractFloat_IntResult_15);
      local_13_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_15;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_15.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_17 = local_18_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.In(logic_uScriptAct_SubtractFloat_A_17, logic_uScriptAct_SubtractFloat_B_17, out logic_uScriptAct_SubtractFloat_FloatResult_17, out logic_uScriptAct_SubtractFloat_IntResult_17);
      local_12_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
}
