//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ElevatorMovement : MonoBehaviour
//{
//    [SerializeField] private GameObject elevatorDoorUpper;
//    [SerializeField] private GameObject elevatorDoorLower;
//    [SerializeField] private GameObject elevatorPosition;

//    private bool isElevatorMovingUp = false;

//    private void OnTriggerEnter(Collider other)
//    {
//        Debug.Log("Open door");

//        if (other.CompareTag("Player"))
//        {
//            if (IsPlayerAboveElevator())
//            {
//                OpenUpperDoor();
//            }
//            else
//            {
//                OpenLowerDoor();
//            }
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        Debug.Log("Close door");

//        if (other.CompareTag("Player"))
//        {
//            if (IsPlayerAboveElevator())
//            {
//                CloseUpperDoor();
//            }
//            else
//            {
//                CloseLowerDoor();
//            }
//        }
//    }

//    private void OnTriggerStay(Collider other)
//    {
//        Debug.Log("Elevator movement");

//        if (other.CompareTag("Player"))
//        {
//            if (IsPlayerAboveElevator())
//            {
//                // Elevator moves up
//                MoveElevatorUp();
//            }
//            else
//            {
//                // Elevator moves down
//                MoveElevatorDown();
//            }
//        }
//    }

//    private void OpenUpperDoor()
//    {
//        // Implement door opening logic for the upper floor
//    }

//    private void CloseUpperDoor()
//    {
//        // Implement door closing logic for the upper floor
//    }

//    private void OpenLowerDoor()
//    {
//        // Implement door opening logic for the lower floor
//    }

//    private void CloseLowerDoor()
//    {
//        // Implement door closing logic for the lower floor
//    }

//    private void MoveElevatorUp()
//    {
//        // Implement elevator moving up logic
//    }

//    private void MoveElevatorDown()
//    {
//        // Implement elevator moving down logic
//    }

//    private bool IsPlayerAboveElevator()
//    {
//        // Determine if the player is above the elevator (you can use position checks)
//        return false; // Replace with your logic
//    }
//}
