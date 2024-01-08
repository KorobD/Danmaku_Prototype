using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PathPoints  {
    public static List<Vector3> mainPoints = new List<Vector3>();

    static PathPoints() {
  /*[0]*/mainPoints.Add(new Vector3(-4.99f, 5.5f, 0));//......TopPoint_1
  /*[1]*/mainPoints.Add(new Vector3(-3.49f, 5.5f, 0));//......TopPoint_2
  /*[2]*/mainPoints.Add(new Vector3(-1.99f, 5.5f, 0));//......TopPoint_3
  /*[3]*/mainPoints.Add(new Vector3(-0.49f, 5.5f, 0));//......TopPoint_4
  /*[4]*/mainPoints.Add(new Vector3(1.01f, 5.5f, 0));//.......TopPoint_5
  /*[5]*/mainPoints.Add(new Vector3(-4.99f, -5.5f, 0));//..BottomPoint_1
  /*[6]*/mainPoints.Add(new Vector3(-3.49f, -5.5f, 0));//..BottomPoint_2
  /*[7]*/mainPoints.Add(new Vector3(-1.99f, -5.5f, 0));//..BottomPoint_3
  /*[8]*/mainPoints.Add(new Vector3(-0.49f, -5.5f, 0));//..BottomPoint_4
  /*[9]*/mainPoints.Add(new Vector3(1.01f, -5.5f, 0));//...BottomPoint_5
 /*[10]*/mainPoints.Add(new Vector3(-6.39f, 4.2f, 0));//.....LeftPoint_1
 /*[11]*/mainPoints.Add(new Vector3(-6.39f, 2.1f, 0));//.....LeftPoint_2
 /*[12]*/mainPoints.Add(new Vector3(-6.39f, 0, 0));//........LeftPoint_3
 /*[13]*/mainPoints.Add(new Vector3(-6.39f, -2.1f, 0));//....LeftPoint_4
 /*[14]*/mainPoints.Add(new Vector3(-6.39f, -4.2f, 0));//....LeftPoint_5
 /*[15]*/mainPoints.Add(new Vector3(2.41f, 4.2f, 0));//.....RightPoint_1
 /*[16]*/mainPoints.Add(new Vector3(2.41f, 2.1f, 0));//.....RightPoint_2
 /*[17]*/mainPoints.Add(new Vector3(2.41f, 0, 0));//........RightPoint_3
 /*[18]*/mainPoints.Add(new Vector3(2.41f, -2.1f, 0));//....RightPoint_4
 /*[19]*/mainPoints.Add(new Vector3(2.41f, -4.2f, 0));//....RightPoint_5
 /*[20]*/mainPoints.Add(new Vector3(-1.99f, 0, 0));//.............Center
    }
}