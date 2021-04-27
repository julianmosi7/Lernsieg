(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["rank-rank-module"],{

/***/ "I8jv":
/*!***************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/rank/rank.page.html ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ion-header>\n  <ion-toolbar>\n    <ion-title>Rangliste</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content [fullscreen]=\"true\">\n  <ion-header collapse=\"condense\">\n    <ion-toolbar>\n      <ion-title size=\"large\">Rangliste</ion-title>\n    </ion-toolbar>\n  </ion-header>\n\n  <div id=\"container\">\n    <ion-list>\n      <div *ngFor=\"let rank of ranks.ranklist;let i = index\">\n        <ion-item>\n          <ion-label [style.background-color]=\"i == 0 ? 'gold' : i == 1 ? 'silver' : i == 2 ? 'brown' : ''\">{{i+1}}.</ion-label>\n          <ion-label [style.background-color]=\"i == 0 ? 'gold' : i == 1 ? 'silver' : i == 2 ? 'brown' : ''\">{{rank.name}}</ion-label>\n          <ion-label [style.background-color]=\"i == 0 ? 'gold' : i == 1 ? 'silver' : i == 2 ? 'brown' : ''\">{{rank.price | currency:'EUR'}}</ion-label>\n        </ion-item>\n      </div>\n    </ion-list>\n  </div>\n</ion-content>\n\n<ion-footer>\n  <ion-toolbar>\n    <navbar></navbar>\n  </ion-toolbar>\n</ion-footer>");

/***/ }),

/***/ "Nwa7":
/*!*************************************!*\
  !*** ./src/app/rank/rank.module.ts ***!
  \*************************************/
/*! exports provided: RankPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RankPageModule", function() { return RankPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "s7LF");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _rank_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./rank-routing.module */ "S0yf");
/* harmony import */ var _rank_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./rank.page */ "jYRm");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common/http */ "IheW");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../shared/shared.module */ "PCNd");









let RankPageModule = class RankPageModule {
};
RankPageModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonicModule"],
            _rank_routing_module__WEBPACK_IMPORTED_MODULE_5__["RankPageRoutingModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_7__["HttpClientModule"],
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_8__["SharedModule"]
        ],
        declarations: [_rank_page__WEBPACK_IMPORTED_MODULE_6__["RankPage"]]
    })
], RankPageModule);



/***/ }),

/***/ "S0yf":
/*!*********************************************!*\
  !*** ./src/app/rank/rank-routing.module.ts ***!
  \*********************************************/
/*! exports provided: RankPageRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RankPageRoutingModule", function() { return RankPageRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "iInd");
/* harmony import */ var _rank_page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./rank.page */ "jYRm");




const routes = [
    {
        path: '',
        component: _rank_page__WEBPACK_IMPORTED_MODULE_3__["RankPage"]
    }
];
let RankPageRoutingModule = class RankPageRoutingModule {
};
RankPageRoutingModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
    })
], RankPageRoutingModule);



/***/ }),

/***/ "Zrqz":
/*!*************************************!*\
  !*** ./src/app/rank/rank.page.scss ***!
  \*************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".hightlight {\n  background-color: gold;\n}\n\n:host ion-item {\n  background-color: green;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uLy4uLy4uL3JhbmsucGFnZS5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksc0JBQUE7QUFDSjs7QUFHSTtFQUNJLHVCQUFBO0FBQVIiLCJmaWxlIjoicmFuay5wYWdlLnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuaGlnaHRsaWdodHtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiBnb2xkO1xufVxuXG46aG9zdHtcbiAgICBpb24taXRlbXtcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogZ3JlZW47XG4gICAgfVxufSJdfQ== */");

/***/ }),

/***/ "jYRm":
/*!***********************************!*\
  !*** ./src/app/rank/rank.page.ts ***!
  \***********************************/
/*! exports provided: RankPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RankPage", function() { return RankPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _raw_loader_rank_page_html__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! raw-loader!./rank.page.html */ "I8jv");
/* harmony import */ var _rank_page_scss__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./rank.page.scss */ "Zrqz");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../core/lotto.service */ "28ja");





let RankPage = class RankPage {
    constructor(lottoService) {
        this.lottoService = lottoService;
        this.ranks = { ranklist: [{ name: '', price: 0 }], status: '', msg: '' };
    }
    ngOnInit() {
        this.lottoService.getRanklist().subscribe(x => {
            this.ranks = x;
            console.log(this.ranks.ranklist);
        });
    }
};
RankPage.ctorParameters = () => [
    { type: _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__["LottoService"] }
];
RankPage = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["Component"])({
        selector: 'app-rank',
        template: _raw_loader_rank_page_html__WEBPACK_IMPORTED_MODULE_1__["default"],
        styles: [_rank_page_scss__WEBPACK_IMPORTED_MODULE_2__["default"]]
    })
], RankPage);



/***/ })

}]);
//# sourceMappingURL=rank-rank-module.js.map