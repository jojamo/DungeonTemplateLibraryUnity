﻿/*#######################################################################################
    Copyright (c) 2017-2019 Kasugaccho
    Copyright (c) 2018-2019 As Project
    https://github.com/Kasugaccho/DungeonTemplateLibrary
    wanotaitei@gmail.com

    DungeonTemplateLibraryUnity
    https://github.com/sitRyo/DungeonTemplateLibraryUnity
    seriru.rcvmailer@gmail.com

    Distributed under the Boost Software License, Version 1.0. (See accompanying
    file LICENSE_1_0.txt or copy at http://www.boost.org/LICENSE_1_0.txt)
#######################################################################################*/

using System;
using DTL.Base;
using DTL.Shape;
using UnityEngine;
using MatrixRange = DTL.Base.Coordinate2DimensionalAndLength2Dimensional;

/*
 * Range機能(配列の特定の範囲を描画する機能)は未実装.
 * 将来的に実装することを見据えて名前空間は本家DTLに倣うことにする.
 */

namespace DTL.Range {

    /*#######################################################################################
        [概要] "dtl名前空間"とは"DungeonTemplateLibrary"の全ての機能が含まれる名前空間である。
        [Summary] The "dtl" is a namespace that contains all the functions of "DungeonTemplateLibrary".
    #######################################################################################*/

    class RectBaseRogueLike<TDerived> where TDerived : RectBaseRogueLike<TDerived> {
        public RogueLikeList rogueLikeList { get; protected set; }
        public uint maxWay { get; protected set; } = 20;
        protected MatrixRange roomRange = new MatrixRange(3, 3, 3, 3);
        protected MatrixRange wayRange = new MatrixRange(3, 3, 12, 12);

        /* Get Member Value */

        public int outSideWall {
            get => this.rogueLikeList.outsideWallId;
        }

        public int insideWall {
            get => this.rogueLikeList.insideWallId; 
        }

        public int room {
            get => this.rogueLikeList.roomId;
        }

        public int entrance {
            get => this.rogueLikeList.entranceId;
        }

        public int way {
            get => this.rogueLikeList.wayId;
        }

        public int wall {
            get => this.rogueLikeList.outsideWallId;
        }

        /* Clear */
        public TDerived ClearOutsideWall() {
            this.rogueLikeList.outsideWallId = 0;
            return (TDerived)this;
        }

        public TDerived ClearInsideWall() {
            this.rogueLikeList.insideWallId = 0;
            return (TDerived)this;
        }

        public TDerived ClearRoom() {
            this.rogueLikeList.roomId = 0;
            return (TDerived)this;
        }

        public TDerived ClearEntrance() {
            this.rogueLikeList.entranceId = 0;
            return (TDerived)this;
        }

        public TDerived ClearWall() {
            ClearInsideWall();
            ClearOutsideWall();
            return (TDerived)this;
        }

        public TDerived ClearMaxWay() {
            this.maxWay = 0;
            return (TDerived) this;
        }

        public TDerived ClearValue() {
            this.rogueLikeList = new RogueLikeList();
            ClearMaxWay();
            return (TDerived) this;
        }

        /* Constructors */

        public RectBaseRogueLike() { } // = default();

        public RectBaseRogueLike(RogueLikeList drawValue) {
            this.rogueLikeList = drawValue;
        }

        public RectBaseRogueLike(RogueLikeList drawValue, uint maxWay) {
            this.rogueLikeList = drawValue;
            this.maxWay = maxWay;
        }

        public RectBaseRogueLike(RogueLikeList drawValue, uint maxWay, MatrixRange roomRange) {
            this.rogueLikeList = drawValue;
            this.maxWay = maxWay;
            this.roomRange = roomRange;
        }

        public RectBaseRogueLike(RogueLikeList drawValue, uint maxWay, MatrixRange roomRange, MatrixRange wayRange) {
            this.rogueLikeList = drawValue;
            this.maxWay = maxWay;
            this.roomRange = roomRange;
            this.wayRange = wayRange;
        }

        public RectBaseRogueLike(int outsideWallId, int insideWallId, int roomId, int entranceId, int wayId) {
            this.rogueLikeList = new RogueLikeList(outsideWallId, insideWallId, roomId, entranceId, wayId);
        }

        public RectBaseRogueLike(int outsideWallId, int insideWallId, int roomId, int entranceId, int wayId, MatrixRange roomRange) {
            this.rogueLikeList = new RogueLikeList(outsideWallId, insideWallId, roomId, entranceId, wayId);
            this.roomRange = roomRange;
        }

        public RectBaseRogueLike(int outsideWallId, int insideWallId, int roomId, int entranceId, int wayId, MatrixRange roomRange, MatrixRange wayRange) {
            this.rogueLikeList = new RogueLikeList(outsideWallId, insideWallId, roomId, entranceId, wayId);
            this.roomRange = roomRange;
            this.wayRange = wayRange;
        }

    }

}


