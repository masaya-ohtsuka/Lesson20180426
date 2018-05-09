using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour {
    // ①変数の定義(データを入れるための箱を作ること)
    // アクセス修飾子 + 型名 + 変数名
    public GameObject target;
    private Vector3 offset;

    // ゲームが開始した時点で一回だけ呼び出される。
	// Use this for initialization
	void Start () {
        // ②代入(右辺のデータを左辺に入れること)
        // =は左右が等しいではない。
        // ==は左右が等しい
        offset = transform.position - target.transform.position;
	}

    // Update is called once per frame
    // フレームが更新される度ごとに呼び出される。
    void Update () {
        // ③データの入った箱を活用する。
        transform.position = target.transform.position + offset;
	}
}
